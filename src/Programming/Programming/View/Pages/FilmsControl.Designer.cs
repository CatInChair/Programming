namespace Programming.View.Pages
{
    partial class FilmsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxFilms = new System.Windows.Forms.GroupBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonFilm = new System.Windows.Forms.Button();
            this.textBoxReleaseYear = new System.Windows.Forms.TextBox();
            this.labelreleaseYear = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxFilms = new System.Windows.Forms.ListBox();
            this.groupBoxFilms.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFilms
            // 
            this.groupBoxFilms.Controls.Add(this.textBoxRating);
            this.groupBoxFilms.Controls.Add(this.labelRating);
            this.groupBoxFilms.Controls.Add(this.textBoxGenre);
            this.groupBoxFilms.Controls.Add(this.labelGenre);
            this.groupBoxFilms.Controls.Add(this.buttonFilm);
            this.groupBoxFilms.Controls.Add(this.textBoxReleaseYear);
            this.groupBoxFilms.Controls.Add(this.labelreleaseYear);
            this.groupBoxFilms.Controls.Add(this.textBoxDuration);
            this.groupBoxFilms.Controls.Add(this.labelDuration);
            this.groupBoxFilms.Controls.Add(this.textBoxName);
            this.groupBoxFilms.Controls.Add(this.labelName);
            this.groupBoxFilms.Controls.Add(this.listBoxFilms);
            this.groupBoxFilms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFilms.Location = new System.Drawing.Point(0, 0);
            this.groupBoxFilms.Name = "groupBoxFilms";
            this.groupBoxFilms.Size = new System.Drawing.Size(333, 335);
            this.groupBoxFilms.TabIndex = 3;
            this.groupBoxFilms.TabStop = false;
            this.groupBoxFilms.Text = "Films";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(203, 204);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(119, 20);
            this.textBoxRating.TabIndex = 14;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(200, 188);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(41, 13);
            this.labelRating.TabIndex = 13;
            this.labelRating.Text = "Rating:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(203, 165);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(119, 20);
            this.textBoxGenre.TabIndex = 12;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(200, 149);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 11;
            this.labelGenre.Text = "Genre:";
            // 
            // buttonFilm
            // 
            this.buttonFilm.Location = new System.Drawing.Point(225, 273);
            this.buttonFilm.Name = "buttonFilm";
            this.buttonFilm.Size = new System.Drawing.Size(75, 23);
            this.buttonFilm.TabIndex = 10;
            this.buttonFilm.Text = "Find";
            this.buttonFilm.UseVisualStyleBackColor = true;
            // 
            // textBoxReleaseYear
            // 
            this.textBoxReleaseYear.Location = new System.Drawing.Point(203, 126);
            this.textBoxReleaseYear.Name = "textBoxReleaseYear";
            this.textBoxReleaseYear.Size = new System.Drawing.Size(119, 20);
            this.textBoxReleaseYear.TabIndex = 9;
            // 
            // labelreleaseYear
            // 
            this.labelreleaseYear.AutoSize = true;
            this.labelreleaseYear.Location = new System.Drawing.Point(200, 110);
            this.labelreleaseYear.Name = "labelreleaseYear";
            this.labelreleaseYear.Size = new System.Drawing.Size(72, 13);
            this.labelreleaseYear.TabIndex = 8;
            this.labelreleaseYear.Text = "Release year:";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(203, 87);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(119, 20);
            this.textBoxDuration.TabIndex = 7;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(200, 71);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 6;
            this.labelDuration.Text = "Duration:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(203, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(119, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(200, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // listBoxFilms
            // 
            this.listBoxFilms.FormattingEnabled = true;
            this.listBoxFilms.Location = new System.Drawing.Point(9, 32);
            this.listBoxFilms.Name = "listBoxFilms";
            this.listBoxFilms.Size = new System.Drawing.Size(176, 264);
            this.listBoxFilms.TabIndex = 1;
            // 
            // FilmsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBoxFilms);
            this.Name = "FilmsControl";
            this.Size = new System.Drawing.Size(333, 335);
            this.groupBoxFilms.ResumeLayout(false);
            this.groupBoxFilms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void InitializeListeners()
        {
            this.buttonFilm.Click += ButtonFilm_Click;

            this.listBoxFilms.SelectedIndexChanged += ListBoxFilms_SelectedIndexChanged;

            this.textBoxDuration.TextChanged += TextBoxDuration_TextChanged;
            this.textBoxGenre.TextChanged += TextBoxGenre_TextChanged;
            this.textBoxName.TextChanged += TextBoxName_TextChanged;
            this.textBoxRating.TextChanged += TextBoxRating_TextChanged;
            this.textBoxReleaseYear.TextChanged += TextBoxReleaseYear_TextChanged;
        }

        private System.Windows.Forms.GroupBox groupBoxFilms;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Button buttonFilm;
        private System.Windows.Forms.TextBox textBoxReleaseYear;
        private System.Windows.Forms.Label labelreleaseYear;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxFilms;
    }
}
