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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void btnPreviousForm_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
