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
            this.CartCostLabel = new System.Windows.Forms.Label();
            this.CartAmountLabel = new System.Windows.Forms.Label();
            this.CartCreateOrderButton = new System.Windows.Forms.Button();
            this.CartClearButton = new System.Windows.Forms.Button();
            this.CartRemoveItemButton = new System.Windows.Forms.Button();
            this.CartTotalLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerDiscountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.CartDiscountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartItemsListBox
            // 
            this.CartItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CartItemsListBox.FormattingEnabled = true;
            this.CartItemsListBox.Location = new System.Drawing.Point(16, 28);
            this.CartItemsListBox.Name = "CartItemsListBox";
            this.CartItemsListBox.Size = new System.Drawing.Size(271, 472);
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
            this.CartAddItemButton.Location = new System.Drawing.Point(16, 522);
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
            // CartCostLabel
            // 
            this.CartCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CartCostLabel.AutoSize = true;
            this.CartCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartCostLabel.Location = new System.Drawing.Point(609, 267);
            this.CartCostLabel.Name = "CartCostLabel";
            this.CartCostLabel.Size = new System.Drawing.Size(76, 20);
            this.CartCostLabel.TabIndex = 7;
            this.CartCostLabel.Text = "Amount:";
            // 
            // CartAmountLabel
            // 
            this.CartAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CartAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartAmountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CartAmountLabel.Location = new System.Drawing.Point(324, 287);
            this.CartAmountLabel.Name = "CartAmountLabel";
            this.CartAmountLabel.Size = new System.Drawing.Size(353, 20);
            this.CartAmountLabel.TabIndex = 8;
            this.CartAmountLabel.Text = "0";
            this.CartAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartCreateOrderButton
            // 
            this.CartCreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CartCreateOrderButton.Location = new System.Drawing.Point(315, 321);
            this.CartCreateOrderButton.Name = "CartCreateOrderButton";
            this.CartCreateOrderButton.Size = new System.Drawing.Size(84, 35);
            this.CartCreateOrderButton.TabIndex = 9;
            this.CartCreateOrderButton.Text = "Create order";
            this.CartCreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // CartClearButton
            // 
            this.CartClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CartClearButton.Location = new System.Drawing.Point(610, 321);
            this.CartClearButton.Name = "CartClearButton";
            this.CartClearButton.Size = new System.Drawing.Size(75, 35);
            this.CartClearButton.TabIndex = 10;
            this.CartClearButton.Text = "Clear cart";
            this.CartClearButton.UseVisualStyleBackColor = true;
            // 
            // CartRemoveItemButton
            // 
            this.CartRemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CartRemoveItemButton.Location = new System.Drawing.Point(518, 321);
            this.CartRemoveItemButton.Name = "CartRemoveItemButton";
            this.CartRemoveItemButton.Size = new System.Drawing.Size(86, 35);
            this.CartRemoveItemButton.TabIndex = 11;
            this.CartRemoveItemButton.Text = "Remove Item";
            this.CartRemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // CartTotalLabel
            // 
            this.CartTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CartTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartTotalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CartTotalLabel.Location = new System.Drawing.Point(324, 542);
            this.CartTotalLabel.Name = "CartTotalLabel";
            this.CartTotalLabel.Size = new System.Drawing.Size(353, 20);
            this.CartTotalLabel.TabIndex = 13;
            this.CartTotalLabel.Text = "0";
            this.CartTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(631, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CustomerDiscountsCheckedListBox);
            this.groupBox1.Controls.Add(this.CartDiscountLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(315, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 138);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discounts";
            // 
            // CustomerDiscountsCheckedListBox
            // 
            this.CustomerDiscountsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerDiscountsCheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.CustomerDiscountsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerDiscountsCheckedListBox.FormattingEnabled = true;
            this.CustomerDiscountsCheckedListBox.Location = new System.Drawing.Point(13, 19);
            this.CustomerDiscountsCheckedListBox.Name = "CustomerDiscountsCheckedListBox";
            this.CustomerDiscountsCheckedListBox.Size = new System.Drawing.Size(225, 105);
            this.CustomerDiscountsCheckedListBox.TabIndex = 18;
            // 
            // CartDiscountLabel
            // 
            this.CartDiscountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CartDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CartDiscountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CartDiscountLabel.Location = new System.Drawing.Point(231, 70);
            this.CartDiscountLabel.Name = "CartDiscountLabel";
            this.CartDiscountLabel.Size = new System.Drawing.Size(123, 20);
            this.CartDiscountLabel.TabIndex = 17;
            this.CartDiscountLabel.Text = "0";
            this.CartDiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(277, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Discount:";
            // 
            // CartsTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CartTotalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CartRemoveItemButton);
            this.Controls.Add(this.CartClearButton);
            this.Controls.Add(this.CartCreateOrderButton);
            this.Controls.Add(this.CartAmountLabel);
            this.Controls.Add(this.CartCostLabel);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.CartCustomerComboBox);
            this.Controls.Add(this.CartCustomerLabel);
            this.Controls.Add(this.CartAddItemButton);
            this.Controls.Add(this.CartItemsLabel);
            this.Controls.Add(this.CartItemsListBox);
            this.Name = "CartsTabs";
            this.Size = new System.Drawing.Size(700, 580);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label CartCostLabel;
        private System.Windows.Forms.Label CartAmountLabel;
        private System.Windows.Forms.Button CartCreateOrderButton;
        private System.Windows.Forms.Button CartClearButton;
        private System.Windows.Forms.Button CartRemoveItemButton;
        private System.Windows.Forms.Label CartTotalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox CustomerDiscountsCheckedListBox;
        private System.Windows.Forms.Label CartDiscountLabel;
        private System.Windows.Forms.Label label3;
    }
}
