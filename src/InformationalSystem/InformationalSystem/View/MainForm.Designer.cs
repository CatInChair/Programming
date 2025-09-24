namespace InformationalSystem
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
            this.components = new System.ComponentModel.Container();
            this.listBoxRoutes = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBoxRoute = new System.Windows.Forms.GroupBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDepartureTime = new System.Windows.Forms.Label();
            this.textBoxArrivalPoint = new System.Windows.Forms.TextBox();
            this.labelArrivalPoint = new System.Windows.Forms.Label();
            this.dateTimePickerDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.textBoxDeparturePoint = new System.Windows.Forms.TextBox();
            this.labelDeparturePoint = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxRoute.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRoutes
            // 
            this.listBoxRoutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxRoutes.FormattingEnabled = true;
            this.listBoxRoutes.Location = new System.Drawing.Point(12, 12);
            this.listBoxRoutes.Name = "listBoxRoutes";
            this.listBoxRoutes.Size = new System.Drawing.Size(334, 498);
            this.listBoxRoutes.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 516);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 42);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRemove.Location = new System.Drawing.Point(128, 516);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(108, 42);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            // 
            // groupBoxRoute
            // 
            this.groupBoxRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRoute.Controls.Add(this.labelType);
            this.groupBoxRoute.Controls.Add(this.comboBoxType);
            this.groupBoxRoute.Controls.Add(this.labelDuration);
            this.groupBoxRoute.Controls.Add(this.textBoxDuration);
            this.groupBoxRoute.Controls.Add(this.labelDepartureTime);
            this.groupBoxRoute.Controls.Add(this.textBoxArrivalPoint);
            this.groupBoxRoute.Controls.Add(this.labelArrivalPoint);
            this.groupBoxRoute.Controls.Add(this.dateTimePickerDepartureTime);
            this.groupBoxRoute.Controls.Add(this.textBoxDeparturePoint);
            this.groupBoxRoute.Controls.Add(this.labelDeparturePoint);
            this.groupBoxRoute.Location = new System.Drawing.Point(420, 12);
            this.groupBoxRoute.Name = "groupBoxRoute";
            this.groupBoxRoute.Size = new System.Drawing.Size(362, 274);
            this.groupBoxRoute.TabIndex = 4;
            this.groupBoxRoute.TabStop = false;
            this.groupBoxRoute.Text = "Selected Route:";
            // 
            // labelType
            // 
            this.labelType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(120, 181);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 9;
            this.labelType.Text = "Type:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(160, 178);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(122, 21);
            this.comboBoxType.TabIndex = 8;
            // 
            // labelDuration
            // 
            this.labelDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(104, 152);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 7;
            this.labelDuration.Text = "Duration:";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDuration.Location = new System.Drawing.Point(160, 149);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(122, 20);
            this.textBoxDuration.TabIndex = 6;
            // 
            // labelDepartureTime
            // 
            this.labelDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDepartureTime.AutoSize = true;
            this.labelDepartureTime.Location = new System.Drawing.Point(71, 124);
            this.labelDepartureTime.Name = "labelDepartureTime";
            this.labelDepartureTime.Size = new System.Drawing.Size(83, 13);
            this.labelDepartureTime.TabIndex = 5;
            this.labelDepartureTime.Text = "Departure Time:";
            // 
            // textBoxArrivalPoint
            // 
            this.textBoxArrivalPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxArrivalPoint.Location = new System.Drawing.Point(160, 92);
            this.textBoxArrivalPoint.Name = "textBoxArrivalPoint";
            this.textBoxArrivalPoint.Size = new System.Drawing.Size(122, 20);
            this.textBoxArrivalPoint.TabIndex = 4;
            // 
            // labelArrivalPoint
            // 
            this.labelArrivalPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelArrivalPoint.AutoSize = true;
            this.labelArrivalPoint.Location = new System.Drawing.Point(88, 95);
            this.labelArrivalPoint.Name = "labelArrivalPoint";
            this.labelArrivalPoint.Size = new System.Drawing.Size(66, 13);
            this.labelArrivalPoint.TabIndex = 3;
            this.labelArrivalPoint.Text = "Arrival Point:";
            // 
            // dateTimePickerDepartureTime
            // 
            this.dateTimePickerDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDepartureTime.Location = new System.Drawing.Point(160, 121);
            this.dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
            this.dateTimePickerDepartureTime.Size = new System.Drawing.Size(122, 20);
            this.dateTimePickerDepartureTime.TabIndex = 2;
            this.dateTimePickerDepartureTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // textBoxDeparturePoint
            // 
            this.textBoxDeparturePoint.AccessibleDescription = "";
            this.textBoxDeparturePoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeparturePoint.Location = new System.Drawing.Point(160, 63);
            this.textBoxDeparturePoint.Name = "textBoxDeparturePoint";
            this.textBoxDeparturePoint.Size = new System.Drawing.Size(122, 20);
            this.textBoxDeparturePoint.TabIndex = 1;
            // 
            // labelDeparturePoint
            // 
            this.labelDeparturePoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDeparturePoint.AutoSize = true;
            this.labelDeparturePoint.Location = new System.Drawing.Point(70, 66);
            this.labelDeparturePoint.Name = "labelDeparturePoint";
            this.labelDeparturePoint.Size = new System.Drawing.Size(84, 13);
            this.labelDeparturePoint.TabIndex = 0;
            this.labelDeparturePoint.Text = "Departure Point:";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.Location = new System.Drawing.Point(242, 517);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 42);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 571);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxRoute);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxRoutes);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AviaSales";
            this.groupBoxRoute.ResumeLayout(false);
            this.groupBoxRoute.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void InitializeListeners()
        {
            this.buttonAdd.Click += ButtonAdd_Click;
            this.buttonRemove.Click += ButtonRemove_Click;
            this.buttonSave.Click += ButtonSave_Click;

            this.textBoxArrivalPoint.TextChanged += TextBoxArrivalPoint_TextChanged;
            this.textBoxDeparturePoint.TextChanged += TextBoxDeparturePoint_TextChanged;
            this.textBoxDuration.TextChanged += TextBoxDuration_Duration;
            this.comboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
            this.dateTimePickerDepartureTime.ValueChanged += DateTimePickerDepartureTime_ValueChanged;

            this.listBoxRoutes.SelectedIndexChanged += ListBoxRoutes_SelectedIndexChanged;
        }

        private System.Windows.Forms.ListBox listBoxRoutes;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.GroupBox groupBoxRoute;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureTime;
        private System.Windows.Forms.TextBox textBoxDeparturePoint;
        private System.Windows.Forms.Label labelDeparturePoint;
        private System.Windows.Forms.TextBox textBoxArrivalPoint;
        private System.Windows.Forms.Label labelArrivalPoint;
        private System.Windows.Forms.Label labelDepartureTime;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonSave;
    }
}

