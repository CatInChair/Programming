    namespace ObjectOrientedPractics
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
            this.MainFormTabControl = new System.Windows.Forms.TabControl();
            this.MainFormTabPage1 = new System.Windows.Forms.TabPage();
            this.itemsTabs1 = new ObjectOrientedPractics.View.Tabs.ItemsTabs();
            this.MainFormTabPage2 = new System.Windows.Forms.TabPage();
            this.customersTabs1 = new ObjectOrientedPractics.View.Tabs.CustomersTabs();
            this.MainFormTabControl.SuspendLayout();
            this.MainFormTabPage1.SuspendLayout();
            this.MainFormTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTabControl
            // 
            this.MainFormTabControl.Controls.Add(this.MainFormTabPage1);
            this.MainFormTabControl.Controls.Add(this.MainFormTabPage2);
            this.MainFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainFormTabControl.Name = "MainFormTabControl";
            this.MainFormTabControl.SelectedIndex = 0;
            this.MainFormTabControl.Size = new System.Drawing.Size(984, 625);
            this.MainFormTabControl.TabIndex = 0;
            // 
            // MainFormTabPage1
            // 
            this.MainFormTabPage1.Controls.Add(this.itemsTabs1);
            this.MainFormTabPage1.Location = new System.Drawing.Point(4, 22);
            this.MainFormTabPage1.Name = "MainFormTabPage1";
            this.MainFormTabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.MainFormTabPage1.Size = new System.Drawing.Size(976, 599);
            this.MainFormTabPage1.TabIndex = 0;
            this.MainFormTabPage1.Text = "Items";
            this.MainFormTabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTabs1
            // 
            this.itemsTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTabs1.Location = new System.Drawing.Point(3, 3);
            this.itemsTabs1.Name = "itemsTabs1";
            this.itemsTabs1.Size = new System.Drawing.Size(970, 593);
            this.itemsTabs1.TabIndex = 0;
            // 
            // MainFormTabPage2
            // 
            this.MainFormTabPage2.Controls.Add(this.customersTabs1);
            this.MainFormTabPage2.Location = new System.Drawing.Point(4, 22);
            this.MainFormTabPage2.Name = "MainFormTabPage2";
            this.MainFormTabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.MainFormTabPage2.Size = new System.Drawing.Size(976, 599);
            this.MainFormTabPage2.TabIndex = 1;
            this.MainFormTabPage2.Text = "Customers";
            this.MainFormTabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTabs1
            // 
            this.customersTabs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersTabs1.Location = new System.Drawing.Point(8, 6);
            this.customersTabs1.Name = "customersTabs1";
            this.customersTabs1.Size = new System.Drawing.Size(960, 585);
            this.customersTabs1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 625);
            this.Controls.Add(this.MainFormTabControl);
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.MainFormTabControl.ResumeLayout(false);
            this.MainFormTabPage1.ResumeLayout(false);
            this.MainFormTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void LinkStore()
        {
            _store.Items = itemsTabs1.Items;
            _store.Customers = customersTabs1.Customers;
        }

        #endregion

        private System.Windows.Forms.TabControl MainFormTabControl;
        private System.Windows.Forms.TabPage MainFormTabPage1;
        private System.Windows.Forms.TabPage MainFormTabPage2;
        private View.Tabs.ItemsTabs itemsTabs1;
        private View.Tabs.CustomersTabs customersTabs1;
    }
}

