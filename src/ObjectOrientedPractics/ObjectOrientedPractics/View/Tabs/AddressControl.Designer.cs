using System.Runtime.InteropServices;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class AddressControl
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
            this.AddressGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressBuildingTextBox = new System.Windows.Forms.TextBox();
            this.AddressApartmentTextBox = new System.Windows.Forms.TextBox();
            this.AddressCityTextBox = new System.Windows.Forms.TextBox();
            this.AddressStreetTextBox = new System.Windows.Forms.TextBox();
            this.AddressApartmentLabel = new System.Windows.Forms.Label();
            this.AddressBuildingLabel = new System.Windows.Forms.Label();
            this.AddressCityLabel = new System.Windows.Forms.Label();
            this.AddressStreetLabel = new System.Windows.Forms.Label();
            this.AddressCountryTextBox = new System.Windows.Forms.TextBox();
            this.AddressCountryLabel = new System.Windows.Forms.Label();
            this.AddressIndexTextBox = new System.Windows.Forms.TextBox();
            this.AddressIndexLabel = new System.Windows.Forms.Label();
            this.AddressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressGroupBox
            // 
            this.AddressGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressGroupBox.Controls.Add(this.AddressBuildingTextBox);
            this.AddressGroupBox.Controls.Add(this.AddressApartmentTextBox);
            this.AddressGroupBox.Controls.Add(this.AddressCityTextBox);
            this.AddressGroupBox.Controls.Add(this.AddressStreetTextBox);
            this.AddressGroupBox.Controls.Add(this.AddressApartmentLabel);
            this.AddressGroupBox.Controls.Add(this.AddressBuildingLabel);
            this.AddressGroupBox.Controls.Add(this.AddressCityLabel);
            this.AddressGroupBox.Controls.Add(this.AddressStreetLabel);
            this.AddressGroupBox.Controls.Add(this.AddressCountryTextBox);
            this.AddressGroupBox.Controls.Add(this.AddressCountryLabel);
            this.AddressGroupBox.Controls.Add(this.AddressIndexTextBox);
            this.AddressGroupBox.Controls.Add(this.AddressIndexLabel);
            this.AddressGroupBox.Location = new System.Drawing.Point(0, 0);
            this.AddressGroupBox.Name = "AddressGroupBox";
            this.AddressGroupBox.Size = new System.Drawing.Size(411, 149);
            this.AddressGroupBox.TabIndex = 0;
            this.AddressGroupBox.TabStop = false;
            this.AddressGroupBox.Text = "Delivery Address";
            // 
            // AddressBuildingTextBox
            // 
            this.AddressBuildingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBuildingTextBox.Location = new System.Drawing.Point(72, 120);
            this.AddressBuildingTextBox.MaxLength = 10;
            this.AddressBuildingTextBox.Name = "AddressBuildingTextBox";
            this.AddressBuildingTextBox.Size = new System.Drawing.Size(140, 20);
            this.AddressBuildingTextBox.TabIndex = 11;
            // 
            // AddressApartmentTextBox
            // 
            this.AddressApartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressApartmentTextBox.Location = new System.Drawing.Point(282, 120);
            this.AddressApartmentTextBox.MaxLength = 10;
            this.AddressApartmentTextBox.Name = "AddressApartmentTextBox";
            this.AddressApartmentTextBox.Size = new System.Drawing.Size(120, 20);
            this.AddressApartmentTextBox.TabIndex = 10;
            // 
            // AddressCityTextBox
            // 
            this.AddressCityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressCityTextBox.Location = new System.Drawing.Point(251, 59);
            this.AddressCityTextBox.MaxLength = 50;
            this.AddressCityTextBox.Name = "AddressCityTextBox";
            this.AddressCityTextBox.Size = new System.Drawing.Size(151, 20);
            this.AddressCityTextBox.TabIndex = 9;
            // 
            // AddressStreetTextBox
            // 
            this.AddressStreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressStreetTextBox.Location = new System.Drawing.Point(72, 90);
            this.AddressStreetTextBox.MaxLength = 100;
            this.AddressStreetTextBox.Name = "AddressStreetTextBox";
            this.AddressStreetTextBox.Size = new System.Drawing.Size(330, 20);
            this.AddressStreetTextBox.TabIndex = 8;
            // 
            // AddressApartmentLabel
            // 
            this.AddressApartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressApartmentLabel.AutoSize = true;
            this.AddressApartmentLabel.Location = new System.Drawing.Point(218, 123);
            this.AddressApartmentLabel.Name = "AddressApartmentLabel";
            this.AddressApartmentLabel.Size = new System.Drawing.Size(58, 13);
            this.AddressApartmentLabel.TabIndex = 7;
            this.AddressApartmentLabel.Text = "Apartment:";
            // 
            // AddressBuildingLabel
            // 
            this.AddressBuildingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressBuildingLabel.AutoSize = true;
            this.AddressBuildingLabel.Location = new System.Drawing.Point(6, 123);
            this.AddressBuildingLabel.Name = "AddressBuildingLabel";
            this.AddressBuildingLabel.Size = new System.Drawing.Size(47, 13);
            this.AddressBuildingLabel.TabIndex = 6;
            this.AddressBuildingLabel.Text = "Building:";
            // 
            // AddressCityLabel
            // 
            this.AddressCityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressCityLabel.AutoSize = true;
            this.AddressCityLabel.Location = new System.Drawing.Point(218, 62);
            this.AddressCityLabel.Name = "AddressCityLabel";
            this.AddressCityLabel.Size = new System.Drawing.Size(27, 13);
            this.AddressCityLabel.TabIndex = 5;
            this.AddressCityLabel.Text = "City:";
            // 
            // AddressStreetLabel
            // 
            this.AddressStreetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressStreetLabel.AutoSize = true;
            this.AddressStreetLabel.Location = new System.Drawing.Point(6, 93);
            this.AddressStreetLabel.Name = "AddressStreetLabel";
            this.AddressStreetLabel.Size = new System.Drawing.Size(38, 13);
            this.AddressStreetLabel.TabIndex = 4;
            this.AddressStreetLabel.Text = "Street:";
            // 
            // AddressCountryTextBox
            // 
            this.AddressCountryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressCountryTextBox.Location = new System.Drawing.Point(72, 59);
            this.AddressCountryTextBox.MaxLength = 50;
            this.AddressCountryTextBox.Name = "AddressCountryTextBox";
            this.AddressCountryTextBox.Size = new System.Drawing.Size(140, 20);
            this.AddressCountryTextBox.TabIndex = 3;
            // 
            // AddressCountryLabel
            // 
            this.AddressCountryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressCountryLabel.AutoSize = true;
            this.AddressCountryLabel.Location = new System.Drawing.Point(6, 62);
            this.AddressCountryLabel.Name = "AddressCountryLabel";
            this.AddressCountryLabel.Size = new System.Drawing.Size(46, 13);
            this.AddressCountryLabel.TabIndex = 2;
            this.AddressCountryLabel.Text = "Country:";
            // 
            // AddressIndexTextBox
            // 
            this.AddressIndexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressIndexTextBox.Location = new System.Drawing.Point(72, 28);
            this.AddressIndexTextBox.MaxLength = 6;
            this.AddressIndexTextBox.Name = "AddressIndexTextBox";
            this.AddressIndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddressIndexTextBox.TabIndex = 1;
            // 
            // AddressIndexLabel
            // 
            this.AddressIndexLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressIndexLabel.AutoSize = true;
            this.AddressIndexLabel.Location = new System.Drawing.Point(6, 31);
            this.AddressIndexLabel.Name = "AddressIndexLabel";
            this.AddressIndexLabel.Size = new System.Drawing.Size(60, 13);
            this.AddressIndexLabel.TabIndex = 0;
            this.AddressIndexLabel.Text = "Post Index:";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressGroupBox);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(411, 149);
            this.AddressGroupBox.ResumeLayout(false);
            this.AddressGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void InitializeListeners()
        {
            this.AddressIndexTextBox.TextChanged += AddressIndexTextBox_TextChanged;
            this.AddressCountryTextBox.TextChanged += AddressCountryTextBox_TextChanged;
            this.AddressCityTextBox.TextChanged += AddressCityTextBox_TextChanged;
            this.AddressStreetTextBox.TextChanged += AddressStreetTextBox_TextChanged;
            this.AddressBuildingTextBox.TextChanged += AddressBuildingTextBox_TextChanged;
            this.AddressApartmentTextBox.TextChanged += AddressApartmentTextBox_TextChanged;
        }

        private System.Windows.Forms.GroupBox AddressGroupBox;
        private System.Windows.Forms.TextBox AddressBuildingTextBox;
        private System.Windows.Forms.TextBox AddressApartmentTextBox;
        private System.Windows.Forms.TextBox AddressCityTextBox;
        private System.Windows.Forms.TextBox AddressStreetTextBox;
        private System.Windows.Forms.Label AddressApartmentLabel;
        private System.Windows.Forms.Label AddressBuildingLabel;
        private System.Windows.Forms.Label AddressCityLabel;
        private System.Windows.Forms.Label AddressStreetLabel;
        private System.Windows.Forms.TextBox AddressCountryTextBox;
        private System.Windows.Forms.Label AddressCountryLabel;
        private System.Windows.Forms.TextBox AddressIndexTextBox;
        private System.Windows.Forms.Label AddressIndexLabel;
    }
}
