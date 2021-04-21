using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            txtRegNr.Focus();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegNr.Text) || string.IsNullOrEmpty(txtMake.Text)) { 

                MessageBox.Show("Du måste fylla i alla rutor", "Felaktig inmatning");
            }
            else
            {
                ListViewItem item = CreateListViewItem(txtRegNr.Text, txtMake.Text, cbxForSale.Checked);
                lsvCars.Items.Add(item);
                ClearTextboxes();
                btnClear.Enable = true;

            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           if (lsvCars.SelectedItems.count > 0)
            {
                var item = lsvCars.selectedItems[0];
                lsvCars.Items.Remove(item);
                MessageBox.Show("Bilen med registeringsnummer " + item.Text + "är borttagen", "Borttag av bil");

            }
            else
            {
                MessageBox.Show("Ingen bil var markerad att tas bort ", "Borttag av bil");
            }
            btnClear.Enabled = (lsvCars.Items.Count > 0);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
