namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTabs
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
            this.CustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomersGenerateButton = new System.Windows.Forms.Button();
            this.CustomersRemoveButton = new System.Windows.Forms.Button();
            this.CustomersAddButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.selectedCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscountsGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscountRemoveButton = new System.Windows.Forms.Button();
            this.DiscountAddButton = new System.Windows.Forms.Button();
            this.CustomerDiscountsListBox = new System.Windows.Forms.ListBox();
            this.SelectedCustomerIsPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.AddressControl = new ObjectOrientedPractics.View.Tabs.AddressControl();
            this.SelectedCustomerFullnameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemCostLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerIdLabel = new System.Windows.Forms.Label();
            this.CustomersGroupBox.SuspendLayout();
            this.selectedCustomerGroupBox.SuspendLayout();
            this.DiscountsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            this.CustomersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersGroupBox.Controls.Add(this.CustomersGenerateButton);
            this.CustomersGroupBox.Controls.Add(this.CustomersRemoveButton);
            this.CustomersGroupBox.Controls.Add(this.CustomersAddButton);
            this.CustomersGroupBox.Controls.Add(this.CustomersListBox);
            this.CustomersGroupBox.Location = new System.Drawing.Point(2, 2);
            this.CustomersGroupBox.Name = "CustomersGroupBox";
            this.CustomersGroupBox.Size = new System.Drawing.Size(380, 553);
            this.CustomersGroupBox.TabIndex = 16;
            this.CustomersGroupBox.TabStop = false;
            this.CustomersGroupBox.Text = "Customers";
            // 
            // CustomersGenerateButton
            // 
            this.CustomersGenerateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CustomersGenerateButton.Location = new System.Drawing.Point(254, 482);
            this.CustomersGenerateButton.Name = "CustomersGenerateButton";
            this.CustomersGenerateButton.Size = new System.Drawing.Size(120, 65);
            this.CustomersGenerateButton.TabIndex = 8;
            this.CustomersGenerateButton.Text = "Generate";
            this.CustomersGenerateButton.UseVisualStyleBackColor = true;
            // 
            // CustomersRemoveButton
            // 
            this.CustomersRemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CustomersRemoveButton.Location = new System.Drawing.Point(128, 482);
            this.CustomersRemoveButton.Name = "CustomersRemoveButton";
            this.CustomersRemoveButton.Size = new System.Drawing.Size(120, 65);
            this.CustomersRemoveButton.TabIndex = 7;
            this.CustomersRemoveButton.Text = "Remove";
            this.CustomersRemoveButton.UseVisualStyleBackColor = true;
            // 
            // CustomersAddButton
            // 
            this.CustomersAddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CustomersAddButton.Location = new System.Drawing.Point(2, 482);
            this.CustomersAddButton.Name = "CustomersAddButton";
            this.CustomersAddButton.Size = new System.Drawing.Size(120, 65);
            this.CustomersAddButton.TabIndex = 6;
            this.CustomersAddButton.Text = "Add";
            this.CustomersAddButton.UseVisualStyleBackColor = true;
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 19);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(371, 459);
            this.CustomersListBox.TabIndex = 5;
            // 
            // selectedCustomerGroupBox
            // 
            this.selectedCustomerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedCustomerGroupBox.Controls.Add(this.DiscountsGroupBox);
            this.selectedCustomerGroupBox.Controls.Add(this.SelectedCustomerIsPriorityCheckBox);
            this.selectedCustomerGroupBox.Controls.Add(this.AddressControl);
            this.selectedCustomerGroupBox.Controls.Add(this.SelectedCustomerFullnameTextBox);
            this.selectedCustomerGroupBox.Controls.Add(this.SelectedItemCostLabel);
            this.selectedCustomerGroupBox.Controls.Add(this.SelectedCustomerIdTextBox);
            this.selectedCustomerGroupBox.Controls.Add(this.SelectedCustomerIdLabel);
            this.selectedCustomerGroupBox.Location = new System.Drawing.Point(382, 2);
            this.selectedCustomerGroupBox.Name = "selectedCustomerGroupBox";
            this.selectedCustomerGroupBox.Size = new System.Drawing.Size(479, 408);
            this.selectedCustomerGroupBox.TabIndex = 17;
            this.selectedCustomerGroupBox.TabStop = false;
            this.selectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // DiscountsGroupBox
            // 
            this.DiscountsGroupBox.Controls.Add(this.DiscountRemoveButton);
            this.DiscountsGroupBox.Controls.Add(this.DiscountAddButton);
            this.DiscountsGroupBox.Controls.Add(this.CustomerDiscountsListBox);
            this.DiscountsGroupBox.Location = new System.Drawing.Point(8, 279);
            this.DiscountsGroupBox.Name = "DiscountsGroupBox";
            this.DiscountsGroupBox.Size = new System.Drawing.Size(465, 123);
            this.DiscountsGroupBox.TabIndex = 29;
            this.DiscountsGroupBox.TabStop = false;
            this.DiscountsGroupBox.Text = "Discounts";
            // 
            // DiscountRemoveButton
            // 
            this.DiscountRemoveButton.Location = new System.Drawing.Point(327, 68);
            this.DiscountRemoveButton.Name = "DiscountRemoveButton";
            this.DiscountRemoveButton.Size = new System.Drawing.Size(132, 34);
            this.DiscountRemoveButton.TabIndex = 2;
            this.DiscountRemoveButton.Text = "Remove";
            this.DiscountRemoveButton.UseVisualStyleBackColor = true;
            // 
            // DiscountAddButton
            // 
            this.DiscountAddButton.Location = new System.Drawing.Point(327, 31);
            this.DiscountAddButton.Name = "DiscountAddButton";
            this.DiscountAddButton.Size = new System.Drawing.Size(132, 31);
            this.DiscountAddButton.TabIndex = 1;
            this.DiscountAddButton.Text = "Add new";
            this.DiscountAddButton.UseVisualStyleBackColor = true;
            // 
            // CustomerDiscountsListBox
            // 
            this.CustomerDiscountsListBox.FormattingEnabled = true;
            this.CustomerDiscountsListBox.Location = new System.Drawing.Point(7, 20);
            this.CustomerDiscountsListBox.Name = "CustomerDiscountsListBox";
            this.CustomerDiscountsListBox.Size = new System.Drawing.Size(314, 95);
            this.CustomerDiscountsListBox.TabIndex = 0;
            // 
            // SelectedCustomerIsPriorityCheckBox
            // 
            this.SelectedCustomerIsPriorityCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedCustomerIsPriorityCheckBox.AutoSize = true;
            this.SelectedCustomerIsPriorityCheckBox.Location = new System.Drawing.Point(69, 81);
            this.SelectedCustomerIsPriorityCheckBox.Name = "SelectedCustomerIsPriorityCheckBox";
            this.SelectedCustomerIsPriorityCheckBox.Size = new System.Drawing.Size(67, 17);
            this.SelectedCustomerIsPriorityCheckBox.TabIndex = 28;
            this.SelectedCustomerIsPriorityCheckBox.Text = "is Priority";
            this.SelectedCustomerIsPriorityCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddressControl
            // 
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.Location = new System.Drawing.Point(8, 104);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(465, 168);
            this.AddressControl.TabIndex = 27;
            // 
            // SelectedCustomerFullnameTextBox
            // 
            this.SelectedCustomerFullnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerFullnameTextBox.Location = new System.Drawing.Point(69, 55);
            this.SelectedCustomerFullnameTextBox.MaxLength = 200;
            this.SelectedCustomerFullnameTextBox.Name = "SelectedCustomerFullnameTextBox";
            this.SelectedCustomerFullnameTextBox.Size = new System.Drawing.Size(404, 20);
            this.SelectedCustomerFullnameTextBox.TabIndex = 26;
            // 
            // SelectedItemCostLabel
            // 
            this.SelectedItemCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedItemCostLabel.AutoSize = true;
            this.SelectedItemCostLabel.Location = new System.Drawing.Point(11, 58);
            this.SelectedItemCostLabel.Name = "SelectedItemCostLabel";
            this.SelectedItemCostLabel.Size = new System.Drawing.Size(52, 13);
            this.SelectedItemCostLabel.TabIndex = 25;
            this.SelectedItemCostLabel.Text = "Fullname:";
            // 
            // SelectedCustomerIdTextBox
            // 
            this.SelectedCustomerIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedCustomerIdTextBox.Location = new System.Drawing.Point(69, 29);
            this.SelectedCustomerIdTextBox.Name = "SelectedCustomerIdTextBox";
            this.SelectedCustomerIdTextBox.ReadOnly = true;
            this.SelectedCustomerIdTextBox.Size = new System.Drawing.Size(194, 20);
            this.SelectedCustomerIdTextBox.TabIndex = 24;
            // 
            // SelectedCustomerIdLabel
            // 
            this.SelectedCustomerIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedCustomerIdLabel.AutoSize = true;
            this.SelectedCustomerIdLabel.Location = new System.Drawing.Point(9, 32);
            this.SelectedCustomerIdLabel.Name = "SelectedCustomerIdLabel";
            this.SelectedCustomerIdLabel.Size = new System.Drawing.Size(21, 13);
            this.SelectedCustomerIdLabel.TabIndex = 23;
            this.SelectedCustomerIdLabel.Text = "ID:";
            // 
            // CustomersTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomersGroupBox);
            this.Controls.Add(this.selectedCustomerGroupBox);
            this.Name = "CustomersTabs";
            this.Size = new System.Drawing.Size(862, 556);
            this.CustomersGroupBox.ResumeLayout(false);
            this.selectedCustomerGroupBox.ResumeLayout(false);
            this.selectedCustomerGroupBox.PerformLayout();
            this.DiscountsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void InitializeListeners()
        {
            this.CustomersAddButton.Click += CustomersAddButton_Click;
            this.CustomersRemoveButton.Click += CustomersRemoveButton_Click;
            this.CustomersGenerateButton.Click += CustomersGenerateButton_Click;

            this.SelectedCustomerFullnameTextBox.TextChanged += SelectedCustomerFullnameTextBox_TextChanged;
            this.SelectedCustomerIsPriorityCheckBox.CheckedChanged += SelectedCustomerIsPriorityCheckBox_CheckedChanged;

            this.CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;

            this.DiscountAddButton.Click += DiscountAddButton_Click;
            this.DiscountRemoveButton.Click += DiscountRemoveButton_Click;
        }

        private System.Windows.Forms.GroupBox CustomersGroupBox;
        private System.Windows.Forms.Button CustomersGenerateButton;
        private System.Windows.Forms.Button CustomersRemoveButton;
        private System.Windows.Forms.Button CustomersAddButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.GroupBox selectedCustomerGroupBox;
        private System.Windows.Forms.TextBox SelectedCustomerFullnameTextBox;
        private System.Windows.Forms.Label SelectedItemCostLabel;
        private System.Windows.Forms.TextBox SelectedCustomerIdTextBox;
        private System.Windows.Forms.Label SelectedCustomerIdLabel;
        private AddressControl AddressControl;
        private System.Windows.Forms.CheckBox SelectedCustomerIsPriorityCheckBox;
        private System.Windows.Forms.GroupBox DiscountsGroupBox;
        private System.Windows.Forms.Button DiscountRemoveButton;
        private System.Windows.Forms.Button DiscountAddButton;
        private System.Windows.Forms.ListBox CustomerDiscountsListBox;
    }
}
