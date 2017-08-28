using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    public class Item
    {
        /* Item class:
         * An item in the shopping list
         * */

        // Private data members
        private int id;
        private int categoryId;
        private string name;

        // Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

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

        // Constructors
        public Item()
        {
            // Default constructor: creates invalid Item
            id = -1;
            categoryId = -1;
            name = null;
        }

        public Item(string itemName)
        {
            // Sets the name of the item
            // TODO: set up auto id numbering
            name = itemName;
        }

        public Item(int tempId, string itemName, int catId)
        {
            // For temp use
            id = tempId;
            name = itemName;
            categoryId = catId;
        }
    }
}
