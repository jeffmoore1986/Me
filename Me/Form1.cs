using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Me
{
    public partial class Form1 : Form
    {
        List<String> _items = new List<string>();
        public Form1()
        {
            InitializeComponent();
            lstBox1.DataSource = _items;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // The Add button was clicked.
            _items.Add(txtBox1.Text);

            // Change the DataSource.
            lstBox1.DataSource = null;
            lstBox1.DataSource = _items;
          
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            // The Remove button was clicked.
            int selectedIndex = lstBox1.SelectedIndex;

            try
            {
                // Remove the item in the List.
                _items.RemoveAt(selectedIndex);
            }
            catch
            {
            }

            lstBox1.DataSource = null;
            lstBox1.DataSource = _items;
        }
    }
}
