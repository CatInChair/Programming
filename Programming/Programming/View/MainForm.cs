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
    public partial class MainForm : Form
    {
        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;
        private Model.Film[] _films;
        private Model.Film _currentFilm;

        Type[] Models = new Type[]
        {
            typeof(Model.Color),
            typeof(Model.EducationForm),
            typeof(Model.Genre),
            typeof(Model.Season),
            typeof(Model.SmartphoneManufactures),
            typeof(Model.Weekday)
        };

        public MainForm()
        {
            InitializeComponent();
            InitializeListeners();

            Random random = new Random();

            this.listBoxEnums.Items.AddRange(Models.Select(e => e.Name).ToArray());
            this.listBoxEnums.SelectedIndex = 0;

            this.comboBoxSeason.Items.AddRange(Enum.GetNames(Models[3]));

            _rectangles = new Model.Rectangle[]
            {
                Model.RectangleFactory.Randomize(),
                Model.RectangleFactory.Randomize(),
                Model.RectangleFactory.Randomize(),
                Model.RectangleFactory.Randomize(),
                Model.RectangleFactory.Randomize()
            };

            _films = new Model.Film[]
            {
                new Model.Film("Blessing", random.Next(100, 250), random.Next(1990, 2026), "Horror", random.NextDouble()*10),
                new Model.Film("The fog", random.Next(100, 250), random.Next(1990, 2026), "Horror", random.NextDouble()*10),
                new Model.Film("Jester", random.Next(100, 250), random.Next(1990, 2026), "Horror", random.NextDouble()*10),
                new Model.Film("Terrifier", random.Next(100, 250), random.Next(1990, 2026), "Horror", random.NextDouble()*10),
                new Model.Film("Blair Witch", random.Next(100, 250), random.Next(1990, 2026), "Horror", random.NextDouble()*10)
            };

            for (int i = 0; i < _rectangles.Length; i++)
            {
                this.listBoxRectangles.Items.Add($"Rectangle {i + 1}");
            }
            for (int i = 0; i < _films.Length; i++)
            {
                this.listBoxFilms.Items.Add(_films[i].GetName());
            }

            this.listBoxFilms.SelectedIndex = 0;
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

        public void ListBoxFilms_SelectedIndexChanged(object sender, EventArgs arg)
        {
            _currentFilm = _films[this.listBoxFilms.SelectedIndex];

            this.textBoxName.Text = _currentFilm.GetName();
            this.textBoxDuration.Text = _currentFilm.GetDuration().ToString();
            this.textBoxGenre.Text = _currentFilm.GetGenre();
            this.textBoxReleaseYear.Text = _currentFilm.GetReleaseYear().ToString();
            this.textBoxRating.Text = _currentFilm.GetRating().ToString();
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
                this.textBoxLength.BackColor = Color.LightPink;
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
                this.textBoxWidth.BackColor = Color.LightPink;
            }
        }

        public void TextBoxReleaseYear_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxReleaseYear.BackColor = SystemColors.Window;

            try
            {
                _currentFilm.SetReleaseYear(Int32.Parse(this.textBoxReleaseYear.Text));
            }
            catch
            {
                this.textBoxReleaseYear.BackColor = Color.LightPink;
            }
        }

        public void TextBoxDuration_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxDuration.BackColor = SystemColors.Window;

            try
            {
                _currentFilm.SetDuration(Int32.Parse(this.textBoxDuration.Text));
            }
            catch
            {
                this.textBoxDuration.BackColor = Color.LightPink;
            }
        }

        public void TextBoxRating_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxRating.BackColor = SystemColors.Window;

            try
            {
                _currentFilm.SetRating(Double.Parse(this.textBoxRating.Text));
            }
            catch
            {
                this.textBoxRating.BackColor = Color.LightPink;
            }
        }

        public void TextBoxColor_TextChanged(object sender, EventArgs arg)
        {
            _currentRectangle.SetColor(this.textBoxColor.Text);
        }

        public void TextBoxName_TextChanged(object sender, EventArgs arg)
        {
            _currentFilm.SetName(this.textBoxName.Text);
        }

        public void TextBoxGenre_TextChanged(object sender, EventArgs arg)
        {
            _currentFilm.SetGenre(this.textBoxGenre.Text);
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

        private int FindFilmWithMaxRating(Model.Film[] films)
        {
            int maxIndex = 0;

            for (int i = 1; i < films.Length; i++)
            {
                if (films[i].GetRating() > films[maxIndex].GetRating())
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        public void ButtonFind_Click(object sender, EventArgs arg)
        {
            this.listBoxRectangles.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        public void ButtonFilm_Click(object sender, EventArgs arg)
        {
            this.listBoxFilms.SelectedIndex = FindFilmWithMaxRating(_films);
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
            groupBoxSeason.BackColor = Color.Transparent;

            switch (comboBoxSeason.SelectedIndex) {
                case 0:     //Summer
                    MessageBox.Show("Ура! Солнце!");
                    return;

                case 1:     //Autumn
                    groupBoxSeason.BackColor = ColorTranslator.FromHtml("#e29c45");
                    return;

                case 2:     //Winter
                    MessageBox.Show("Брррр! Холодно!");
                    return;

                case 3:     //Spring
                    groupBoxSeason.BackColor = ColorTranslator.FromHtml("#559c45");
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

            if (!int.TryParse(this.textBoxIntValue.Text, out selectedIndex)) {
                MessageBox.Show("В поле \"Int value\" можно вводить лишь натуральные числа (включая ноль).");
                return;
            }

            this.listBoxEnumsValues.SelectedIndex = selectedIndex >= this.listBoxEnumsValues.Items.Count ? this.listBoxEnumsValues.Items.Count - 1 : selectedIndex;
        }
    }
}
