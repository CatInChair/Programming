using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Programming
{ 
    public partial class MainForm
    {
        private Model.Rectangle _currentRectangleCanva;
        private List<Model.Rectangle> _rectangleList = new List<Model.Rectangle> { };

        public void ButtonRectangleAdd_Click(object sender, EventArgs arg)
        {
            Random random = new Random();
            Model.Rectangle rectangle = new Model.Rectangle(random.Next(0, 20), random.Next(0, 20), _colors[random.Next(0, 4)], new Model.Point2D(random.Next(0, 100), random.Next(0, 100)));

            _rectangleList.Add(rectangle);

            AddRectangleToListBox(rectangle);
        }

        public void ButtonRectangleRemove_Click(object sender, EventArgs arg)
        {
            if (this.listBoxRectangleList.SelectedIndex != -1)
            {
                _currentRectangle = null;
                _rectangleList.RemoveAt(this.listBoxRectangleList.SelectedIndex);

                this.textBoxSelectedRectangleX.Clear();
                this.textBoxCenterY.Clear();
                this.textBoxSelectedRectangleY.Clear();
                this.textBoxSelectedRectangleWidth.Clear();
                this.textBoxSelectedRectangleHeight.Clear();
                this.textBoxSelectedRectangleId.Clear();


                RemoveRectangleFromListBox(this.listBoxRectangleList.SelectedIndex);
            }
            else
            {
                MessageBox.Show("You need to select element from ListBox before.");
            }
        }

        public void ListBoxRectangleList_SelectedIndexChanged(object sender, EventArgs arg)
        {
            if (this.listBoxRectangleList.SelectedIndex == -1)
            {
                return;
            }

            _currentRectangleCanva = _rectangleList[this.listBoxRectangleList.SelectedIndex];

            this.textBoxSelectedRectangleId.Text = _currentRectangleCanva.Id.ToString();
            this.textBoxSelectedRectangleHeight.Text = _currentRectangleCanva.GetHeight().ToString();
            this.textBoxSelectedRectangleWidth.Text = _currentRectangleCanva.GetWidth().ToString();
            this.textBoxSelectedRectangleX.Text = _currentRectangleCanva.GetCenter().X.ToString();
            this.textBoxSelectedRectangleY.Text = _currentRectangleCanva.GetCenter().Y.ToString();
        }

        public  void TextBoxSelectedRectangleHeight_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxSelectedRectangleHeight.BackColor = SystemColors.Window;

            if (this.listBoxRectangleList.SelectedIndex == -1)
            {
                MessageBox.Show("Select element from ListBox before.");
                this.textBoxSelectedRectangleHeight.Clear();

                return;
            }

            if (this.textBoxSelectedRectangleHeight.Text == "")
            {
                return;
            }

            try
            {
                double value = double.Parse(this.textBoxSelectedRectangleHeight.Text);

                _currentRectangleCanva.SetHeight(value);
                this.listBoxRectangleList.Items[this.listBoxRectangleList.SelectedIndex] = $"{_currentRectangleCanva.Id} (X={_currentRectangleCanva.GetCenter().X}, Y={_currentRectangleCanva.GetCenter().Y}), W={_currentRectangleCanva.GetWidth()}, H={_currentRectangleCanva.GetHeight()}";
            }
            catch
            {
                this.textBoxSelectedRectangleHeight.BackColor = Color.LightPink;
            }
        }

        public void TextBoxSelectedRectangleWidth_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxSelectedRectangleWidth.BackColor = SystemColors.Window;

            if (this.listBoxRectangleList.SelectedIndex == -1)
            {
                MessageBox.Show("Select element from ListBox before.");
                this.textBoxSelectedRectangleWidth.Clear();

                return;
            }

            if (this.textBoxSelectedRectangleWidth.Text == "")
            {
                return;
            }

            try
            {
                double value = double.Parse(this.textBoxSelectedRectangleWidth.Text);

                _currentRectangleCanva.SetWidth(value);
                this.listBoxRectangleList.Items[this.listBoxRectangleList.SelectedIndex] = $"{_currentRectangleCanva.Id} (X={_currentRectangleCanva.GetCenter().X}, Y={_currentRectangleCanva.GetCenter().Y}), W={_currentRectangleCanva.GetWidth()}, H={_currentRectangleCanva.GetHeight()}";
            }
            catch
            {
                this.textBoxSelectedRectangleWidth.BackColor = Color.LightPink;
            }
        }

        public void TextBoxSelectedRectangleX_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxSelectedRectangleX.BackColor = SystemColors.Window;

            if (this.listBoxRectangleList.SelectedIndex == -1)
            {
                MessageBox.Show("Select element from ListBox before.");
                this.textBoxSelectedRectangleX.Clear();

                return;
            }

            if (this.textBoxSelectedRectangleX.Text == "")
            {
                return;
            }

            try
            {
                int value = Int32.Parse(this.textBoxSelectedRectangleX.Text);

                _currentRectangleCanva.SetCenter(new Model.Point2D(value, _currentRectangleCanva.GetCenter().Y));
                this.listBoxRectangleList.Items[this.listBoxRectangleList.SelectedIndex] = $"{_currentRectangleCanva.Id} (X={_currentRectangleCanva.GetCenter().X}, Y={_currentRectangleCanva.GetCenter().Y}), W={_currentRectangleCanva.GetWidth()}, H={_currentRectangleCanva.GetHeight()}";
            }
            catch
            {
                this.textBoxSelectedRectangleX.BackColor = Color.LightPink;
            }
        }

        public void TextBoxSelectedRectangleY_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxSelectedRectangleY.BackColor = SystemColors.Window;

            if (this.listBoxRectangleList.SelectedIndex == -1)
            {
                MessageBox.Show("Select element from ListBox before.");
                this.textBoxSelectedRectangleY.Clear();

                return;
            }

            if (this.textBoxSelectedRectangleY.Text == "")
            {
                return;
            }

            try
            {
                int value = Int32.Parse(this.textBoxSelectedRectangleY.Text);

                _currentRectangleCanva.SetCenter(new Model.Point2D(_currentRectangleCanva.GetCenter().X, value));
                this.listBoxRectangleList.Items[this.listBoxRectangleList.SelectedIndex] = $"{_currentRectangleCanva.Id} (X={_currentRectangleCanva.GetCenter().X}, Y={_currentRectangleCanva.GetCenter().Y}, W={_currentRectangleCanva.GetWidth()}, H={_currentRectangleCanva.GetHeight()}";
            }
            catch
            {
                this.textBoxSelectedRectangleY.BackColor = Color.LightPink;
            }
        }

        private void AddRectangleToListBox(Model.Rectangle r)
        {
            this.listBoxRectangleList.Items.Add($"{r.Id} (X={r.GetCenter().X}, Y={r.GetCenter().Y}, W={r.GetWidth()}, H={r.GetHeight()}");
        }

        private void RemoveRectangleFromListBox(int index)
        {
            this.listBoxRectangleList.Items.RemoveAt(index);
        }
    }
}