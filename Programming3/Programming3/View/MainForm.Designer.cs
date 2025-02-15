namespace Programming3
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRectangles = new System.Windows.Forms.TabPage();
            this.groupBoxRectangles = new System.Windows.Forms.GroupBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRectangles = new System.Windows.Forms.ListBox();
            this.tabPageFilms = new System.Windows.Forms.TabPage();
            this.groupBoxFilms = new System.Windows.Forms.GroupBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.buttonFilm = new System.Windows.Forms.Button();
            this.textBoxReleaseYear = new System.Windows.Forms.TextBox();
            this.labelReleaseYear = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxFilms = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabPageRectangles.SuspendLayout();
            this.groupBoxRectangles.SuspendLayout();
            this.tabPageFilms.SuspendLayout();
            this.groupBoxFilms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRectangles);
            this.tabControl.Controls.Add(this.tabPageFilms);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(434, 288);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageRectangles
            // 
            this.tabPageRectangles.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageRectangles.Controls.Add(this.groupBoxRectangles);
            this.tabPageRectangles.Location = new System.Drawing.Point(4, 22);
            this.tabPageRectangles.Name = "tabPageRectangles";
            this.tabPageRectangles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRectangles.Size = new System.Drawing.Size(426, 262);
            this.tabPageRectangles.TabIndex = 1;
            this.tabPageRectangles.Text = "Classes";
            // 
            // groupBoxRectangles
            // 
            this.groupBoxRectangles.AutoSize = true;
            this.groupBoxRectangles.Controls.Add(this.buttonFind);
            this.groupBoxRectangles.Controls.Add(this.textBoxColor);
            this.groupBoxRectangles.Controls.Add(this.labelColor);
            this.groupBoxRectangles.Controls.Add(this.textBoxWidth);
            this.groupBoxRectangles.Controls.Add(this.labelWidth);
            this.groupBoxRectangles.Controls.Add(this.textBoxLength);
            this.groupBoxRectangles.Controls.Add(this.label1);
            this.groupBoxRectangles.Controls.Add(this.listBoxRectangles);
            this.groupBoxRectangles.Location = new System.Drawing.Point(16, 16);
            this.groupBoxRectangles.Name = "groupBoxRectangles";
            this.groupBoxRectangles.Size = new System.Drawing.Size(388, 237);
            this.groupBoxRectangles.TabIndex = 0;
            this.groupBoxRectangles.TabStop = false;
            this.groupBoxRectangles.Text = "Rectangles";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(244, 195);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += ButtonFind_Click;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(233, 114);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 6;
            this.textBoxColor.TextChanged += TextBoxColor_TextChanged;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(230, 98);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(34, 13);
            this.labelColor.TabIndex = 5;
            this.labelColor.Text = "Color:";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(233, 75);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 4;
            this.textBoxWidth.TextChanged += TextBoxWidth_TextChanged;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(230, 59);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(38, 13);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Width:";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(233, 36);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxLength.TabIndex = 2;
            this.textBoxLength.TextChanged += TextBoxLength_TextChanged;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Length:";
            // 
            // listBoxRectangles
            // 
            this.listBoxRectangles.FormattingEnabled = true;
            this.listBoxRectangles.Location = new System.Drawing.Point(6, 19);
            this.listBoxRectangles.Name = "listBoxRectangles";
            this.listBoxRectangles.Size = new System.Drawing.Size(192, 199);
            this.listBoxRectangles.TabIndex = 0;
            this.listBoxRectangles.SelectedIndexChanged += ListBoxRectangles_SelectedIndexChanged;
            // 
            // tabPageFilms
            // 
            this.tabPageFilms.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFilms.Controls.Add(this.groupBoxFilms);
            this.tabPageFilms.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilms.Name = "tabPageFilms";
            this.tabPageFilms.Size = new System.Drawing.Size(426, 262);
            this.tabPageFilms.TabIndex = 2;
            this.tabPageFilms.Text = "Films";
            // 
            // groupBoxFilms
            // 
            this.groupBoxFilms.AutoSize = true;
            this.groupBoxFilms.Controls.Add(this.textBoxRating);
            this.groupBoxFilms.Controls.Add(this.labelRating);
            this.groupBoxFilms.Controls.Add(this.textBoxGenre);
            this.groupBoxFilms.Controls.Add(this.labelGenre);
            this.groupBoxFilms.Controls.Add(this.buttonFilm);
            this.groupBoxFilms.Controls.Add(this.textBoxReleaseYear);
            this.groupBoxFilms.Controls.Add(this.labelReleaseYear);
            this.groupBoxFilms.Controls.Add(this.textBoxDuration);
            this.groupBoxFilms.Controls.Add(this.labelDuration);
            this.groupBoxFilms.Controls.Add(this.textBoxName);
            this.groupBoxFilms.Controls.Add(this.labelName);
            this.groupBoxFilms.Controls.Add(this.listBoxFilms);
            this.groupBoxFilms.Location = new System.Drawing.Point(19, 2);
            this.groupBoxFilms.Name = "groupBoxFilms";
            this.groupBoxFilms.Size = new System.Drawing.Size(388, 259);
            this.groupBoxFilms.TabIndex = 2;
            this.groupBoxFilms.TabStop = false;
            this.groupBoxFilms.Text = "Films";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(233, 188);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(100, 20);
            this.textBoxRating.TabIndex = 11;
            this.textBoxRating.TextChanged += TextBoxRating_TextChanged;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(230, 172);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(41, 13);
            this.labelRating.TabIndex = 10;
            this.labelRating.Text = "Rating:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(233, 149);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 9;
            this.textBoxGenre.TextChanged += TextBoxGenre_TextChanged;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(230, 133);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genre:";
            // 
            // buttonFilm
            // 
            this.buttonFilm.Location = new System.Drawing.Point(243, 217);
            this.buttonFilm.Name = "buttonFilm";
            this.buttonFilm.Size = new System.Drawing.Size(75, 23);
            this.buttonFilm.TabIndex = 7;
            this.buttonFilm.Text = "Find";
            this.buttonFilm.UseVisualStyleBackColor = true;
            this.buttonFilm.Click += ButtonFilm_Click;
            // 
            // textBoxReleaseYear
            // 
            this.textBoxReleaseYear.Location = new System.Drawing.Point(233, 110);
            this.textBoxReleaseYear.Name = "textBoxReleaseYear";
            this.textBoxReleaseYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxReleaseYear.TabIndex = 6;
            this.textBoxReleaseYear.TextChanged += TextBoxReleaseYear_TextChanged;
            // 
            // labelReleaseYear
            // 
            this.labelReleaseYear.AutoSize = true;
            this.labelReleaseYear.Location = new System.Drawing.Point(230, 94);
            this.labelReleaseYear.Name = "labelReleaseYear";
            this.labelReleaseYear.Size = new System.Drawing.Size(72, 13);
            this.labelReleaseYear.TabIndex = 5;
            this.labelReleaseYear.Text = "Release year:";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(233, 71);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuration.TabIndex = 4;
            this.textBoxDuration.TextChanged += TextBoxDuration_TextChanged;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(230, 55);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 3;
            this.labelDuration.Text = "Duration:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(233, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += TextBoxName_TextChanged;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(230, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // listBoxFilms
            // 
            this.listBoxFilms.FormattingEnabled = true;
            this.listBoxFilms.Location = new System.Drawing.Point(6, 19);
            this.listBoxFilms.Name = "listBoxFilms";
            this.listBoxFilms.Size = new System.Drawing.Size(192, 199);
            this.listBoxFilms.TabIndex = 0;
            this.listBoxFilms.SelectedIndexChanged += ListBoxFilms_SelectedIndexChanged;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 312);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPageRectangles.ResumeLayout(false);
            this.tabPageRectangles.PerformLayout();
            this.groupBoxRectangles.ResumeLayout(false);
            this.groupBoxRectangles.PerformLayout();
            this.tabPageFilms.ResumeLayout(false);
            this.tabPageFilms.PerformLayout();
            this.groupBoxFilms.ResumeLayout(false);
            this.groupBoxFilms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageRectangles;
        private System.Windows.Forms.GroupBox groupBoxRectangles;
        private System.Windows.Forms.ListBox listBoxRectangles;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TabPage tabPageFilms;
        private System.Windows.Forms.GroupBox groupBoxFilms;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Button buttonFilm;
        private System.Windows.Forms.TextBox textBoxReleaseYear;
        private System.Windows.Forms.Label labelReleaseYear;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxFilms;
    }
}

