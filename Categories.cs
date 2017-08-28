using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp
{
    public class Categories
    {
        /* Categories class:
         * A container of all the categories in the list
         * */

        // Private data members
        List<Category> list;


        // Properties
        public List<Category> CatList
        {
            get { return list; }
        }

        // Constructor
        public Categories()
        {
            // Default constructor
            list = new List<Category>();
        }

        // Methods
        public void AddCategory(Category newCat)
        {
            list.Add(newCat);
        }

        public int Quantity()
        {
            // Returns the number of categories in the collection
            return list.Count;
        }
    }
}
