using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using BussinessLogic.bll;
using DataAccess.dal;
using ClassLibrary1;

namespace TreavelManagement.UI
{
    public partial class btnLogIn : MetroForm
    {
        public btnLogIn()
        {
            InitializeComponent();
            txtLogInPassword.PasswordChar = '*';
            txtLogInPassword.MaxLength = 80;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnmainlogin_Click(object sender, EventArgs e)
        {
            LoginInfo login = new LoginInfo();
            custregTable CustLoginTable = new custregTable();
            //radio button.
            //CustomerUser Access Check.
            if (rbtnCustomer.Checked == true)
            {
                if (!string.IsNullOrEmpty(txtLoginUserName.Text) && !string.IsNullOrEmpty(txtLogInPassword.Text))
                {

                    if (login.CheckCustomeruser(txtLoginUserName.Text, txtLogInPassword.Text))
                    {
                        CustomerControl control = new CustomerControl();
                        MetroMessageBox.Show(this, "Welcome " + txtLoginUserName.Text,"Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Hide();
                        control.ShowDialog();
                       
                        
                    }

                    else
                    {
                        MetroMessageBox.Show(this, "Wrong CustomerPassword!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "You have to fill up all fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //AdminUSer Access Check
            else if(rbtnAdmin.Checked == true)
            {
                    if (!string.IsNullOrEmpty(txtLoginUserName.Text) && !string.IsNullOrEmpty(txtLogInPassword.Text))
                        {

                           if (login.CheckAdminUser(txtLoginUserName.Text, txtLogInPassword.Text))
                             {
                                 AdminControl objAdmin = new AdminControl();
                                 MetroMessageBox.Show(this, "Welcome Admin " + txtLoginUserName.Text, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                 this.Hide();  
                                objAdmin.ShowDialog();
                                 
                                 
                             }

                           else
                             {
                                 MetroMessageBox.Show(this, "Wrong AdminPassword!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                             }
                         }
                    else
                        {
                          MetroMessageBox.Show(this, "You have to fill up all fields!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
            }

            else 
            {
                MetroMessageBox.Show(this, "You have to select either Admin or Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
        

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginUserName_Click(object sender, EventArgs e)
        {

        }

        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAdmin.Checked == true)
            {
                rbtnCustomer.Hide();


            }
            
        }

        private void rbtnCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCustomer.Checked == true)
            {
                rbtnAdmin.Hide();
                

            }
        }

        private void btnlogBack_Click(object sender, EventArgs e)
        {
            Homepage customerReg = new Homepage();
            this.Hide();
            customerReg.ShowDialog();
        }

        private void txtLogInPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
        