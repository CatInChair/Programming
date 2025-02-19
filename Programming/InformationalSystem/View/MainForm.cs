using InformationalSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationalSystem
{
    public partial class MainForm : Form
    {
        private List<AirRoute> _routes = new List<AirRoute>();
        private AirRoute _currentRoute;

        public MainForm()
        {
            InitializeComponent();
            InitializeListeners();

            this.comboBoxType.Items.AddRange(new string[] { "International", "Internal" });

            if (File.Exists("data.txt"))
            {
                StreamReader sr = new StreamReader("data.txt");
                string line = sr.ReadToEnd();
                Console.WriteLine(line);

                _routes = Serializer.Deserialize(line);
                OutputRoutes();
                sr.Close();
            }
        }

        public void ButtonSave_Click(object sender, EventArgs arg) 
        {
            StreamWriter sw = new StreamWriter("data.txt");

            sw.Write(Serializer.Serialize(_routes));

            sw.Close();
        }

        /// <summary>
        /// Вставляет новый пустой экземпляр <see cref="AirRoute"/> в список рейсов.
        /// </summary>
        private void InsertRouteIntoList()
        {
            AirRoute route = new AirRoute();

            _routes.Add(route);
            _routes.Sort();
            OutputRoutes();
        }

        /// <summary>
        /// Исключает выбранный рейс из списка экземпляров <see cref="AirRoute"/>.
        /// </summary>
        private void RemoveRouteFromList()
        {
            _routes.Remove(_currentRoute);
        }

        /// <summary>
        /// Выводит в эелемент <see cref="ListBox"/> все экзмепляры <see cref="AirRoute"/>, хранящиеся в форме.
        /// </summary>
        private void OutputRoutes()
        {
            this.listBoxRoutes.Items.Clear();

            foreach (AirRoute route in _routes) 
            {
                this.listBoxRoutes.Items.Add(route.ToString());
            }
        }

        /// <summary>
        /// Обновляет информацию о выбранном экземпляре <see cref="AirRoute"/> в <see cref="ListBox"/> элементе.
        /// </summary>
        private void UpdateRoute()
        {
            this.listBoxRoutes.Items[this.listBoxRoutes.SelectedIndex] = _currentRoute.ToString();
        }

        /// <summary>
        /// Выводит информацию о выбранном экземпляре <see cref="AirRoute"/>.
        /// </summary>
        private void ShowRouteInfo()
        {
            this.textBoxDeparturePoint.Text = _currentRoute.DeparturePoint == null ? "" : _currentRoute.DeparturePoint;
            this.textBoxArrivalPoint.Text = _currentRoute.ArrivalPoint == null ? "" : _currentRoute.ArrivalPoint;
            this.textBoxDuration.Text = _currentRoute.Duration.ToString();
            this.comboBoxType.SelectedIndex = _currentRoute.Type;
            this.dateTimePickerDepartureTime.Value = _currentRoute.DepartureTime;
        }

        private void ButtonAdd_Click(object sender, EventArgs arg)
        {
            InsertRouteIntoList();
        }
        private void ButtonRemove_Click(object sender, EventArgs arg)
        {
            if (this.listBoxRoutes.SelectedIndex == -1)
            {
                MessageBox.Show("Change route from ListBox before.");

                return;
            }

            this.listBoxRoutes.Items.RemoveAt(this.listBoxRoutes.SelectedIndex);
            RemoveRouteFromList();
        }
        private void TextBoxArrivalPoint_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxArrivalPoint.BackColor = SystemColors.Window;

            if (this.textBoxArrivalPoint.Text == "")
            {
                return;
            }

            if (this.listBoxRoutes.SelectedIndex == -1)
            {
                MessageBox.Show("Change route from ListBox before.");
                this.textBoxArrivalPoint.Clear();

                return;
            }

            try
            {
                _currentRoute.ArrivalPoint = this.textBoxArrivalPoint.Text;
                UpdateRoute();
            }
            catch
            {
                MessageBox.Show("String ArrivalPoint length must be less or equal than 100.");
                this.textBoxArrivalPoint.BackColor = Color.LightPink;
            }
        }
        private void TextBoxDeparturePoint_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxDeparturePoint.BackColor = SystemColors.Window;

            if (this.textBoxDeparturePoint.Text == "")
            {
                return;
            }

            if (this.listBoxRoutes.SelectedIndex == -1)
            {
                MessageBox.Show("Change route from ListBox before.");
                this.textBoxDeparturePoint.Clear();

                return;
            }

            try
            {
                _currentRoute.DeparturePoint = this.textBoxDeparturePoint.Text;
                UpdateRoute();
            }
            catch
            {
                MessageBox.Show("String DeparturePoint length must be less or equal than 100.");
                this.textBoxDeparturePoint.BackColor = Color.LightPink;
            }
        }
        private void TextBoxDuration_Duration(object sender, EventArgs arg)
        {
            this.textBoxDuration.BackColor = SystemColors.Window;

            if (this.textBoxDuration.Text == "")
            {
                return;
            }

            if (this.listBoxRoutes.SelectedIndex == -1)
            {
                MessageBox.Show("Change route from ListBox before.");
                this.textBoxDuration.Clear();

                return;
            }

            try
            {
                _currentRoute.Duration = Int32.Parse(this.textBoxDuration.Text);
            }
            catch 
            {
                MessageBox.Show("Duration must be integer less or equal than 1000 and more or equal than 0.");
                this.textBoxDuration.BackColor = Color.LightPink;
            }
        }
        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs arg)
        {
            if (this.listBoxRoutes.SelectedIndex == -1)
            {
                MessageBox.Show("Change route from ListBox before.");
                this.comboBoxType.ResetText();

                return;
            }

            _currentRoute.Type = this.comboBoxType.SelectedIndex;
        }
        private void DateTimePickerDepartureTime_ValueChanged(object sender, EventArgs arg)
        {
            this.dateTimePickerDepartureTime.BackColor = SystemColors.Window;

            if (this.dateTimePickerDepartureTime.Value == _currentRoute.DepartureTime)
            {
                return;
            }

            if (this.listBoxRoutes.SelectedIndex == -1)
            {
                MessageBox.Show("Change route from ListBox before.");

                return;
            }

            try
            {
                _currentRoute.DepartureTime = this.dateTimePickerDepartureTime.Value;
                UpdateRoute();
                _routes.Sort();
                OutputRoutes();

                this.listBoxRoutes.SelectedIndex = _routes.IndexOf(_currentRoute);
            }
            catch
            {
                MessageBox.Show("DepartureTime does affect the future.");
                this.dateTimePickerDepartureTime.BackColor = Color.LightPink;
            }
        }
        private void ListBoxRoutes_SelectedIndexChanged(object sender, EventArgs arg)
        {
            if (this.listBoxRoutes.SelectedIndex == -1)
            {
                return;
            }

            _currentRoute = _routes[this.listBoxRoutes.SelectedIndex];
            ShowRouteInfo();
        }
    }
}
