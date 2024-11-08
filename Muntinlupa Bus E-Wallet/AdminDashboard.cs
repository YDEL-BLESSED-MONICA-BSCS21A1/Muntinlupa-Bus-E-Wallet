using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muntinlupa_Bus_E_Wallet
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult i = MessageBox.Show("Are you sure you want to Close the Application?", "Information.", MessageBoxButtons.YesNo);
            if (i == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UserManagementNav_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            UserManagement form = new UserManagement();
            form.TopLevel = false;
            panel2.Controls.Add(form);
            form.Show();
        }
    }
}
