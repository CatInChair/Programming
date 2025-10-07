namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTabs
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
            this.itemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemsGenerateButton = new System.Windows.Forms.Button();
            this.ItemsRemoveButton = new System.Windows.Forms.Button();
            this.ItemsAddButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.selectedItemGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedItemNameLabel = new System.Windows.Forms.Label();
            this.SelectedItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemDescriptionLabel = new System.Windows.Forms.Label();
            this.SelectedItemNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemCostTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemCostLabel = new System.Windows.Forms.Label();
            this.SelectedItemIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemIdLabel = new System.Windows.Forms.Label();
            this.itemsGroupBox.SuspendLayout();
            this.selectedItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsGroupBox
            // 
            this.itemsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsGroupBox.Controls.Add(this.ItemsGenerateButton);
            this.itemsGroupBox.Controls.Add(this.ItemsRemoveButton);
            this.itemsGroupBox.Controls.Add(this.ItemsAddButton);
            this.itemsGroupBox.Controls.Add(this.ItemsListBox);
            this.itemsGroupBox.Location = new System.Drawing.Point(3, 0);
            this.itemsGroupBox.Name = "itemsGroupBox";
            this.itemsGroupBox.Size = new System.Drawing.Size(380, 553);
            this.itemsGroupBox.TabIndex = 14;
            this.itemsGroupBox.TabStop = false;
            this.itemsGroupBox.Text = "Items";
            // 
            // ItemsGenerateButton
            // 
            this.ItemsGenerateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ItemsGenerateButton.Location = new System.Drawing.Point(254, 482);
            this.ItemsGenerateButton.Name = "ItemsGenerateButton";
            this.ItemsGenerateButton.Size = new System.Drawing.Size(120, 65);
            this.ItemsGenerateButton.TabIndex = 8;
            this.ItemsGenerateButton.Text = "Generate";
            this.ItemsGenerateButton.UseVisualStyleBackColor = true;
            // 
            // ItemsRemoveButton
            // 
            this.ItemsRemoveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ItemsRemoveButton.Location = new System.Drawing.Point(128, 482);
            this.ItemsRemoveButton.Name = "ItemsRemoveButton";
            this.ItemsRemoveButton.Size = new System.Drawing.Size(120, 65);
            this.ItemsRemoveButton.TabIndex = 7;
            this.ItemsRemoveButton.Text = "Remove";
            this.ItemsRemoveButton.UseVisualStyleBackColor = true;
            // 
            // ItemsAddButton
            // 
            this.ItemsAddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ItemsAddButton.Location = new System.Drawing.Point(2, 482);
            this.ItemsAddButton.Name = "ItemsAddButton";
            this.ItemsAddButton.Size = new System.Drawing.Size(120, 65);
            this.ItemsAddButton.TabIndex = 6;
            this.ItemsAddButton.Text = "Add";
            this.ItemsAddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 19);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(371, 459);
            this.ItemsListBox.TabIndex = 5;
            // 
            // selectedItemGroupBox
            // 
            this.selectedItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemGroupBox.Controls.Add(this.SelectedItemNameLabel);
            this.selectedItemGroupBox.Controls.Add(this.SelectedItemDescriptionTextBox);
            this.selectedItemGroupBox.Controls.Add(this.SelectedItemDescriptionLabel);
            this.selectedItemGroupBox.Controls.Add(this.SelectedItemNameTextBox);
            this.selectedItemGroupBox.Controls.Add(this.SelectedItemCostTextBox);
            this.selectedItemGroupBox.Controls.Add(this.SelectedItemCostLabel);
            this.selectedItemGroupBox.Controls.Add(this.SelectedItemIdTextBox);
            this.selectedItemGroupBox.Controls.Add(this.SelectedItemIdLabel);
            this.selectedItemGroupBox.Location = new System.Drawing.Point(383, 0);
            this.selectedItemGroupBox.Name = "selectedItemGroupBox";
            this.selectedItemGroupBox.Size = new System.Drawing.Size(479, 553);
            this.selectedItemGroupBox.TabIndex = 15;
            this.selectedItemGroupBox.TabStop = false;
            this.selectedItemGroupBox.Text = "Selected Item";
            // 
            // SelectedItemNameLabel
            // 
            this.SelectedItemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemNameLabel.AutoSize = true;
            this.SelectedItemNameLabel.Location = new System.Drawing.Point(6, 110);
            this.SelectedItemNameLabel.Name = "SelectedItemNameLabel";
            this.SelectedItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.SelectedItemNameLabel.TabIndex = 22;
            this.SelectedItemNameLabel.Text = "Name:";
            // 
            // SelectedItemDescriptionTextBox
            // 
            this.SelectedItemDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemDescriptionTextBox.Location = new System.Drawing.Point(8, 310);
            this.SelectedItemDescriptionTextBox.MaxLength = 1000;
            this.SelectedItemDescriptionTextBox.Multiline = true;
            this.SelectedItemDescriptionTextBox.Name = "SelectedItemDescriptionTextBox";
            this.SelectedItemDescriptionTextBox.Size = new System.Drawing.Size(465, 131);
            this.SelectedItemDescriptionTextBox.TabIndex = 21;
            // 
            // SelectedItemDescriptionLabel
            // 
            this.SelectedItemDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemDescriptionLabel.AutoSize = true;
            this.SelectedItemDescriptionLabel.Location = new System.Drawing.Point(5, 294);
            this.SelectedItemDescriptionLabel.Name = "SelectedItemDescriptionLabel";
            this.SelectedItemDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.SelectedItemDescriptionLabel.TabIndex = 20;
            this.SelectedItemDescriptionLabel.Text = "Description:";
            // 
            // SelectedItemNameTextBox
            // 
            this.SelectedItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemNameTextBox.Location = new System.Drawing.Point(8, 126);
            this.SelectedItemNameTextBox.MaxLength = 200;
            this.SelectedItemNameTextBox.Multiline = true;
            this.SelectedItemNameTextBox.Name = "SelectedItemNameTextBox";
            this.SelectedItemNameTextBox.Size = new System.Drawing.Size(465, 131);
            this.SelectedItemNameTextBox.TabIndex = 19;
            // 
            // SelectedItemCostTextBox
            // 
            this.SelectedItemCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemCostTextBox.Location = new System.Drawing.Point(65, 67);
            this.SelectedItemCostTextBox.Name = "SelectedItemCostTextBox";
            this.SelectedItemCostTextBox.Size = new System.Drawing.Size(118, 20);
            this.SelectedItemCostTextBox.TabIndex = 17;
            // 
            // SelectedItemCostLabel
            // 
            this.SelectedItemCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemCostLabel.AutoSize = true;
            this.SelectedItemCostLabel.Location = new System.Drawing.Point(5, 70);
            this.SelectedItemCostLabel.Name = "SelectedItemCostLabel";
            this.SelectedItemCostLabel.Size = new System.Drawing.Size(31, 13);
            this.SelectedItemCostLabel.TabIndex = 16;
            this.SelectedItemCostLabel.Text = "Cost:";
            // 
            // SelectedItemIdTextBox
            // 
            this.SelectedItemIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemIdTextBox.Location = new System.Drawing.Point(65, 34);
            this.SelectedItemIdTextBox.Name = "SelectedItemIdTextBox";
            this.SelectedItemIdTextBox.ReadOnly = true;
            this.SelectedItemIdTextBox.Size = new System.Drawing.Size(118, 20);
            this.SelectedItemIdTextBox.TabIndex = 15;
            // 
            // SelectedItemIdLabel
            // 
            this.SelectedItemIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemIdLabel.AutoSize = true;
            this.SelectedItemIdLabel.Location = new System.Drawing.Point(5, 37);
            this.SelectedItemIdLabel.Name = "SelectedItemIdLabel";
            this.SelectedItemIdLabel.Size = new System.Drawing.Size(21, 13);
            this.SelectedItemIdLabel.TabIndex = 14;
            this.SelectedItemIdLabel.Text = "ID:";
            // 
            // ItemsTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemsGroupBox);
            this.Controls.Add(this.selectedItemGroupBox);
            this.Name = "ItemsTabs";
            this.Size = new System.Drawing.Size(862, 556);
            this.itemsGroupBox.ResumeLayout(false);
            this.selectedItemGroupBox.ResumeLayout(false);
            this.selectedItemGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void InitializeListeners()
        {
            this.ItemsAddButton.Click += ItemsAddButton_Click;
            this.ItemsRemoveButton.Click += ItemsRemoveButton_Click;
            this.ItemsGenerateButton.Click += ItemsGenerateButton_Click;

            this.SelectedItemCostTextBox.TextChanged += SelectedItemCostTextBox_TextChanged;
            this.SelectedItemDescriptionTextBox.TextChanged += SelectedItemDescriptionTextBox_TextChanged;
            this.SelectedItemNameTextBox.TextChanged += SelectedItemNameTextBox_TextChanged;

            this.ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
        }
        private System.Windows.Forms.GroupBox itemsGroupBox;
        private System.Windows.Forms.Button ItemsGenerateButton;
        private System.Windows.Forms.Button ItemsRemoveButton;
        private System.Windows.Forms.Button ItemsAddButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.GroupBox selectedItemGroupBox;
        private System.Windows.Forms.TextBox SelectedItemDescriptionTextBox;
        private System.Windows.Forms.Label SelectedItemDescriptionLabel;
        private System.Windows.Forms.TextBox SelectedItemNameTextBox;
        private System.Windows.Forms.TextBox SelectedItemCostTextBox;
        private System.Windows.Forms.Label SelectedItemCostLabel;
        private System.Windows.Forms.TextBox SelectedItemIdTextBox;
        private System.Windows.Forms.Label SelectedItemIdLabel;
        private System.Windows.Forms.Label SelectedItemNameLabel;
    }
}
