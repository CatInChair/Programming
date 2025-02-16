using System.Windows.Forms;

namespace Programming
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
            this.tabPageEnums = new System.Windows.Forms.TabPage();
            this.groupBoxSeason = new System.Windows.Forms.GroupBox();
            this.buttonSeason = new System.Windows.Forms.Button();
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            this.labelSeason = new System.Windows.Forms.Label();
            this.groupBoxWeekday = new System.Windows.Forms.GroupBox();
            this.labelParseOutput = new System.Windows.Forms.Label();
            this.buttonParse = new System.Windows.Forms.Button();
            this.textBoxParse = new System.Windows.Forms.TextBox();
            this.labelParse = new System.Windows.Forms.Label();
            this.groupBoxEnums = new System.Windows.Forms.GroupBox();
            this.textBoxIntValue = new System.Windows.Forms.TextBox();
            this.labelIntValue = new System.Windows.Forms.Label();
            this.listBoxEnumsValues = new System.Windows.Forms.ListBox();
            this.labelEnumsValue = new System.Windows.Forms.Label();
            this.listBoxEnums = new System.Windows.Forms.ListBox();
            this.labelEnums = new System.Windows.Forms.Label();
            this.tabPageRectangles = new System.Windows.Forms.TabPage();
            this.groupBoxRectangles = new System.Windows.Forms.GroupBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.listBoxRectangles = new System.Windows.Forms.ListBox();
            this.tabPageFilms = new System.Windows.Forms.TabPage();
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
            this.tabControl.SuspendLayout();
            this.tabPageEnums.SuspendLayout();
            this.groupBoxSeason.SuspendLayout();
            this.groupBoxWeekday.SuspendLayout();
            this.groupBoxEnums.SuspendLayout();
            this.tabPageRectangles.SuspendLayout();
            this.groupBoxRectangles.SuspendLayout();
            this.tabPageFilms.SuspendLayout();
            this.groupBoxFilms.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEnums);
            this.tabControl.Controls.Add(this.tabPageRectangles);
            this.tabControl.Controls.Add(this.tabPageFilms);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(559, 536);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageEnums
            // 
            this.tabPageEnums.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageEnums.Controls.Add(this.groupBoxSeason);
            this.tabPageEnums.Controls.Add(this.groupBoxWeekday);
            this.tabPageEnums.Controls.Add(this.groupBoxEnums);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnums.Size = new System.Drawing.Size(551, 510);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            // 
            // groupBoxSeason
            // 
            this.groupBoxSeason.Controls.Add(this.buttonSeason);
            this.groupBoxSeason.Controls.Add(this.comboBoxSeason);
            this.groupBoxSeason.Controls.Add(this.labelSeason);
            this.groupBoxSeason.Location = new System.Drawing.Point(282, 343);
            this.groupBoxSeason.Name = "groupBoxSeason";
            this.groupBoxSeason.Size = new System.Drawing.Size(263, 161);
            this.groupBoxSeason.TabIndex = 2;
            this.groupBoxSeason.TabStop = false;
            this.groupBoxSeason.Text = "Season Handle";
            // 
            // buttonSeason
            // 
            this.buttonSeason.Location = new System.Drawing.Point(182, 33);
            this.buttonSeason.Name = "buttonSeason";
            this.buttonSeason.Size = new System.Drawing.Size(75, 23);
            this.buttonSeason.TabIndex = 8;
            this.buttonSeason.Text = "Go!";
            this.buttonSeason.UseVisualStyleBackColor = true;
            // 
            // comboBoxSeason
            // 
            this.comboBoxSeason.FormattingEnabled = true;
            this.comboBoxSeason.Location = new System.Drawing.Point(6, 35);
            this.comboBoxSeason.Name = "comboBoxSeason";
            this.comboBoxSeason.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSeason.TabIndex = 5;
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Location = new System.Drawing.Point(6, 19);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(83, 13);
            this.labelSeason.TabIndex = 4;
            this.labelSeason.Text = "Choose season:";
            // 
            // groupBoxWeekday
            // 
            this.groupBoxWeekday.Controls.Add(this.labelParseOutput);
            this.groupBoxWeekday.Controls.Add(this.buttonParse);
            this.groupBoxWeekday.Controls.Add(this.textBoxParse);
            this.groupBoxWeekday.Controls.Add(this.labelParse);
            this.groupBoxWeekday.Location = new System.Drawing.Point(6, 337);
            this.groupBoxWeekday.Name = "groupBoxWeekday";
            this.groupBoxWeekday.Size = new System.Drawing.Size(270, 167);
            this.groupBoxWeekday.TabIndex = 1;
            this.groupBoxWeekday.TabStop = false;
            this.groupBoxWeekday.Text = "Weekday Parsing";
            // 
            // labelParseOutput
            // 
            this.labelParseOutput.AutoSize = true;
            this.labelParseOutput.Location = new System.Drawing.Point(6, 93);
            this.labelParseOutput.Name = "labelParseOutput";
            this.labelParseOutput.Size = new System.Drawing.Size(156, 13);
            this.labelParseOutput.TabIndex = 8;
            this.labelParseOutput.Text = "Это день недели (Monday = 1)";
            // 
            // buttonParse
            // 
            this.buttonParse.Location = new System.Drawing.Point(189, 39);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(75, 23);
            this.buttonParse.TabIndex = 7;
            this.buttonParse.Text = "Parse";
            this.buttonParse.UseVisualStyleBackColor = true;
            // 
            // textBoxParse
            // 
            this.textBoxParse.Location = new System.Drawing.Point(6, 41);
            this.textBoxParse.Name = "textBoxParse";
            this.textBoxParse.Size = new System.Drawing.Size(177, 20);
            this.textBoxParse.TabIndex = 6;
            this.textBoxParse.Text = "Monday";
            // 
            // labelParse
            // 
            this.labelParse.AutoSize = true;
            this.labelParse.Location = new System.Drawing.Point(6, 25);
            this.labelParse.Name = "labelParse";
            this.labelParse.Size = new System.Drawing.Size(115, 13);
            this.labelParse.TabIndex = 3;
            this.labelParse.Text = "Type value for parsing:";
            // 
            // groupBoxEnums
            // 
            this.groupBoxEnums.Controls.Add(this.textBoxIntValue);
            this.groupBoxEnums.Controls.Add(this.labelIntValue);
            this.groupBoxEnums.Controls.Add(this.listBoxEnumsValues);
            this.groupBoxEnums.Controls.Add(this.labelEnumsValue);
            this.groupBoxEnums.Controls.Add(this.listBoxEnums);
            this.groupBoxEnums.Controls.Add(this.labelEnums);
            this.groupBoxEnums.Location = new System.Drawing.Point(6, 6);
            this.groupBoxEnums.Name = "groupBoxEnums";
            this.groupBoxEnums.Size = new System.Drawing.Size(539, 325);
            this.groupBoxEnums.TabIndex = 0;
            this.groupBoxEnums.TabStop = false;
            this.groupBoxEnums.Text = "Enumerations";
            // 
            // textBoxIntValue
            // 
            this.textBoxIntValue.Location = new System.Drawing.Point(323, 43);
            this.textBoxIntValue.Name = "textBoxIntValue";
            this.textBoxIntValue.Size = new System.Drawing.Size(119, 20);
            this.textBoxIntValue.TabIndex = 5;
            // 
            // labelIntValue
            // 
            this.labelIntValue.AutoSize = true;
            this.labelIntValue.Location = new System.Drawing.Point(320, 26);
            this.labelIntValue.Name = "labelIntValue";
            this.labelIntValue.Size = new System.Drawing.Size(51, 13);
            this.labelIntValue.TabIndex = 4;
            this.labelIntValue.Text = "Int value:";
            // 
            // listBoxEnumsValues
            // 
            this.listBoxEnumsValues.FormattingEnabled = true;
            this.listBoxEnumsValues.Location = new System.Drawing.Point(166, 43);
            this.listBoxEnumsValues.Name = "listBoxEnumsValues";
            this.listBoxEnumsValues.ScrollAlwaysVisible = true;
            this.listBoxEnumsValues.Size = new System.Drawing.Size(138, 264);
            this.listBoxEnumsValues.TabIndex = 3;
            // 
            // labelEnumsValue
            // 
            this.labelEnumsValue.AutoSize = true;
            this.labelEnumsValue.Location = new System.Drawing.Point(163, 26);
            this.labelEnumsValue.Name = "labelEnumsValue";
            this.labelEnumsValue.Size = new System.Drawing.Size(75, 13);
            this.labelEnumsValue.TabIndex = 2;
            this.labelEnumsValue.Text = "Choose value:";
            // 
            // listBoxEnums
            // 
            this.listBoxEnums.FormattingEnabled = true;
            this.listBoxEnums.Location = new System.Drawing.Point(9, 43);
            this.listBoxEnums.Name = "listBoxEnums";
            this.listBoxEnums.ScrollAlwaysVisible = true;
            this.listBoxEnums.Size = new System.Drawing.Size(138, 264);
            this.listBoxEnums.TabIndex = 1;
            // 
            // labelEnums
            // 
            this.labelEnums.AutoSize = true;
            this.labelEnums.Location = new System.Drawing.Point(6, 26);
            this.labelEnums.Name = "labelEnums";
            this.labelEnums.Size = new System.Drawing.Size(107, 13);
            this.labelEnums.TabIndex = 0;
            this.labelEnums.Text = "Choose enumeration:";
            // 
            // tabPageRectangles
            // 
            this.tabPageRectangles.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageRectangles.Controls.Add(this.groupBoxRectangles);
            this.tabPageRectangles.Location = new System.Drawing.Point(4, 22);
            this.tabPageRectangles.Name = "tabPageRectangles";
            this.tabPageRectangles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRectangles.Size = new System.Drawing.Size(551, 510);
            this.tabPageRectangles.TabIndex = 1;
            this.tabPageRectangles.Text = "Classes";
            // 
            // groupBoxRectangles
            // 
            this.groupBoxRectangles.Controls.Add(this.buttonFind);
            this.groupBoxRectangles.Controls.Add(this.textBoxColor);
            this.groupBoxRectangles.Controls.Add(this.labelColor);
            this.groupBoxRectangles.Controls.Add(this.textBoxWidth);
            this.groupBoxRectangles.Controls.Add(this.labelWidth);
            this.groupBoxRectangles.Controls.Add(this.textBoxLength);
            this.groupBoxRectangles.Controls.Add(this.labelLength);
            this.groupBoxRectangles.Controls.Add(this.listBoxRectangles);
            this.groupBoxRectangles.Location = new System.Drawing.Point(3, 6);
            this.groupBoxRectangles.Name = "groupBoxRectangles";
            this.groupBoxRectangles.Size = new System.Drawing.Size(539, 325);
            this.groupBoxRectangles.TabIndex = 1;
            this.groupBoxRectangles.TabStop = false;
            this.groupBoxRectangles.Text = "Rectangles";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(311, 267);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 10;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(289, 120);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(119, 20);
            this.textBoxColor.TabIndex = 9;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(286, 104);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(34, 13);
            this.labelColor.TabIndex = 8;
            this.labelColor.Text = "Color:";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(289, 81);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(119, 20);
            this.textBoxWidth.TabIndex = 7;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(286, 65);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(38, 13);
            this.labelWidth.TabIndex = 6;
            this.labelWidth.Text = "Width:";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(289, 42);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(119, 20);
            this.textBoxLength.TabIndex = 5;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(286, 26);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(43, 13);
            this.labelLength.TabIndex = 4;
            this.labelLength.Text = "Length:";
            // 
            // listBoxRectangles
            // 
            this.listBoxRectangles.FormattingEnabled = true;
            this.listBoxRectangles.Location = new System.Drawing.Point(95, 26);
            this.listBoxRectangles.Name = "listBoxRectangles";
            this.listBoxRectangles.Size = new System.Drawing.Size(176, 264);
            this.listBoxRectangles.TabIndex = 1;
            // 
            // tabPageFilms
            // 
            this.tabPageFilms.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageFilms.Controls.Add(this.groupBoxFilms);
            this.tabPageFilms.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilms.Name = "tabPageFilms";
            this.tabPageFilms.Size = new System.Drawing.Size(551, 510);
            this.tabPageFilms.TabIndex = 2;
            this.tabPageFilms.Text = "Films";
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
            this.groupBoxFilms.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFilms.Name = "groupBoxFilms";
            this.groupBoxFilms.Size = new System.Drawing.Size(539, 325);
            this.groupBoxFilms.TabIndex = 2;
            this.groupBoxFilms.TabStop = false;
            this.groupBoxFilms.Text = "Films";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(289, 198);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(119, 20);
            this.textBoxRating.TabIndex = 14;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(286, 182);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(41, 13);
            this.labelRating.TabIndex = 13;
            this.labelRating.Text = "Rating:";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(289, 159);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(119, 20);
            this.textBoxGenre.TabIndex = 12;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(286, 143);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 11;
            this.labelGenre.Text = "Genre:";
            // 
            // buttonFilm
            // 
            this.buttonFilm.Location = new System.Drawing.Point(311, 267);
            this.buttonFilm.Name = "buttonFilm";
            this.buttonFilm.Size = new System.Drawing.Size(75, 23);
            this.buttonFilm.TabIndex = 10;
            this.buttonFilm.Text = "Find";
            this.buttonFilm.UseVisualStyleBackColor = true;
            // 
            // textBoxReleaseYear
            // 
            this.textBoxReleaseYear.Location = new System.Drawing.Point(289, 120);
            this.textBoxReleaseYear.Name = "textBoxReleaseYear";
            this.textBoxReleaseYear.Size = new System.Drawing.Size(119, 20);
            this.textBoxReleaseYear.TabIndex = 9;
            // 
            // labelreleaseYear
            // 
            this.labelreleaseYear.AutoSize = true;
            this.labelreleaseYear.Location = new System.Drawing.Point(286, 104);
            this.labelreleaseYear.Name = "labelreleaseYear";
            this.labelreleaseYear.Size = new System.Drawing.Size(72, 13);
            this.labelreleaseYear.TabIndex = 8;
            this.labelreleaseYear.Text = "Release year:";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(289, 81);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(119, 20);
            this.textBoxDuration.TabIndex = 7;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(286, 65);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 6;
            this.labelDuration.Text = "Duration:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(289, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(119, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(286, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // listBoxFilms
            // 
            this.listBoxFilms.FormattingEnabled = true;
            this.listBoxFilms.Location = new System.Drawing.Point(95, 26);
            this.listBoxFilms.Name = "listBoxFilms";
            this.listBoxFilms.Size = new System.Drawing.Size(176, 264);
            this.listBoxFilms.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Programming";
            this.tabControl.ResumeLayout(false);
            this.tabPageEnums.ResumeLayout(false);
            this.groupBoxSeason.ResumeLayout(false);
            this.groupBoxSeason.PerformLayout();
            this.groupBoxWeekday.ResumeLayout(false);
            this.groupBoxWeekday.PerformLayout();
            this.groupBoxEnums.ResumeLayout(false);
            this.groupBoxEnums.PerformLayout();
            this.tabPageRectangles.ResumeLayout(false);
            this.groupBoxRectangles.ResumeLayout(false);
            this.groupBoxRectangles.PerformLayout();
            this.tabPageFilms.ResumeLayout(false);
            this.groupBoxFilms.ResumeLayout(false);
            this.groupBoxFilms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void InitializeListeners() 
        {
            this.buttonFilm.Click += ButtonFilm_Click;
            this.buttonFind.Click += ButtonFind_Click;
            this.buttonParse.Click += ButtonParse_Click;
            this.buttonSeason.Click += ButtonSeason_Click;
            
            this.listBoxEnums.SelectedIndexChanged += ListBoxEnums_SelectedIndexChanged;
            this.listBoxEnumsValues.SelectedIndexChanged += ListBoxEnumsValues_SelectedIndexChanged;
            this.listBoxFilms.SelectedIndexChanged += ListBoxFilms_SelectedIndexChanged;
            this.listBoxRectangles.SelectedIndexChanged += ListBoxRectangles_SelectedIndexChanged;

            this.textBoxColor.TextChanged += TextBoxColor_TextChanged;
            this.textBoxDuration.TextChanged += TextBoxDuration_TextChanged;
            this.textBoxGenre.TextChanged += TextBoxGenre_TextChanged;
            this.textBoxIntValue.TextChanged += TextBoxIntValue_TextChanged;
            this.textBoxLength.TextChanged += TextBoxLength_TextChanged;
            this.textBoxName.TextChanged += TextBoxName_TextChanged;
            this.textBoxRating.TextChanged += TextBoxRating_TextChanged;
            this.textBoxReleaseYear.TextChanged += TextBoxReleaseYear_TextChanged;
            this.textBoxWidth.TextChanged += TextBoxWidth_TextChanged;
        }

        private TabControl tabControl;
        private TabPage tabPageEnums;
        private TabPage tabPageRectangles;
        private GroupBox groupBoxEnums;
        private TabPage tabPageFilms;
        private GroupBox groupBoxSeason;
        private GroupBox groupBoxWeekday;
        private Label labelEnums;
        private ListBox listBoxEnumsValues;
        private Label labelEnumsValue;
        private ListBox listBoxEnums;
        private TextBox textBoxIntValue;
        private Label labelIntValue;
        private Label labelParse;
        private Label labelParseOutput;
        private Button buttonParse;
        private TextBox textBoxParse;
        private ComboBox comboBoxSeason;
        private Label labelSeason;
        private Button buttonSeason;
        private GroupBox groupBoxRectangles;
        private Button buttonFind;
        private TextBox textBoxColor;
        private Label labelColor;
        private TextBox textBoxWidth;
        private Label labelWidth;
        private TextBox textBoxLength;
        private Label labelLength;
        private ListBox listBoxRectangles;
        private GroupBox groupBoxFilms;
        private Button buttonFilm;
        private TextBox textBoxReleaseYear;
        private Label labelreleaseYear;
        private TextBox textBoxDuration;
        private Label labelDuration;
        private TextBox textBoxName;
        private Label labelName;
        private ListBox listBoxFilms;
        private Label labelGenre;
        private Label labelRating;
        private TextBox textBoxGenre;
        private TextBox textBoxRating;
    }
}

