namespace Programming.View.Pages
{
    partial class EnumsControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxEnums = new System.Windows.Forms.GroupBox();
            this.textBoxIntValue = new System.Windows.Forms.TextBox();
            this.labelIntValue = new System.Windows.Forms.Label();
            this.listBoxEnumsValues = new System.Windows.Forms.ListBox();
            this.labelEnumsValue = new System.Windows.Forms.Label();
            this.listBoxEnums = new System.Windows.Forms.ListBox();
            this.labelEnums = new System.Windows.Forms.Label();
            this.groupBoxWeekday = new System.Windows.Forms.GroupBox();
            this.labelParseOutput = new System.Windows.Forms.Label();
            this.buttonParse = new System.Windows.Forms.Button();
            this.textBoxParse = new System.Windows.Forms.TextBox();
            this.labelParse = new System.Windows.Forms.Label();
            this.groupBoxSeason = new System.Windows.Forms.GroupBox();
            this.buttonSeason = new System.Windows.Forms.Button();
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            this.labelSeason = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxEnums.SuspendLayout();
            this.groupBoxWeekday.SuspendLayout();
            this.groupBoxSeason.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBoxEnums);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxWeekday);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxSeason);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(546, 496);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxEnums
            // 
            this.groupBoxEnums.Controls.Add(this.textBoxIntValue);
            this.groupBoxEnums.Controls.Add(this.labelIntValue);
            this.groupBoxEnums.Controls.Add(this.listBoxEnumsValues);
            this.groupBoxEnums.Controls.Add(this.labelEnumsValue);
            this.groupBoxEnums.Controls.Add(this.listBoxEnums);
            this.groupBoxEnums.Controls.Add(this.labelEnums);
            this.groupBoxEnums.Location = new System.Drawing.Point(3, 3);
            this.groupBoxEnums.Name = "groupBoxEnums";
            this.groupBoxEnums.Size = new System.Drawing.Size(539, 325);
            this.groupBoxEnums.TabIndex = 3;
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
            // groupBoxWeekday
            // 
            this.groupBoxWeekday.Controls.Add(this.labelParseOutput);
            this.groupBoxWeekday.Controls.Add(this.buttonParse);
            this.groupBoxWeekday.Controls.Add(this.textBoxParse);
            this.groupBoxWeekday.Controls.Add(this.labelParse);
            this.groupBoxWeekday.Location = new System.Drawing.Point(3, 334);
            this.groupBoxWeekday.Name = "groupBoxWeekday";
            this.groupBoxWeekday.Size = new System.Drawing.Size(270, 161);
            this.groupBoxWeekday.TabIndex = 4;
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
            // groupBoxSeason
            // 
            this.groupBoxSeason.Controls.Add(this.buttonSeason);
            this.groupBoxSeason.Controls.Add(this.comboBoxSeason);
            this.groupBoxSeason.Controls.Add(this.labelSeason);
            this.groupBoxSeason.Location = new System.Drawing.Point(279, 334);
            this.groupBoxSeason.Name = "groupBoxSeason";
            this.groupBoxSeason.Size = new System.Drawing.Size(263, 161);
            this.groupBoxSeason.TabIndex = 6;
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
            // EnumsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EnumsControl";
            this.Size = new System.Drawing.Size(546, 496);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBoxEnums.ResumeLayout(false);
            this.groupBoxEnums.PerformLayout();
            this.groupBoxWeekday.ResumeLayout(false);
            this.groupBoxWeekday.PerformLayout();
            this.groupBoxSeason.ResumeLayout(false);
            this.groupBoxSeason.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void InitializeListeners()
        {
            this.buttonParse.Click += ButtonParse_Click;
            this.buttonSeason.Click += ButtonSeason_Click;

            this.listBoxEnums.SelectedIndexChanged += ListBoxEnums_SelectedIndexChanged;
            this.listBoxEnumsValues.SelectedIndexChanged += ListBoxEnumsValues_SelectedIndexChanged;

            this.textBoxIntValue.TextChanged += TextBoxIntValue_TextChanged;
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxEnums;
        private System.Windows.Forms.TextBox textBoxIntValue;
        private System.Windows.Forms.Label labelIntValue;
        private System.Windows.Forms.ListBox listBoxEnumsValues;
        private System.Windows.Forms.Label labelEnumsValue;
        private System.Windows.Forms.ListBox listBoxEnums;
        private System.Windows.Forms.Label labelEnums;
        private System.Windows.Forms.GroupBox groupBoxWeekday;
        private System.Windows.Forms.Label labelParseOutput;
        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.TextBox textBoxParse;
        private System.Windows.Forms.Label labelParse;
        private System.Windows.Forms.GroupBox groupBoxSeason;
        private System.Windows.Forms.Button buttonSeason;
        private System.Windows.Forms.ComboBox comboBoxSeason;
        private System.Windows.Forms.Label labelSeason;
    }
}
