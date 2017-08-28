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
    public partial class ShoppingListForm : Form
    {
        static public Categories categories;

        public ShoppingListForm()
        {
            InitializeComponent();

            // Initialize the app with new items to showcase a demo
            // What should happen here is that the app would load
            // the data from an XML or JSON file.
            Category beverages = new Category(0, "Beverages");
            Category fruit = new Category(1, "Fruit");
            Category vegetables = new Category(2, "Vegetables");
            Category frozen = new Category(3, "Frozen Foods");
            categories = new Categories();
            beverages.AddItem(0, "Coke");
            beverages.AddItem(1, "Diet Coke");
            beverages.AddItem(2, "Captain Morgan");
            beverages.AddItem(3, "OJ");
            beverages.AddItem(4, "Vodka");
            fruit.AddItem(0, "Apple");
            fruit.AddItem(1, "Grapes");
            fruit.AddItem(2, "Orange");
            fruit.AddItem(3, "Pomegranate");
            fruit.AddItem(4, "Watermelon");
            fruit.AddItem(5, "Pear");
            fruit.AddItem(6, "Lemon");
            fruit.AddItem(7, "Lime");
            fruit.AddItem(8, "Strawberry");
            vegetables.AddItem(0, "Carrot");
            vegetables.AddItem(1, "Celery");
            vegetables.AddItem(2, "Lettuce");
            frozen.AddItem(0, "Hash Browns");
            frozen.AddItem(1, "Hot Pockets");
            frozen.AddItem(2, "Frozen Pizza");
            categories.AddCategory(beverages);
            categories.AddCategory(fruit);
            categories.AddCategory(vegetables);
            categories.AddCategory(frozen);

            // Remove items from the sample design
            panelMasterList.Controls.Remove(label2);
            panelMasterList.Controls.Remove(label3);
            panelMasterList.Controls.Remove(label4);
            panelMasterList.Controls.Remove(listBox1);
            panelMasterList.Controls.Remove(listBox2);
            panelMasterList.Controls.Remove(listBox3);
            panelShopTrip.Controls.Remove(label6);
            panelShopTrip.Controls.Remove(label7);
            panelShopTrip.Controls.Remove(label8);
            panelShopTrip.Controls.Remove(listBox4);
            panelShopTrip.Controls.Remove(listBox5);
            panelShopTrip.Controls.Remove(listBox6);

            // Dynamically add the labels and listboxes to the
            // Master List tab panel
            beverages.AddCatToPanel(panelMasterList);
            fruit.AddCatToPanel(panelMasterList);
            vegetables.AddCatToPanel(panelMasterList);
            frozen.AddCatToPanel(panelMasterList);

            // Clear the text in the status label on the Master List tab
            labelStatus.Text = "";
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Displays the About box in a modal dialog
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Displays the Add Item dialog
            AddItemDialog addItemDialog = new AddItemDialog();
            addItemDialog.ShowDialog(this);

            // If we got something back, work with it.
            if (addItemDialog.CatSelected >= 0)
            {
                // Add the item name to the appropriate category
                categories.CatList[addItemDialog.CatSelected].AddItem(666, addItemDialog.NewItemName);
                labelStatus.Text = "Added " + addItemDialog.NewItemName + " to " + addItemDialog.CatName;
            }
            else if (addItemDialog.CatSelected == -1)
            {
                // This is a new category! We need to add it.
                Category newCat = new Category(categories.CatList.Count, addItemDialog.CatName);
                categories.CatList.Add(newCat);
                newCat.AddItem(0, addItemDialog.NewItemName);
                newCat.AddCatToPanel(panelMasterList);
                labelStatus.Text = "Added " + addItemDialog.NewItemName + " to new category " + addItemDialog.CatName;
            }
        }

        private void btnDeleteItems_Click(object sender, EventArgs e)
        {
            // TODO: NEED TO FIX THIS!!!
            // Get confirmation and then delete the select items
            var result = MessageBox.Show("Are you sure you want to delete the\nselected items from your Master List?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                // Time to delete some stuff!
                foreach (var category in categories.CatList)
                {
                    if (category.CatListBox.SelectedIndex >= 0)
                    {
                        // Something was selected here
                        for (int i = 0; i < category.CatListBox.SelectedIndices.Count; i++)
                        {
                            // Remove the item from the list box
                            category.CatListBox.Items.RemoveAt(category.CatListBox.SelectedIndices.IndexOf(i));
                            // Delete the item in the category too
                            category.RemoveItem(category.CatListBox.SelectedIndices.IndexOf(i));
                        }
                    }
                }
            }
        }
    }
}
