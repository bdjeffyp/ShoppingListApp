using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListApp
{
    public class Category
    {
        /* Category class:
         * Container of Items
         * */

        // Private data members
        private int categoryId;
        private string name;
        private List<Item> list;
        private Label catLabel;
        private ListBox catListBox;


        // Constants
        private const int X_POS = 4;
        private const int LABEL_Y_SIZE = 21;
        private const int LISTBOX_Y_POS = 29;
        private const int LISTBOX_X_SIZE = 467;
        private const int LISTBOX_Y_SIZE = 130;
        private const int PADDING = 4;

        // Properties
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public ListBox CatListBox
        {
            get { return catListBox; }
            set { catListBox = value; }
        }

        public Label CatLabel
        {
            get { return catLabel; }
            set { catLabel = value; }
        }

        public List<Item> ItemList
        {
            get { return list; }
        }

        // Constructors
        public Category()
        {
            // Default constructor
            // Creates an invalid category
            categoryId = -1;
            name = null;
            list = null;
            catLabel = null;
            catListBox = null;
        }

        public Category(string catName)
        {
            // Sets the name of the category
            // TODO: Create automatic id's
            name = catName;
            list = new List<Item>();
            catLabel = new Label();
            catListBox = new ListBox();
        }

        public Category(int id, string catName)
        {
            // For temp use: allows setting id and name
            int labelY = (PADDING * (id + 1) + 1) + (LABEL_Y_SIZE * id) + (LISTBOX_Y_SIZE * id);
            int listboxY = (PADDING * (id + 1) + 1) + (LABEL_Y_SIZE * (id + 1)) + (LISTBOX_Y_SIZE * id);
            categoryId = id;
            name = catName;
            list = new List<Item>();
            catLabel = new Label();
            catListBox = new ListBox();
            catLabel.AutoSize = true;
            catLabel.Name = "lbl" + catName;
            catLabel.Text = catName;
            catLabel.Location = new System.Drawing.Point(X_POS, labelY);
            catListBox.Name = "listbox" + catName;
            catListBox.FormattingEnabled = true;
            catListBox.ItemHeight = 21;
            catListBox.Size = new System.Drawing.Size(LISTBOX_X_SIZE, LISTBOX_Y_SIZE);
            catListBox.Location = new System.Drawing.Point(X_POS, listboxY);
            catListBox.SelectionMode = SelectionMode.MultiExtended;
        }

        // Methods
        public void AddItem(int id, string itemName)
        {
            // Add an item to the category
            // TODO: This should auto assign id's.
            Item newItem = new Item(id, itemName, categoryId);
            list.Add(newItem);
            catListBox.Items.Add(newItem.Name);
        }

        public int RemoveItem(int id)
        {
            // Remove an item from the list based on the id
            foreach (var item in list)
            {
                if (item.Id == id)
                {
                    list.Remove(item);
                    return id;
                }
            }
            // Failure
            return -1;
        }

        public void AddCatToPanel(Panel panel)
        {
            // Dynamically adds the category to the specified panel
            panel.Controls.Add(catLabel);
            panel.Controls.Add(catListBox);
        }
    }
}
