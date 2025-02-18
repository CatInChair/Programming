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

namespace Programming.View.Pages
{
    public partial class RectangleCollisionControl : UserControl
    {
        private Model.Rectangle _currentRectangle;
        private List<Model.Rectangle> _rectangles = new List<Model.Rectangle> { };
        private List<Panel> _rectanglePanels = new List<Panel> { };

        public RectangleCollisionControl()
        {
            InitializeComponent();
            InitializeListeners();
        }

        public void ButtonAdd_Click(object sender, EventArgs arg)
        {
            Random random = new Random();
            Panel panel = new Panel();
            Model.Rectangle rectangle = Model.RectangleFactory.Randomize();

            panel.Width = (int)rectangle.GetWidth();
            panel.Height = (int)rectangle.GetHeight();
            panel.Location = new Point(rectangle.GetCenter().X - (int)(rectangle.GetWidth() / 2), rectangle.GetCenter().Y - (int)(rectangle.GetHeight() / 2));
            panel.BackColor = AppColors.OkColor;

            _rectanglePanels.Add(panel);
            _rectangles.Add(rectangle);

            this.panelRectangles.Controls.Add(panel);
            AddRectangleToListBox(rectangle);

            FindCollisions();
        }

        public void ButtonRemove_Click(object sender, EventArgs arg)
        {
            if (this.listBoxRectangles.SelectedIndex != -1)
            {
                _currentRectangle = null;
                _rectangles.RemoveAt(this.listBoxRectangles.SelectedIndex);
                _rectanglePanels.RemoveAt(this.listBoxRectangles.SelectedIndex);

                ClearRectangleInfo();

                this.panelRectangles.Controls.RemoveAt(this.listBoxRectangles.SelectedIndex);
                RemoveRectangleFromListBox(this.listBoxRectangles.SelectedIndex);
                FindCollisions();
            }
            else
            {
                MessageBox.Show("You need to select element from ListBox before.");
            }
        }

        public void ListBoxRectangleList_SelectedIndexChanged(object sender, EventArgs arg)
        {
            if (this.listBoxRectangles.SelectedIndex == -1)
            {
                return;
            }

            _currentRectangle = _rectangles[this.listBoxRectangles.SelectedIndex];

            FindCollisions();
            UpdateRectangleInfo(_currentRectangle);
        }

        public void TextBoxSelectedRectangleHeight_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxHeight.BackColor = SystemColors.Window;

            if (this.listBoxRectangles.SelectedIndex == -1)
            {
                MessageBox.Show("Select element from ListBox before.");
                this.textBoxHeight.Clear();

                return;
            }

            if (this.textBoxHeight.Text == "")
            {
                return;
            }

            try
            {
                double value = double.Parse(this.textBoxHeight.Text);

                _currentRectangle.SetHeight(value);
                this.listBoxRectangles.Items[this.listBoxRectangles.SelectedIndex] = $"{_currentRectangle.Id} (X={_currentRectangle.GetCenter().X}, Y={_currentRectangle.GetCenter().Y}), W={_currentRectangle.GetWidth()}, H={_currentRectangle.GetHeight()}";
                RedrawRectangle();
            }
            catch
            {
                this.textBoxHeight.BackColor = AppColors.ErrorColor;
            }
        }

        public void TextBoxSelectedRectangleWidth_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxWidth.BackColor = SystemColors.Window;

            if (this.listBoxRectangles.SelectedIndex == -1)
            {
                MessageBox.Show("Select element from ListBox before.");
                this.textBoxWidth.Clear();

                return;
            }

            if (this.textBoxWidth.Text == "")
            {
                return;
            }

            try
            {
                double value = double.Parse(this.textBoxWidth.Text);

                _currentRectangle.SetWidth(value);
                this.listBoxRectangles.Items[this.listBoxRectangles.SelectedIndex] = $"{_currentRectangle.Id} (X={_currentRectangle.GetCenter().X}, Y={_currentRectangle.GetCenter().Y}), W={_currentRectangle.GetWidth()}, H={_currentRectangle.GetHeight()}";
                RedrawRectangle();
            }
            catch
            {
                this.textBoxWidth.BackColor = AppColors.ErrorColor;
            }
        }

        public void TextBoxSelectedRectangleX_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxX.BackColor = SystemColors.Window;

            if (this.listBoxRectangles.SelectedIndex == -1)
            {
                MessageBox.Show("Select element from ListBox before.");
                this.textBoxX.Clear();

                return;
            }

            if (this.textBoxX.Text == "")
            {
                return;
            }

            try
            {
                int value = Int32.Parse(this.textBoxX.Text);

                _currentRectangle.SetCenter(new Model.Point2D(value, _currentRectangle.GetCenter().Y));
                this.listBoxRectangles.Items[this.listBoxRectangles.SelectedIndex] = $"{_currentRectangle.Id} (X={_currentRectangle.GetCenter().X}, Y={_currentRectangle.GetCenter().Y}), W={_currentRectangle.GetWidth()}, H={_currentRectangle.GetHeight()}";
                RedrawRectangle();
            }
            catch
            {
                this.textBoxX.BackColor = AppColors.ErrorColor;
            }
        }

        public void TextBoxSelectedRectangleY_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxY.BackColor = SystemColors.Window;

            if (this.listBoxRectangles.SelectedIndex == -1)
            {
                MessageBox.Show("Select element from ListBox before.");
                this.textBoxY.Clear();

                return;
            }

            if (this.textBoxY.Text == "")
            {
                return;
            }

            try
            {
                int value = Int32.Parse(this.textBoxY.Text);

                _currentRectangle.SetCenter(new Model.Point2D(_currentRectangle.GetCenter().X, value));
                this.listBoxRectangles.Items[this.listBoxRectangles.SelectedIndex] = $"{_currentRectangle.Id} (X={_currentRectangle.GetCenter().X}, Y={_currentRectangle.GetCenter().Y}, W={_currentRectangle.GetWidth()}, H={_currentRectangle.GetHeight()}";
                RedrawRectangle();
            }
            catch
            {
                this.textBoxY.BackColor = AppColors.ErrorColor;
            }
        }

        private void AddRectangleToListBox(Model.Rectangle r)
        {
            this.listBoxRectangles.Items.Add($"{r.Id} (X={r.GetCenter().X}, Y={r.GetCenter().Y}, W={r.GetWidth()}, H={r.GetHeight()}");
        }

        private void RemoveRectangleFromListBox(int index)
        {
            this.listBoxRectangles.Items.RemoveAt(index);
        }

        private void FindCollisions()
        {
            foreach (Panel panel in this.panelRectangles.Controls)
            {
                panel.BackColor = AppColors.OkColor;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    Console.WriteLine(Model.CollisionManager.IsCollision(_rectangles[i], _rectangles[j]));

                    if (Model.CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        this.panelRectangles.Controls[i].BackColor = AppColors.CollisionColor;
                        this.panelRectangles.Controls[j].BackColor = AppColors.CollisionColor;
                    }
                }
            }

            HighlightSelectedRectangle();
        }

        private void HighlightSelectedRectangle()
        {
            if (this.listBoxRectangles.SelectedIndex == -1)
            {
                return;
            }

            this.panelRectangles.Controls[this.listBoxRectangles.SelectedIndex].BackColor = AppColors.HighlightColor;
        }

        private void RedrawRectangle()
        {
            Panel panel = (Panel)this.panelRectangles.Controls[this.listBoxRectangles.SelectedIndex];

            panel.Width = (int)_currentRectangle.GetWidth();
            panel.Height = (int)_currentRectangle.GetHeight();
            panel.Location = new Point(_currentRectangle.GetCenter().X - (int)(_currentRectangle.GetWidth() / 2), _currentRectangle.GetCenter().Y - (int)(_currentRectangle.GetHeight() / 2));
            panel.BackColor = AppColors.OkColor;

            _rectanglePanels[this.listBoxRectangles.SelectedIndex] = panel;
            FindCollisions();
        }

        private void ClearRectangleInfo()
        {
            this.textBoxX.Clear();
            this.textBoxY.Clear();
            this.textBoxWidth.Clear();
            this.textBoxHeight.Clear();
            this.textBoxId.Clear();
        }

        private void UpdateRectangleInfo(Model.Rectangle r)
        {
            this.textBoxId.Text = r.Id.ToString();
            this.textBoxHeight.Text = r.GetHeight().ToString();
            this.textBoxWidth.Text = r.GetWidth().ToString();
            this.textBoxX.Text = r.GetCenter().X.ToString();
            this.textBoxY.Text = r.GetCenter().Y.ToString();
        }
    }
}
