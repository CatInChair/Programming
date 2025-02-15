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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.groupBoxRectangles = new System.Windows.Forms.GroupBox();
            this.listBoxRectangles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.groupBoxRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 288);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage.Controls.Add(this.groupBoxRectangles);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(426, 262);
            this.tabPage.TabIndex = 1;
            this.tabPage.Text = "Classes";
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
            // listBoxRectangles
            // 
            this.listBoxRectangles.FormattingEnabled = true;
            this.listBoxRectangles.Location = new System.Drawing.Point(6, 19);
            this.listBoxRectangles.Name = "listBoxRectangles";
            this.listBoxRectangles.Size = new System.Drawing.Size(192, 199);
            this.listBoxRectangles.TabIndex = 0;
            this.listBoxRectangles.SelectedIndexChanged += ListBoxRectangles_SelectedIndexChanged;
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
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(233, 36);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxLength.TabIndex = 2;
            this.textBoxLength.TextChanged += TextBoxLength_TextChanged;
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
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(233, 75);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 4;
            this.textBoxWidth.TextChanged += TextBoxWidth_TextChanged;
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
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(233, 114);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 20);
            this.textBoxColor.TabIndex = 6;
            this.textBoxColor.TextChanged += TextBoxColor_TextChanged;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(244, 195);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "FInd";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += buttonFind_Click;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 312);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.groupBoxRectangles.ResumeLayout(false);
            this.groupBoxRectangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.GroupBox groupBoxRectangles;
        private System.Windows.Forms.ListBox listBoxRectangles;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
    }
}

