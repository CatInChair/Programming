using Programming.Model;
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
using Color = System.Drawing.Color;

namespace Programming
{ 
    public partial class MainForm
    {
        private Model.Rectangle _currentRectangleCanva;
        private List<Model.Rectangle> _rectangleList = new List<Model.Rectangle> { };
        private List<Panel> _rectanglePanels = new List<Panel> { };

        public void ButtonRectangleAdd_Click(object sender, EventArgs arg)
        {
            Random random = new Random();
            Panel panel = new Panel();
            Model.Rectangle rectangle = Model.RectangleFactory.Randomize();

            panel.Width = (int)rectangle.GetWidth();
            panel.Height = (int)rectangle.GetHeight();
            panel.Location = new Point(rectangle.GetCenter().X - (int)(rectangle.GetWidth()/2), rectangle.GetCenter().Y - (int)(rectangle.GetHeight()/2));
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);

            _rectanglePanels.Add(panel);
            _rectangleList.Add(rectangle);

            this.panelRectangles.Controls.Add(panel);
            AddRectangleToListBox(rectangle);

            FindCollisions();
        }

        public void ButtonRectangleRemove_Click(object sender, EventArgs arg)
        {
            if (this.listBoxRectangleList.SelectedIndex != -1)
            {
                _currentRectangle = null;
                _rectangleList.RemoveAt(this.listBoxRectangleList.SelectedIndex);
                _rectanglePanels.RemoveAt(this.listBoxRectangleList.SelectedIndex);

                ClearRectangleInfo();

                this.panelRectangles.Controls.RemoveAt(this.listBoxRectangleList.SelectedIndex);
                RemoveRectangleFromListBox(this.listBoxRectangleList.SelectedIndex);
                FindCollisions();
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

            FindCollisions();
            UpdateRectangleInfo(_currentRectangleCanva);
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
                RedrawRectangle();
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
                RedrawRectangle();
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
                RedrawRectangle();
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
                RedrawRectangle();
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

        private void FindCollisions()
        {
            foreach (Panel panel in this.panelRectangles.Controls)
            {
                panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectangleList.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangleList.Count; j++)
                {
                    Console.WriteLine(Model.CollisionManager.IsCollision(_rectangleList[i], _rectangleList[j]));

                    if (Model.CollisionManager.IsCollision(_rectangleList[i], _rectangleList[j]))
                    {
                        this.panelRectangles.Controls[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        this.panelRectangles.Controls[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }

            HighlightSelectedRectangle();
        }

        private void HighlightSelectedRectangle()
        {
            if (this.listBoxRectangleList.SelectedIndex == -1)
            {
                return;
            }

            this.panelRectangles.Controls[this.listBoxRectangleList.SelectedIndex].BackColor = Color.LightGoldenrodYellow;
        }

        private void RedrawRectangle()
        {
            Panel panel = (Panel)this.panelRectangles.Controls[this.listBoxRectangleList.SelectedIndex];

            panel.Width = (int)_currentRectangleCanva.GetWidth();
            panel.Height = (int)_currentRectangleCanva.GetHeight();
            panel.Location = new Point(_currentRectangleCanva.GetCenter().X - (int)(_currentRectangleCanva.GetWidth() / 2), _currentRectangleCanva.GetCenter().Y - (int)(_currentRectangleCanva.GetHeight() / 2));
            panel.BackColor = Color.FromArgb(127, 127, 255, 127);

            _rectanglePanels[this.listBoxRectangleList.SelectedIndex] = panel;
            FindCollisions();
        }

        private void ClearRectangleInfo()
        {
            this.textBoxSelectedRectangleX.Clear();
            this.textBoxCenterY.Clear();
            this.textBoxSelectedRectangleY.Clear();
            this.textBoxSelectedRectangleWidth.Clear();
            this.textBoxSelectedRectangleHeight.Clear();
            this.textBoxSelectedRectangleId.Clear();
        }

        private void UpdateRectangleInfo(Model.Rectangle r) 
        {
            this.textBoxSelectedRectangleId.Text = r.Id.ToString();
            this.textBoxSelectedRectangleHeight.Text = r.GetHeight().ToString();
            this.textBoxSelectedRectangleWidth.Text = r.GetWidth().ToString();
            this.textBoxSelectedRectangleX.Text = r.GetCenter().X.ToString();
            this.textBoxSelectedRectangleY.Text = r.GetCenter().Y.ToString();
        }
    }
}