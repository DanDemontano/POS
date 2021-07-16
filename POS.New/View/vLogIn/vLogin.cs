using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace POS.New.View.vLogIn
{
    public partial class vLogin : Telerik.WinControls.UI.RadForm
    {
        public vLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        void Login()
        {
            if (txtUsername.Text == "admin" && txtPass.Text == "12345")
            {
                MessageBox.Show("Correct");
                vMainMenu vMainMenu = new vMainMenu();
                this.Hide();
                vMainMenu.Show();
            }

            else
            {
                MessageBox.Show("Incorrect");
            }  
        }
    }
}
