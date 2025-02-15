using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming3
{
    public partial class MainForm : Form
    {
        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;
        private string[] _colors = new string[] { "Red", "Yellow", "Orange", "Blue" };

        public MainForm()
        {
            InitializeComponent();

            Random random = new Random();

            _rectangles = new Model.Rectangle[]
            {
                new Model.Rectangle(random.NextDouble() * 100, random.NextDouble() * 100, _colors[random.Next(0, 4)]),
                new Model.Rectangle(random.NextDouble() * 100, random.NextDouble() * 100, _colors[random.Next(0, 4)]),
                new Model.Rectangle(random.NextDouble() * 100, random.NextDouble() * 100, _colors[random.Next(0, 4)]),
                new Model.Rectangle(random.NextDouble() * 100, random.NextDouble() * 100, _colors[random.Next(0, 4)]),
                new Model.Rectangle(random.NextDouble() * 100, random.NextDouble() * 100, _colors[random.Next(0, 4)])
            };

            for (int i = 0; i < _rectangles.Length; i++) 
            { 
                this.listBoxRectangles.Items.Add($"Rectangle {i + 1}");
            }

            this.listBoxRectangles.SelectedIndex = 0;
        }

        public void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs arg)
        {
            _currentRectangle = _rectangles[this.listBoxRectangles.SelectedIndex];

            this.textBoxLength.Text = _currentRectangle.GetLength().ToString();
            this.textBoxWidth.Text = _currentRectangle.GetWidth().ToString();
            this.textBoxColor.Text = _currentRectangle.GetColor();
        }

        public void TextBoxLength_TextChanged(object sender, EventArgs arg)
        {

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
                this.textBoxWidth.BackColor = Color.LightPink;
            }
        }

        public void TextBoxColor_TextChanged(object sender, EventArgs arg)
        {
            _currentRectangle.SetColor(this.textBoxColor.Text);
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

        public void buttonFind_Click(object sender, EventArgs arg)
        {
            this.listBoxRectangles.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
