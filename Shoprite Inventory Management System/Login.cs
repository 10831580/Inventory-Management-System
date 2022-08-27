using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoprite_Inventory_Management_System
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == false)
                txtPass.UseSystemPasswordChar = true;
            else
                txtPass.UseSystemPasswordChar = false;

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();

        }
    }
}
