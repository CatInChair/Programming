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
    public partial class ClassesControl : UserControl
    {
        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;


        public ClassesControl()
        {
            InitializeComponent();
            InitializeListeners();

            Random random = new Random();

            _rectangles = new Model.Rectangle[5];

            for (int i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Rectangle(random.Next(50, 100), random.Next(50, 100), new string[] { "Red", "Yellow", "Orange", "Blue" }[random.Next(0, 4)], new Model.Point2D(random.Next(0, 200), random.Next(0, 200)));
            }

            for (int i = 0; i < _rectangles.Length; i++)
            {
                this.listBoxRectangles.Items.Add($"Rectangle {i + 1}");
            }

            this.listBoxRectangles.SelectedIndex = 0;
        }

        public void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs arg)
        {
            _currentRectangle = _rectangles[this.listBoxRectangles.SelectedIndex];

            this.textBoxLength.Text = _currentRectangle.GetHeight().ToString();
            this.textBoxWidth.Text = _currentRectangle.GetWidth().ToString();
            this.textBoxColor.Text = _currentRectangle.GetColor();
            this.textBoxCenterX.Text = _currentRectangle.GetCenter().X.ToString();
            this.textBoxCenterY.Text = _currentRectangle.GetCenter().Y.ToString();
            this.textBoxId.Text = _currentRectangle.Id.ToString();
        }
        public void TextBoxLength_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxLength.BackColor = SystemColors.Window;

            try
            {
                _currentRectangle.SetHeight(Double.Parse(this.textBoxLength.Text));
            }
            catch
            {
                this.textBoxLength.BackColor = AppColors.ErrorColor;
            }
        }

        public void TextBoxWidth_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxWidth.BackColor = SystemColors.Window;

            try
            {
                _currentRectangle.SetWidth(Double.Parse(this.textBoxWidth.Text));
            }
            catch
            {
                this.textBoxWidth.BackColor = AppColors.ErrorColor;
            }
        }

        public void TextBoxColor_TextChanged(object sender, EventArgs arg)
        {
            _currentRectangle.SetColor(this.textBoxColor.Text);
        }
        public void ButtonFind_Click(object sender, EventArgs arg)
        {
            this.listBoxRectangles.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
        private int FindRectangleWithMaxWidth(Model.Rectangle[] rectangles)
        {
            int maxIndex = 0;

            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].GetWidth() > rectangles[maxIndex].GetWidth())
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
