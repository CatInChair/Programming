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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEnums = new System.Windows.Forms.TabPage();
            this.groupBoxSeason = new System.Windows.Forms.GroupBox();
            this.buttonSeason = new System.Windows.Forms.Button();
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            this.labelSeason = new System.Windows.Forms.Label();
            this.labelParseOutput = new System.Windows.Forms.Label();
            this.labelParse = new System.Windows.Forms.Label();
            this.buttonParse = new System.Windows.Forms.Button();
            this.textBoxParse = new System.Windows.Forms.TextBox();
            this.labelEnums = new System.Windows.Forms.Label();
            this.listBoxEnums = new System.Windows.Forms.ListBox();
            this.groupBoxEnums = new System.Windows.Forms.GroupBox();
            this.listBoxEnumsValues = new System.Windows.Forms.ListBox();
            this.labelEnumsValues = new System.Windows.Forms.Label();
            this.textBoxIntValue = new System.Windows.Forms.TextBox();
            this.labelIntValue = new System.Windows.Forms.Label();
            this.groupBoxParse = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPageEnums.SuspendLayout();
            this.groupBoxSeason.SuspendLayout();
            this.groupBoxEnums.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEnums);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEnums
            // 
            this.tabPageEnums.Controls.Add(this.groupBoxSeason);
            this.tabPageEnums.Controls.Add(this.labelParseOutput);
            this.tabPageEnums.Controls.Add(this.labelParse);
            this.tabPageEnums.Controls.Add(this.buttonParse);
            this.tabPageEnums.Controls.Add(this.textBoxParse);
            this.tabPageEnums.Controls.Add(this.labelEnums);
            this.tabPageEnums.Controls.Add(this.listBoxEnums);
            this.tabPageEnums.Controls.Add(this.groupBoxEnums);
            this.tabPageEnums.Controls.Add(this.groupBoxParse);
            this.tabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnums.Size = new System.Drawing.Size(792, 526);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.UseVisualStyleBackColor = true;
            // 
            // groupBoxSeason
            // 
            this.groupBoxSeason.Controls.Add(this.buttonSeason);
            this.groupBoxSeason.Controls.Add(this.comboBoxSeason);
            this.groupBoxSeason.Controls.Add(this.labelSeason);
            this.groupBoxSeason.Location = new System.Drawing.Point(410, 325);
            this.groupBoxSeason.Name = "groupBoxSeason";
            this.groupBoxSeason.Size = new System.Drawing.Size(374, 184);
            this.groupBoxSeason.TabIndex = 12;
            this.groupBoxSeason.TabStop = false;
            this.groupBoxSeason.Text = "Season handling";
            // 
            // buttonSeason
            // 
            this.buttonSeason.Location = new System.Drawing.Point(243, 45);
            this.buttonSeason.Name = "buttonSeason";
            this.buttonSeason.Size = new System.Drawing.Size(75, 21);
            this.buttonSeason.TabIndex = 11;
            this.buttonSeason.Text = "Go!";
            this.buttonSeason.UseVisualStyleBackColor = true;
            this.buttonSeason.Click += new System.EventHandler(this.buttonSeason_Click);
            // 
            // comboBoxSeason
            // 
            this.comboBoxSeason.FormattingEnabled = true;
            this.comboBoxSeason.Location = new System.Drawing.Point(17, 44);
            this.comboBoxSeason.Name = "comboBoxSeason";
            this.comboBoxSeason.Size = new System.Drawing.Size(220, 21);
            this.comboBoxSeason.TabIndex = 10;
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Location = new System.Drawing.Point(14, 29);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(84, 13);
            this.labelSeason.TabIndex = 9;
            this.labelSeason.Text = "Change season:";
            // 
            // labelParseOutput
            // 
            this.labelParseOutput.AutoSize = true;
            this.labelParseOutput.Location = new System.Drawing.Point(23, 413);
            this.labelParseOutput.Name = "labelParseOutput";
            this.labelParseOutput.Size = new System.Drawing.Size(156, 13);
            this.labelParseOutput.TabIndex = 9;
            this.labelParseOutput.Text = "Это день недели (Monday = 1)";
            // 
            // labelParse
            // 
            this.labelParse.AutoSize = true;
            this.labelParse.Location = new System.Drawing.Point(23, 354);
            this.labelParse.Name = "labelParse";
            this.labelParse.Size = new System.Drawing.Size(115, 13);
            this.labelParse.TabIndex = 8;
            this.labelParse.Text = "Type value for parsing:";
            // 
            // buttonParse
            // 
            this.buttonParse.Location = new System.Drawing.Point(282, 369);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(75, 21);
            this.buttonParse.TabIndex = 7;
            this.buttonParse.Text = "Parse";
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.buttonParse_Click);
            // 
            // textBoxParse
            // 
            this.textBoxParse.Location = new System.Drawing.Point(26, 370);
            this.textBoxParse.Name = "textBoxParse";
            this.textBoxParse.Size = new System.Drawing.Size(250, 20);
            this.textBoxParse.TabIndex = 6;
            this.textBoxParse.Text = "Monday";
            // 
            // labelEnums
            // 
            this.labelEnums.AutoSize = true;
            this.labelEnums.Location = new System.Drawing.Point(23, 30);
            this.labelEnums.Name = "labelEnums";
            this.labelEnums.Size = new System.Drawing.Size(107, 13);
            this.labelEnums.TabIndex = 1;
            this.labelEnums.Text = "Choose enumeration:";
            // 
            // listBoxEnums
            // 
            this.listBoxEnums.FormattingEnabled = true;
            this.listBoxEnums.Location = new System.Drawing.Point(26, 46);
            this.listBoxEnums.Name = "listBoxEnums";
            this.listBoxEnums.Size = new System.Drawing.Size(158, 251);
            this.listBoxEnums.TabIndex = 0;
            this.listBoxEnums.SelectedIndexChanged += listBoxEnums_SelectedIndexChanged;
            // 
            // groupBoxEnums
            // 
            this.groupBoxEnums.Controls.Add(this.listBoxEnumsValues);
            this.groupBoxEnums.Controls.Add(this.labelEnumsValues);
            this.groupBoxEnums.Controls.Add(this.textBoxIntValue);
            this.groupBoxEnums.Controls.Add(this.labelIntValue);
            this.groupBoxEnums.Location = new System.Drawing.Point(8, 6);
            this.groupBoxEnums.Name = "groupBoxEnums";
            this.groupBoxEnums.Size = new System.Drawing.Size(776, 312);
            this.groupBoxEnums.TabIndex = 10;
            this.groupBoxEnums.TabStop = false;
            this.groupBoxEnums.Text = "Enumerations";
            // 
            // listBoxEnumsValues
            // 
            this.listBoxEnumsValues.FormattingEnabled = true;
            this.listBoxEnumsValues.Location = new System.Drawing.Point(216, 40);
            this.listBoxEnumsValues.Name = "listBoxEnumsValues";
            this.listBoxEnumsValues.Size = new System.Drawing.Size(158, 251);
            this.listBoxEnumsValues.TabIndex = 2;
            this.listBoxEnumsValues.SelectedIndexChanged += listBoxEnumsValues_SelectedIndexChanged;
            // 
            // labelEnumsValues
            // 
            this.labelEnumsValues.AutoSize = true;
            this.labelEnumsValues.Location = new System.Drawing.Point(213, 24);
            this.labelEnumsValues.Name = "labelEnumsValues";
            this.labelEnumsValues.Size = new System.Drawing.Size(75, 13);
            this.labelEnumsValues.TabIndex = 3;
            this.labelEnumsValues.Text = "Choose value:";
            // 
            // textBoxIntValue
            // 
            this.textBoxIntValue.Location = new System.Drawing.Point(419, 40);
            this.textBoxIntValue.MaxLength = 1;
            this.textBoxIntValue.Name = "textBoxIntValue";
            this.textBoxIntValue.Size = new System.Drawing.Size(158, 20);
            this.textBoxIntValue.TabIndex = 4;
            this.textBoxIntValue.TextChanged += textBoxIntValue_TextChanged;
            // 
            // labelIntValue
            // 
            this.labelIntValue.AutoSize = true;
            this.labelIntValue.Location = new System.Drawing.Point(416, 24);
            this.labelIntValue.Name = "labelIntValue";
            this.labelIntValue.Size = new System.Drawing.Size(51, 13);
            this.labelIntValue.TabIndex = 5;
            this.labelIntValue.Text = "Int value:";
            // 
            // groupBoxParse
            // 
            this.groupBoxParse.Location = new System.Drawing.Point(8, 325);
            this.groupBoxParse.Name = "groupBoxParse";
            this.groupBoxParse.Size = new System.Drawing.Size(374, 184);
            this.groupBoxParse.TabIndex = 11;
            this.groupBoxParse.TabStop = false;
            this.groupBoxParse.Text = "Weekday parsing";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Programming";
            this.tabControl1.ResumeLayout(false);
            this.tabPageEnums.ResumeLayout(false);
            this.tabPageEnums.PerformLayout();
            this.groupBoxSeason.ResumeLayout(false);
            this.groupBoxSeason.PerformLayout();
            this.groupBoxEnums.ResumeLayout(false);
            this.groupBoxEnums.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEnums;
        private System.Windows.Forms.ListBox listBoxEnums;
        private System.Windows.Forms.Label labelIntValue;
        private System.Windows.Forms.TextBox textBoxIntValue;
        private System.Windows.Forms.Label labelEnumsValues;
        private System.Windows.Forms.ListBox listBoxEnumsValues;
        private System.Windows.Forms.Label labelEnums;
        private System.Windows.Forms.TextBox textBoxParse;
        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.Label labelParseOutput;
        private System.Windows.Forms.Label labelParse;
        private System.Windows.Forms.GroupBox groupBoxEnums;
        private System.Windows.Forms.GroupBox groupBoxParse;
        private System.Windows.Forms.GroupBox groupBoxSeason;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Button buttonSeason;
        private System.Windows.Forms.ComboBox comboBoxSeason;
    }
}

