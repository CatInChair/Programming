using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace Programming.View.Pages
{
    public partial class EnumsControl : UserControl
    {
        Type[] Models = new Type[]
        {
            typeof(Model.Color),
            typeof(Model.EducationForm),
            typeof(Model.Genre),
            typeof(Model.Season),
            typeof(Model.SmartphoneManufactures),
            typeof(Model.Weekday)
        };
        private Form _mainForm;

        public EnumsControl(Form form)
        {
            InitializeComponent();
            InitializeListeners();

            Random random = new Random();
            _mainForm = form;

            this.listBoxEnums.Items.AddRange(Models.Select(e => e.Name).ToArray());
            this.listBoxEnums.SelectedIndex = 0;

            this.comboBoxSeason.Items.AddRange(Enum.GetNames(Models[3]));
        }
        private void ButtonParse_Click(object sender, EventArgs e)
        {
            if (this.textBoxParse.Text == "")
            {
                return;
            }

            Model.Weekday parsedValue;

            if (!Enum.TryParse(this.textBoxParse.Text, out parsedValue))
            {
                this.labelParseOutput.Text = "Нет такого дня недели";
                return;
            }

            this.labelParseOutput.Text = $"Это день недели ({parsedValue.ToString()} = {(int)parsedValue + 1})";
        }

        private void ButtonSeason_Click(object sender, EventArgs e)
        {
            _mainForm.BackColor = SystemColors.Window;

            switch (comboBoxSeason.SelectedIndex)
            {
                case 0:     //Summer
                    MessageBox.Show("Ура! Солнце!");
                    return;

                case 1:     //Autumn
                    _mainForm.BackColor = AppColors.AutumnColor;
                    return;

                case 2:     //Winter
                    MessageBox.Show("Брррр! Холодно!");
                    return;

                case 3:     //Spring
                    _mainForm.BackColor = AppColors.SpringColor;
                    return;
            }
        }

        private void ListBoxEnumsValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEnumsValues.SelectedIndex == -1)
            {
                return;
            }

            this.textBoxIntValue.Text = this.listBoxEnumsValues.SelectedIndex.ToString();
        }

        private void ListBoxEnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEnums.SelectedIndex == -1)
            {
                return;
            }

            this.listBoxEnumsValues.Items.Clear();

            this.listBoxEnumsValues.Items.AddRange(Enum.GetNames(Models[this.listBoxEnums.SelectedIndex]));
            this.listBoxEnumsValues.SelectedIndex = 0;

            this.textBoxIntValue.Text = "0";
        }

        private void TextBoxIntValue_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex;

            if (this.textBoxIntValue.Text == "")
            {
                return;
            }

            if (!int.TryParse(this.textBoxIntValue.Text, out selectedIndex))
            {
                MessageBox.Show("В поле \"Int value\" можно вводить лишь натуральные числа (включая ноль).");
                return;
            }

            this.listBoxEnumsValues.SelectedIndex = selectedIndex >= this.listBoxEnumsValues.Items.Count ? this.listBoxEnumsValues.Items.Count - 1 : selectedIndex;
        }
    }
}
