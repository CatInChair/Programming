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
            this.ItemsListBoxLabel = new System.Windows.Forms.Label();
            this.ItemsAddButton = new System.Windows.Forms.Button();
            this.ItemsRemoveButton = new System.Windows.Forms.Button();
            this.ItemsGenerateButton = new System.Windows.Forms.Button();
            this.SelectedItemsLabel = new System.Windows.Forms.Label();
            this.SelectedItemIdLabel = new System.Windows.Forms.Label();
            this.SelectedItemIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemCostLabel = new System.Windows.Forms.Label();
            this.SelectedItemCostTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemNameLabel = new System.Windows.Forms.Label();
            this.SelectedItemNameTextBox = new System.Windows.Forms.TextBox();
            this.SelectedItemDescriptionLabel = new System.Windows.Forms.Label();
            this.SelectedItemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ItemsListBoxLabel
            // 
            this.ItemsListBoxLabel.AutoSize = true;
            this.ItemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsListBoxLabel.Location = new System.Drawing.Point(3, 5);
            this.ItemsListBoxLabel.Name = "ItemsListBoxLabel";
            this.ItemsListBoxLabel.Size = new System.Drawing.Size(37, 13);
            this.ItemsListBoxLabel.TabIndex = 0;
            this.ItemsListBoxLabel.Text = "Items";
            // 
            // ItemsAddButton
            // 
            this.ItemsAddButton.Location = new System.Drawing.Point(6, 486);
            this.ItemsAddButton.Name = "ItemsAddButton";
            this.ItemsAddButton.Size = new System.Drawing.Size(120, 65);
            this.ItemsAddButton.TabIndex = 2;
            this.ItemsAddButton.Text = "Add";
            this.ItemsAddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsRemoveButton
            // 
            this.ItemsRemoveButton.Location = new System.Drawing.Point(132, 486);
            this.ItemsRemoveButton.Name = "ItemsRemoveButton";
            this.ItemsRemoveButton.Size = new System.Drawing.Size(120, 65);
            this.ItemsRemoveButton.TabIndex = 3;
            this.ItemsRemoveButton.Text = "Remove";
            this.ItemsRemoveButton.UseVisualStyleBackColor = true;
            // 
            // ItemsGenerateButton
            // 
            this.ItemsGenerateButton.Location = new System.Drawing.Point(257, 486);
            this.ItemsGenerateButton.Name = "ItemsGenerateButton";
            this.ItemsGenerateButton.Size = new System.Drawing.Size(120, 65);
            this.ItemsGenerateButton.TabIndex = 4;
            this.ItemsGenerateButton.Text = "Generate";
            this.ItemsGenerateButton.UseVisualStyleBackColor = true;
            // 
            // SelectedItemsLabel
            // 
            this.SelectedItemsLabel.AutoSize = true;
            this.SelectedItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemsLabel.Location = new System.Drawing.Point(383, 5);
            this.SelectedItemsLabel.Name = "SelectedItemsLabel";
            this.SelectedItemsLabel.Size = new System.Drawing.Size(91, 13);
            this.SelectedItemsLabel.TabIndex = 5;
            this.SelectedItemsLabel.Text = "Selected Items";
            // 
            // SelectedItemIdLabel
            // 
            this.SelectedItemIdLabel.AutoSize = true;
            this.SelectedItemIdLabel.Location = new System.Drawing.Point(386, 36);
            this.SelectedItemIdLabel.Name = "SelectedItemIdLabel";
            this.SelectedItemIdLabel.Size = new System.Drawing.Size(21, 13);
            this.SelectedItemIdLabel.TabIndex = 6;
            this.SelectedItemIdLabel.Text = "ID:";
            // 
            // SelectedItemIdTextBox
            // 
            this.SelectedItemIdTextBox.Location = new System.Drawing.Point(446, 33);
            this.SelectedItemIdTextBox.Name = "SelectedItemIdTextBox";
            this.SelectedItemIdTextBox.ReadOnly = true;
            this.SelectedItemIdTextBox.Size = new System.Drawing.Size(118, 20);
            this.SelectedItemIdTextBox.TabIndex = 7;
            // 
            // SelectedItemCostLabel
            // 
            this.SelectedItemCostLabel.AutoSize = true;
            this.SelectedItemCostLabel.Location = new System.Drawing.Point(386, 69);
            this.SelectedItemCostLabel.Name = "SelectedItemCostLabel";
            this.SelectedItemCostLabel.Size = new System.Drawing.Size(31, 13);
            this.SelectedItemCostLabel.TabIndex = 8;
            this.SelectedItemCostLabel.Text = "Cost:";
            // 
            // SelectedItemCostTextBox
            // 
            this.SelectedItemCostTextBox.Location = new System.Drawing.Point(446, 66);
            this.SelectedItemCostTextBox.Name = "SelectedItemCostTextBox";
            this.SelectedItemCostTextBox.Size = new System.Drawing.Size(118, 20);
            this.SelectedItemCostTextBox.TabIndex = 9;
            // 
            // SelectedItemNameLabel
            // 
            this.SelectedItemNameLabel.AutoSize = true;
            this.SelectedItemNameLabel.Location = new System.Drawing.Point(386, 104);
            this.SelectedItemNameLabel.Name = "SelectedItemNameLabel";
            this.SelectedItemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.SelectedItemNameLabel.TabIndex = 10;
            this.SelectedItemNameLabel.Text = "Name:";
            // 
            // SelectedItemNameTextBox
            // 
            this.SelectedItemNameTextBox.Location = new System.Drawing.Point(389, 125);
            this.SelectedItemNameTextBox.MaxLength = 200;
            this.SelectedItemNameTextBox.Multiline = true;
            this.SelectedItemNameTextBox.Name = "SelectedItemNameTextBox";
            this.SelectedItemNameTextBox.Size = new System.Drawing.Size(465, 131);
            this.SelectedItemNameTextBox.TabIndex = 11;
            // 
            // SelectedItemDescriptionLabel
            // 
            this.SelectedItemDescriptionLabel.AutoSize = true;
            this.SelectedItemDescriptionLabel.Location = new System.Drawing.Point(386, 275);
            this.SelectedItemDescriptionLabel.Name = "SelectedItemDescriptionLabel";
            this.SelectedItemDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.SelectedItemDescriptionLabel.TabIndex = 12;
            this.SelectedItemDescriptionLabel.Text = "Description:";
            // 
            // SelectedItemDescriptionTextBox
            // 
            this.SelectedItemDescriptionTextBox.Location = new System.Drawing.Point(389, 309);
            this.SelectedItemDescriptionTextBox.MaxLength = 1000;
            this.SelectedItemDescriptionTextBox.Multiline = true;
            this.SelectedItemDescriptionTextBox.Name = "SelectedItemDescriptionTextBox";
            this.SelectedItemDescriptionTextBox.Size = new System.Drawing.Size(465, 131);
            this.SelectedItemDescriptionTextBox.TabIndex = 13;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(6, 21);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(371, 459);
            this.ItemsListBox.TabIndex = 1;
            // 
            // ItemsTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedItemDescriptionTextBox);
            this.Controls.Add(this.SelectedItemDescriptionLabel);
            this.Controls.Add(this.SelectedItemNameTextBox);
            this.Controls.Add(this.SelectedItemNameLabel);
            this.Controls.Add(this.SelectedItemCostTextBox);
            this.Controls.Add(this.SelectedItemCostLabel);
            this.Controls.Add(this.SelectedItemIdTextBox);
            this.Controls.Add(this.SelectedItemIdLabel);
            this.Controls.Add(this.SelectedItemsLabel);
            this.Controls.Add(this.ItemsGenerateButton);
            this.Controls.Add(this.ItemsRemoveButton);
            this.Controls.Add(this.ItemsAddButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsListBoxLabel);
            this.Name = "ItemsTabs";
            this.Size = new System.Drawing.Size(862, 556);
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private System.Windows.Forms.Label ItemsListBoxLabel;
        private System.Windows.Forms.Button ItemsAddButton;
        private System.Windows.Forms.Button ItemsRemoveButton;
        private System.Windows.Forms.Button ItemsGenerateButton;
        private System.Windows.Forms.Label SelectedItemsLabel;
        private System.Windows.Forms.Label SelectedItemIdLabel;
        private System.Windows.Forms.TextBox SelectedItemIdTextBox;
        private System.Windows.Forms.Label SelectedItemCostLabel;
        private System.Windows.Forms.TextBox SelectedItemCostTextBox;
        private System.Windows.Forms.Label SelectedItemNameLabel;
        private System.Windows.Forms.TextBox SelectedItemNameTextBox;
        private System.Windows.Forms.Label SelectedItemDescriptionLabel;
        private System.Windows.Forms.TextBox SelectedItemDescriptionTextBox;
        private System.Windows.Forms.ListBox ItemsListBox;
    }
}
