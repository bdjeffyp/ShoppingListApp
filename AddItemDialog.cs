using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListApp
{
    public partial class AddItemDialog : Form
    {
        private int catSelected;
        private string newItemName;
        private string catName;

        public int CatSelected
        {
            get { return catSelected; }
            set { catSelected = value; }
        }

        public string NewItemName
        {
            get { return newItemName; }
            set { newItemName = value; }
        }

        public string CatName
        {
            get { return catName; }
        }

        public AddItemDialog()
        {
            InitializeComponent();

            // Populate the combo box with all of the categories
            for (int i = 0; i < ShoppingListForm.categories.Quantity(); i++)
            {
                comboCategory.Items.Add(ShoppingListForm.categories.CatList[i].Name);
            }

            // Set the default category
            comboCategory.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Set the class fields to error values
            catSelected = -666;
            newItemName = null;
            catName = null;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Set the class fields to the contents of the dialog and close it
            catSelected = comboCategory.SelectedIndex;
            newItemName = txtName.Text;
            catName = comboCategory.Text;
            // TODO: Need some sort of error handling here...
            Close();
        }
    }
}
