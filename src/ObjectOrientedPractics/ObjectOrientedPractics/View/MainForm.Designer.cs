using ObjectOrientedPractics.Model;
using System.Runtime.CompilerServices;

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
            this.MainFormTabPage2 = new System.Windows.Forms.TabPage();
            this.MainFormTabPage3 = new System.Windows.Forms.TabPage();
            this.MainFormTabPage4 = new System.Windows.Forms.TabPage();
            this.itemsTabs1 = new ObjectOrientedPractics.View.Tabs.ItemsTabs();
            this.customersTabs1 = new ObjectOrientedPractics.View.Tabs.CustomersTabs();
            this.cartsTabs1 = new ObjectOrientedPractics.View.Tabs.CartsTabs();
            this.ordersTabs1 = new ObjectOrientedPractics.View.Tabs.OrdersTabs();
            this.MainFormTabControl.SuspendLayout();
            this.MainFormTabPage1.SuspendLayout();
            this.MainFormTabPage2.SuspendLayout();
            this.MainFormTabPage3.SuspendLayout();
            this.MainFormTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTabControl
            // 
            this.MainFormTabControl.Controls.Add(this.MainFormTabPage1);
            this.MainFormTabControl.Controls.Add(this.MainFormTabPage2);
            this.MainFormTabControl.Controls.Add(this.MainFormTabPage3);
            this.MainFormTabControl.Controls.Add(this.MainFormTabPage4);
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
            // MainFormTabPage3
            // 
            this.MainFormTabPage3.Controls.Add(this.cartsTabs1);
            this.MainFormTabPage3.Location = new System.Drawing.Point(4, 22);
            this.MainFormTabPage3.Name = "MainFormTabPage3";
            this.MainFormTabPage3.Size = new System.Drawing.Size(976, 599);
            this.MainFormTabPage3.TabIndex = 2;
            this.MainFormTabPage3.Text = "Carts";
            this.MainFormTabPage3.UseVisualStyleBackColor = true;
            // 
            // MainFormTabPage4
            // 
            this.MainFormTabPage4.Controls.Add(this.ordersTabs1);
            this.MainFormTabPage4.Location = new System.Drawing.Point(4, 22);
            this.MainFormTabPage4.Name = "MainFormTabPage4";
            this.MainFormTabPage4.Size = new System.Drawing.Size(976, 599);
            this.MainFormTabPage4.TabIndex = 3;
            this.MainFormTabPage4.Text = "Orders";
            this.MainFormTabPage4.UseVisualStyleBackColor = true;
            // 
            // itemsTabs1
            // 
            this.itemsTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTabs1.Items = null;
            this.itemsTabs1.Location = new System.Drawing.Point(3, 3);
            this.itemsTabs1.Name = "itemsTabs1";
            this.itemsTabs1.Size = new System.Drawing.Size(970, 593);
            this.itemsTabs1.TabIndex = 0;
            // 
            // customersTabs1
            // 
            this.customersTabs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersTabs1.Customers = null;
            this.customersTabs1.Location = new System.Drawing.Point(8, 6);
            this.customersTabs1.Name = "customersTabs1";
            this.customersTabs1.Size = new System.Drawing.Size(960, 585);
            this.customersTabs1.TabIndex = 0;
            // 
            // cartsTabs1
            // 
            this.cartsTabs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartsTabs1.Location = new System.Drawing.Point(3, 3);
            this.cartsTabs1.Name = "cartsTabs1";
            this.cartsTabs1.Size = new System.Drawing.Size(970, 593);
            this.cartsTabs1.TabIndex = 0;
            // 
            // ordersTabs1
            // 
            this.ordersTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTabs1.Location = new System.Drawing.Point(0, 0);
            this.ordersTabs1.Name = "ordersTabs1";
            this.ordersTabs1.Size = new System.Drawing.Size(976, 599);
            this.ordersTabs1.TabIndex = 0;
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
            this.MainFormTabPage3.ResumeLayout(false);
            this.MainFormTabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void LinkStore()
        {
            customersTabs1.Customers = _store.Customers;
            cartsTabs1.Customers = _store.Customers;
            itemsTabs1.Items = _store.Items;
            cartsTabs1.Items = _store.Items;
            ordersTabs1.Customers = _store.Customers;
        }

        private void ReloadTabs()
        {
            itemsTabs1.ReloadItemsListBox();
            customersTabs1.ReloadCustomersListBox();
            cartsTabs1.LoadPage();
        }

        private void InitializeListeners()
        {
            MainFormTabControl.SelectedIndexChanged += MainFormTabControl_SelectedIndexChanged;
        }

        private System.Windows.Forms.TabControl MainFormTabControl;
        private System.Windows.Forms.TabPage MainFormTabPage1;
        private System.Windows.Forms.TabPage MainFormTabPage2;
        private View.Tabs.ItemsTabs itemsTabs1;
        private View.Tabs.CustomersTabs customersTabs1;
        private System.Windows.Forms.TabPage MainFormTabPage3;
        private View.Tabs.CartsTabs cartsTabs1;
        private System.Windows.Forms.TabPage MainFormTabPage4;
        private View.Tabs.OrdersTabs ordersTabs1;
    }
}

