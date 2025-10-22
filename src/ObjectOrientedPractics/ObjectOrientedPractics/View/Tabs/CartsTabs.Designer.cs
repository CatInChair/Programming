namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTabs
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
            this.CartItemsListBox = new System.Windows.Forms.ListBox();
            this.CartItemsLabel = new System.Windows.Forms.Label();
            this.CartAddItemButton = new System.Windows.Forms.Button();
            this.CartCustomerLabel = new System.Windows.Forms.Label();
            this.CartCustomerComboBox = new System.Windows.Forms.ComboBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.CartAmountLabel = new System.Windows.Forms.Label();
            this.CartAmountInfoLabel = new System.Windows.Forms.Label();
            this.CartCreateOrderButton = new System.Windows.Forms.Button();
            this.CartClearButton = new System.Windows.Forms.Button();
            this.CartRemoveItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CartItemsListBox
            // 
            this.CartItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CartItemsListBox.FormattingEnabled = true;
            this.CartItemsListBox.Location = new System.Drawing.Point(16, 28);
            this.CartItemsListBox.Name = "CartItemsListBox";
            this.CartItemsListBox.Size = new System.Drawing.Size(271, 394);
            this.CartItemsListBox.TabIndex = 0;
            // 
            // CartItemsLabel
            // 
            this.CartItemsLabel.AutoSize = true;
            this.CartItemsLabel.Location = new System.Drawing.Point(13, 12);
            this.CartItemsLabel.Name = "CartItemsLabel";
            this.CartItemsLabel.Size = new System.Drawing.Size(32, 13);
            this.CartItemsLabel.TabIndex = 1;
            this.CartItemsLabel.Text = "Items";
            // 
            // CartAddItemButton
            // 
            this.CartAddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CartAddItemButton.Location = new System.Drawing.Point(16, 442);
            this.CartAddItemButton.Name = "CartAddItemButton";
            this.CartAddItemButton.Size = new System.Drawing.Size(108, 45);
            this.CartAddItemButton.TabIndex = 2;
            this.CartAddItemButton.Text = "Add to Cart";
            this.CartAddItemButton.UseVisualStyleBackColor = true;
            // 
            // CartCustomerLabel
            // 
            this.CartCustomerLabel.AutoSize = true;
            this.CartCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartCustomerLabel.Location = new System.Drawing.Point(312, 28);
            this.CartCustomerLabel.Name = "CartCustomerLabel";
            this.CartCustomerLabel.Size = new System.Drawing.Size(67, 13);
            this.CartCustomerLabel.TabIndex = 3;
            this.CartCustomerLabel.Text = "Customer: ";
            // 
            // CartCustomerComboBox
            // 
            this.CartCustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartCustomerComboBox.FormattingEnabled = true;
            this.CartCustomerComboBox.Location = new System.Drawing.Point(396, 25);
            this.CartCustomerComboBox.Name = "CartCustomerComboBox";
            this.CartCustomerComboBox.Size = new System.Drawing.Size(289, 21);
            this.CartCustomerComboBox.TabIndex = 4;
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(312, 74);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(29, 13);
            this.CartLabel.TabIndex = 5;
            this.CartLabel.Text = "Cart:";
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.Location = new System.Drawing.Point(315, 90);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(370, 173);
            this.CartListBox.TabIndex = 6;
            // 
            // CartAmountLabel
            // 
            this.CartAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CartAmountLabel.AutoSize = true;
            this.CartAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartAmountLabel.Location = new System.Drawing.Point(609, 266);
            this.CartAmountLabel.Name = "CartAmountLabel";
            this.CartAmountLabel.Size = new System.Drawing.Size(76, 20);
            this.CartAmountLabel.TabIndex = 7;
            this.CartAmountLabel.Text = "Amount:";
            // 
            // CartAmountInfoLabel
            // 
            this.CartAmountInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CartAmountInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartAmountInfoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CartAmountInfoLabel.Location = new System.Drawing.Point(315, 298);
            this.CartAmountInfoLabel.Name = "CartAmountInfoLabel";
            this.CartAmountInfoLabel.Size = new System.Drawing.Size(361, 20);
            this.CartAmountInfoLabel.TabIndex = 8;
            this.CartAmountInfoLabel.Text = "0";
            this.CartAmountInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartCreateOrderButton
            // 
            this.CartCreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CartCreateOrderButton.Location = new System.Drawing.Point(315, 343);
            this.CartCreateOrderButton.Name = "CartCreateOrderButton";
            this.CartCreateOrderButton.Size = new System.Drawing.Size(84, 35);
            this.CartCreateOrderButton.TabIndex = 9;
            this.CartCreateOrderButton.Text = "Create order";
            this.CartCreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // CartClearButton
            // 
            this.CartClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CartClearButton.Location = new System.Drawing.Point(610, 343);
            this.CartClearButton.Name = "CartClearButton";
            this.CartClearButton.Size = new System.Drawing.Size(75, 35);
            this.CartClearButton.TabIndex = 10;
            this.CartClearButton.Text = "Clear cart";
            this.CartClearButton.UseVisualStyleBackColor = true;
            // 
            // CartRemoveItemButton
            // 
            this.CartRemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CartRemoveItemButton.Location = new System.Drawing.Point(518, 343);
            this.CartRemoveItemButton.Name = "CartRemoveItemButton";
            this.CartRemoveItemButton.Size = new System.Drawing.Size(86, 35);
            this.CartRemoveItemButton.TabIndex = 11;
            this.CartRemoveItemButton.Text = "Remove Item";
            this.CartRemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // CartsTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartRemoveItemButton);
            this.Controls.Add(this.CartClearButton);
            this.Controls.Add(this.CartCreateOrderButton);
            this.Controls.Add(this.CartAmountInfoLabel);
            this.Controls.Add(this.CartAmountLabel);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.CartCustomerComboBox);
            this.Controls.Add(this.CartCustomerLabel);
            this.Controls.Add(this.CartAddItemButton);
            this.Controls.Add(this.CartItemsLabel);
            this.Controls.Add(this.CartItemsListBox);
            this.Name = "CartsTabs";
            this.Size = new System.Drawing.Size(700, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public void InitializeListeners()
        {
            CartCustomerComboBox.SelectedIndexChanged += CartCustomersComboBox_SelectedIndexChanged;
            CartAddItemButton.Click += CartAddItemButton_Click;
            CartRemoveItemButton.Click += CartRemoveItemButton_Click;
            CartCreateOrderButton.Click += CartCreateOrderButton_Click;
            CartClearButton.Click += CartClearButton_Click;
        }

        private System.Windows.Forms.ListBox CartItemsListBox;
        private System.Windows.Forms.Label CartItemsLabel;
        private System.Windows.Forms.Button CartAddItemButton;
        private System.Windows.Forms.Label CartCustomerLabel;
        private System.Windows.Forms.ComboBox CartCustomerComboBox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Label CartAmountLabel;
        private System.Windows.Forms.Label CartAmountInfoLabel;
        private System.Windows.Forms.Button CartCreateOrderButton;
        private System.Windows.Forms.Button CartClearButton;
        private System.Windows.Forms.Button CartRemoveItemButton;
    }
}
