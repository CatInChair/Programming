using Programming.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

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
                this.listBoxFilms.Items.Add(_films[i].Name);
            }

            this.listBoxFilms.SelectedIndex = 0;
        }

        public void ListBoxFilms_SelectedIndexChanged(object sender, EventArgs arg)
        {
            _currentFilm = _films[this.listBoxFilms.SelectedIndex];

            this.textBoxName.Text = _currentFilm.Name;
            this.textBoxDuration.Text = _currentFilm.Duration.ToString();
            this.textBoxGenre.Text = _currentFilm.Genre;
            this.textBoxReleaseYear.Text = _currentFilm.ReleaseYear.ToString();
            this.textBoxRating.Text = _currentFilm.Rating.ToString();
        }

        public void TextBoxReleaseYear_TextChanged(object sender, EventArgs arg)
        {
            this.textBoxReleaseYear.BackColor = SystemColors.Window;

            try
            {
                _currentFilm.ReleaseYear = Int32.Parse(this.textBoxReleaseYear.Text);
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
                _currentFilm.Duration = Int32.Parse(this.textBoxDuration.Text);
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
                _currentFilm.Rating = Double.Parse(this.textBoxRating.Text);
            }
            catch
            {
                this.textBoxRating.BackColor = AppColors.ErrorColor;
            }
        }

        public void TextBoxName_TextChanged(object sender, EventArgs arg)
        {
            _currentFilm.Name = this.textBoxName.Text;
        }

        public void TextBoxGenre_TextChanged(object sender, EventArgs arg)
        {
            _currentFilm.Genre = this.textBoxGenre.Text;
        }

        public void ButtonFilm_Click(object sender, EventArgs arg)
        {
            this.listBoxFilms.SelectedIndex = FindFilmWithMaxRating(_films);
        }

        /// <summary>
        /// Поиск экземпляра <see cref="Model.Film"/> с наивысшим рейтингом.
        /// </summary>
        /// <param name="films">Массив экземпляров <see cref="Model.Film"/>, по которому производится поиск.</param>
        /// <returns>Возвращает индекс в изначальном массиве экземпляра <see cref="Model.Film"/> с наивысшим рейтингом.</returns>
        private int FindFilmWithMaxRating(Model.Film[] films)
        {
            int maxIndex = 0;

            for (int i = 1; i < films.Length; i++)
            {
                if (films[i].Rating > films[maxIndex].Rating)
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
