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
        public ShoppingListForm()
        {
            InitializeComponent();

            
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            // Displays the About box in a modal dialog
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }
    }
}
