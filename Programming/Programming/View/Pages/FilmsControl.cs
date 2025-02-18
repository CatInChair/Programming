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
    public partial class FilmsControl : UserControl
    {
        private Model.Film[] _films;
        private Model.Film _currentFilm;

        public FilmsControl()
        {
            InitializeComponent();
            InitializeListeners();

            Random random = new Random();

            _films = new Model.Film[5];

            for (int i = 0; i < 5; i++)
            {
                _films[i] = new Model.Film("Blessing", random.Next(100, 250), random.Next(1990, 2026), "Horror", random.NextDouble() * 10);
            }

            for (int i = 0; i < _films.Length; i++)
            {
                this.listBoxFilms.Items.Add(_films[i].GetName());
            }

            this.listBoxFilms.SelectedIndex = 0;
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

        public void TextBoxReleaseYear_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxReleaseYear.BackColor = SystemColors.Window;

            try
            {
                _currentFilm.SetReleaseYear(Int32.Parse(this.textBoxReleaseYear.Text));
            }
            catch
            {
                this.textBoxReleaseYear.BackColor = AppColors.ErrorColor;
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
                this.textBoxDuration.BackColor = AppColors.ErrorColor;
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
                this.textBoxRating.BackColor = AppColors.ErrorColor;
            }
        }

        public void TextBoxName_TextChanged(object sender, EventArgs arg)
        {
            _currentFilm.SetName(this.textBoxName.Text);
        }

        public void TextBoxGenre_TextChanged(object sender, EventArgs arg)
        {
            _currentFilm.SetGenre(this.textBoxGenre.Text);
        }

        public void ButtonFilm_Click(object sender, EventArgs arg)
        {
            this.listBoxFilms.SelectedIndex = FindFilmWithMaxRating(_films);
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
    }
}
