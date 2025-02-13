using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        Type[] Models = new Type[]
        {
            typeof(Model.Color),
            typeof(Model.EducationForm),
            typeof(Model.Genre),
            typeof(Model.Season),
            typeof(Model.SmartphoneManufactures),
            typeof(Model.Weekday)
        };

        public MainForm()
        {
            InitializeComponent();
      
            this.listBoxEnums.Items.AddRange(Models.Select(e => e.Name).ToArray());
            this.listBoxEnums.SelectedIndex = 0;
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {

        }

        private void buttonSeason_Click(object sender, EventArgs e)
        {

        }

        private void listBoxEnumsValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxEnumsValues.SelectedIndex == -1)
            {
                return;
            }

            this.textBoxIntValue.Text = this.listBoxEnumsValues.SelectedIndex.ToString();
        }

        private void listBoxEnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEnums.SelectedIndex == -1)
            {
                return;
            }

            this.listBoxEnumsValues.Items.Clear();

            this.listBoxEnumsValues.Items.AddRange(Models[this.listBoxEnums.SelectedIndex].GetEnumNames());
            this.listBoxEnumsValues.SelectedIndex = 0;

            this.textBoxIntValue.Text = "0";
        }

        private void textBoxIntValue_TextChanged(object sender, EventArgs e)
        {
            int selectedIndex;

            if (this.textBoxIntValue.Text == "")
            {
                return;
            }

            if (!int.TryParse(this.textBoxIntValue.Text, out selectedIndex)) {
                MessageBox.Show("В поле \"Int value\" можно вводить лишь натуральные числа (включая ноль).");
                return;
            }

            this.listBoxEnumsValues.SelectedIndex = selectedIndex >= this.listBoxEnumsValues.Items.Count ? this.listBoxEnumsValues.Items.Count - 1 : selectedIndex;
        }
    }
}
