using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class CategoryModal : Form
    {
        public Model.Enumerators.Category Category { get; set; }

        public CategoryModal()
        {
            InitializeComponent();
            InitializeListeners();
            
            foreach (string value in Enum.GetNames(typeof(Model.Enumerators.Category)))
            {
                comboBoxCategories.Items.Add(value);
            }
        }

        private void ButtonOK_Click(object sender, System.EventArgs e)
        {
            if (comboBoxCategories.SelectedIndex == -1)
            {
                MessageBox.Show("Select category in ComboBox before.");
                return;
            }

            Category = (Model.Enumerators.Category)comboBoxCategories.SelectedIndex;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
