namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTabs
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
            this.components = new System.ComponentModel.Container();
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.OrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectedOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedOrderItemsLabel = new System.Windows.Forms.Label();
            this.SelectedOrderItemsListView = new System.Windows.Forms.ListView();
            this.SelectedOrderAmountInfoLabel = new System.Windows.Forms.Label();
            this.SelectedOrderAmountLabel = new System.Windows.Forms.Label();
            this.SelectedOrderStatusLabel = new System.Windows.Forms.Label();
            this.SelectedrderCreatedAtLabel = new System.Windows.Forms.Label();
            this.SelectedOrderIdLabel = new System.Windows.Forms.Label();
            this.SelectedOrderStatusComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedOrderCreatedAtTtextBox = new System.Windows.Forms.TextBox();
            this.SelectedOrderIdTextBox = new System.Windows.Forms.TextBox();
            this.addressControl = new ObjectOrientedPractics.View.Tabs.AddressControl();
            this.OrdersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderEntryBindingSource)).BeginInit();
            this.SelectedOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersGroupBox
            // 
            this.OrdersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersGroupBox.Controls.Add(this.OrdersDataGridView);
            this.OrdersGroupBox.Location = new System.Drawing.Point(0, 0);
            this.OrdersGroupBox.Name = "OrdersGroupBox";
            this.OrdersGroupBox.Size = new System.Drawing.Size(343, 494);
            this.OrdersGroupBox.TabIndex = 0;
            this.OrdersGroupBox.TabStop = false;
            this.OrdersGroupBox.Text = "Orders";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToResizeColumns = false;
            this.OrdersDataGridView.AllowUserToResizeRows = false;
            this.OrdersDataGridView.AutoGenerateColumns = false;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.CreatingDateColumn,
            this.FullnameColumn,
            this.AddressColumn,
            this.AmountColumn,
            this.StatusColumn});
            this.OrdersDataGridView.DataSource = this.orderEntryBindingSource;
            this.OrdersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersDataGridView.Location = new System.Drawing.Point(3, 16);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.Size = new System.Drawing.Size(337, 475);
            this.OrdersDataGridView.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // CreatingDateColumn
            // 
            this.CreatingDateColumn.DataPropertyName = "CreatingDate";
            this.CreatingDateColumn.HeaderText = "CreatingDate";
            this.CreatingDateColumn.Name = "CreatingDateColumn";
            this.CreatingDateColumn.ReadOnly = true;
            // 
            // FullnameColumn
            // 
            this.FullnameColumn.DataPropertyName = "Fullname";
            this.FullnameColumn.HeaderText = "Fullname";
            this.FullnameColumn.Name = "FullnameColumn";
            this.FullnameColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.DataPropertyName = "Address";
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "Amount";
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            this.StatusColumn.DataPropertyName = "Status";
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // orderEntryBindingSource
            // 
            this.orderEntryBindingSource.DataSource = typeof(ObjectOrientedPractics.Model.OrderEntry);
            // 
            // SelectedOrderGroupBox
            // 
            this.SelectedOrderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrderGroupBox.Controls.Add(this.SelectedOrderItemsLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.SelectedOrderItemsListView);
            this.SelectedOrderGroupBox.Controls.Add(this.SelectedOrderAmountInfoLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.SelectedOrderAmountLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.SelectedOrderStatusLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.SelectedrderCreatedAtLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.SelectedOrderIdLabel);
            this.SelectedOrderGroupBox.Controls.Add(this.SelectedOrderStatusComboBox);
            this.SelectedOrderGroupBox.Controls.Add(this.SelectedOrderCreatedAtTtextBox);
            this.SelectedOrderGroupBox.Controls.Add(this.SelectedOrderIdTextBox);
            this.SelectedOrderGroupBox.Controls.Add(this.addressControl);
            this.SelectedOrderGroupBox.Location = new System.Drawing.Point(349, 0);
            this.SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            this.SelectedOrderGroupBox.Size = new System.Drawing.Size(428, 494);
            this.SelectedOrderGroupBox.TabIndex = 1;
            this.SelectedOrderGroupBox.TabStop = false;
            this.SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // SelectedOrderItemsLabel
            // 
            this.SelectedOrderItemsLabel.AutoSize = true;
            this.SelectedOrderItemsLabel.Location = new System.Drawing.Point(3, 260);
            this.SelectedOrderItemsLabel.Name = "SelectedOrderItemsLabel";
            this.SelectedOrderItemsLabel.Size = new System.Drawing.Size(64, 13);
            this.SelectedOrderItemsLabel.TabIndex = 12;
            this.SelectedOrderItemsLabel.Text = "Order Items:";
            // 
            // SelectedOrderItemsListView
            // 
            this.SelectedOrderItemsListView.Enabled = false;
            this.SelectedOrderItemsListView.HideSelection = false;
            this.SelectedOrderItemsListView.Location = new System.Drawing.Point(6, 274);
            this.SelectedOrderItemsListView.Name = "SelectedOrderItemsListView";
            this.SelectedOrderItemsListView.Size = new System.Drawing.Size(416, 130);
            this.SelectedOrderItemsListView.TabIndex = 11;
            this.SelectedOrderItemsListView.UseCompatibleStateImageBehavior = false;
            // 
            // SelectedOrderAmountInfoLabel
            // 
            this.SelectedOrderAmountInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrderAmountInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderAmountInfoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectedOrderAmountInfoLabel.Location = new System.Drawing.Point(61, 439);
            this.SelectedOrderAmountInfoLabel.Name = "SelectedOrderAmountInfoLabel";
            this.SelectedOrderAmountInfoLabel.Size = new System.Drawing.Size(361, 20);
            this.SelectedOrderAmountInfoLabel.TabIndex = 10;
            this.SelectedOrderAmountInfoLabel.Text = "0";
            this.SelectedOrderAmountInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SelectedOrderAmountLabel
            // 
            this.SelectedOrderAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrderAmountLabel.AutoSize = true;
            this.SelectedOrderAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderAmountLabel.Location = new System.Drawing.Point(352, 419);
            this.SelectedOrderAmountLabel.Name = "SelectedOrderAmountLabel";
            this.SelectedOrderAmountLabel.Size = new System.Drawing.Size(76, 20);
            this.SelectedOrderAmountLabel.TabIndex = 9;
            this.SelectedOrderAmountLabel.Text = "Amount:";
            // 
            // SelectedOrderStatusLabel
            // 
            this.SelectedOrderStatusLabel.AutoSize = true;
            this.SelectedOrderStatusLabel.Location = new System.Drawing.Point(15, 84);
            this.SelectedOrderStatusLabel.Name = "SelectedOrderStatusLabel";
            this.SelectedOrderStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.SelectedOrderStatusLabel.TabIndex = 6;
            this.SelectedOrderStatusLabel.Text = "Status:";
            // 
            // SelectedrderCreatedAtLabel
            // 
            this.SelectedrderCreatedAtLabel.AutoSize = true;
            this.SelectedrderCreatedAtLabel.Location = new System.Drawing.Point(15, 56);
            this.SelectedrderCreatedAtLabel.Name = "SelectedrderCreatedAtLabel";
            this.SelectedrderCreatedAtLabel.Size = new System.Drawing.Size(47, 13);
            this.SelectedrderCreatedAtLabel.TabIndex = 5;
            this.SelectedrderCreatedAtLabel.Text = "Created:";
            // 
            // SelectedOrderIdLabel
            // 
            this.SelectedOrderIdLabel.AutoSize = true;
            this.SelectedOrderIdLabel.Location = new System.Drawing.Point(15, 27);
            this.SelectedOrderIdLabel.Name = "SelectedOrderIdLabel";
            this.SelectedOrderIdLabel.Size = new System.Drawing.Size(21, 13);
            this.SelectedOrderIdLabel.TabIndex = 4;
            this.SelectedOrderIdLabel.Text = "ID:";
            // 
            // SelectedOrderStatusComboBox
            // 
            this.SelectedOrderStatusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrderStatusComboBox.FormattingEnabled = true;
            this.SelectedOrderStatusComboBox.Items.AddRange(new object[] {
            "New",
            "Processing",
            "Assembly",
            "Sent",
            "Delivered",
            "Returned",
            "Abandoned"});
            this.SelectedOrderStatusComboBox.Location = new System.Drawing.Point(73, 81);
            this.SelectedOrderStatusComboBox.Name = "SelectedOrderStatusComboBox";
            this.SelectedOrderStatusComboBox.Size = new System.Drawing.Size(166, 21);
            this.SelectedOrderStatusComboBox.TabIndex = 3;
            // 
            // SelectedOrderCreatedAtTtextBox
            // 
            this.SelectedOrderCreatedAtTtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrderCreatedAtTtextBox.Location = new System.Drawing.Point(82, 53);
            this.SelectedOrderCreatedAtTtextBox.Name = "SelectedOrderCreatedAtTtextBox";
            this.SelectedOrderCreatedAtTtextBox.ReadOnly = true;
            this.SelectedOrderCreatedAtTtextBox.Size = new System.Drawing.Size(157, 20);
            this.SelectedOrderCreatedAtTtextBox.TabIndex = 2;
            // 
            // SelectedOrderIdTextBox
            // 
            this.SelectedOrderIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrderIdTextBox.Location = new System.Drawing.Point(58, 24);
            this.SelectedOrderIdTextBox.Name = "SelectedOrderIdTextBox";
            this.SelectedOrderIdTextBox.ReadOnly = true;
            this.SelectedOrderIdTextBox.Size = new System.Drawing.Size(181, 20);
            this.SelectedOrderIdTextBox.TabIndex = 1;
            // 
            // addressControl
            // 
            this.addressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressControl.Enabled = false;
            this.addressControl.Location = new System.Drawing.Point(6, 108);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(416, 149);
            this.addressControl.TabIndex = 0;
            // 
            // OrdersTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedOrderGroupBox);
            this.Controls.Add(this.OrdersGroupBox);
            this.Name = "OrdersTabs";
            this.Size = new System.Drawing.Size(780, 494);
            this.OrdersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderEntryBindingSource)).EndInit();
            this.SelectedOrderGroupBox.ResumeLayout(false);
            this.SelectedOrderGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public void InitializeListeners()
        {
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            SelectedOrderStatusComboBox.SelectedIndexChanged += SelectedOrderStatusComboBox_SelectedIndexChanged;
        }

        private System.Windows.Forms.GroupBox OrdersGroupBox;
        private System.Windows.Forms.GroupBox SelectedOrderGroupBox;
        private AddressControl addressControl;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.Label SelectedOrderIdLabel;
        private System.Windows.Forms.ComboBox SelectedOrderStatusComboBox;
        private System.Windows.Forms.TextBox SelectedOrderCreatedAtTtextBox;
        private System.Windows.Forms.TextBox SelectedOrderIdTextBox;
        private System.Windows.Forms.Label SelectedOrderStatusLabel;
        private System.Windows.Forms.Label SelectedrderCreatedAtLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderEntryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatingDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.Label SelectedOrderItemsLabel;
        private System.Windows.Forms.ListView SelectedOrderItemsListView;
        private System.Windows.Forms.Label SelectedOrderAmountInfoLabel;
        private System.Windows.Forms.Label SelectedOrderAmountLabel;
    }
}
