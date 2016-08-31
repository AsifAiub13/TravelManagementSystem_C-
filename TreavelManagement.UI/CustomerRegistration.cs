using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using BussinessLogic.bll;
using ClassLibrary1;
using MetroFramework;


namespace TreavelManagement.UI
{
    public partial class CustomerRegistration : MetroForm
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CustomerInfoLogic confirm = new CustomerInfoLogic();
            custregTable CustregTable=new custregTable();
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtFirstName.Text)&&
                !string.IsNullOrEmpty(txtLastName.Text) && !string.IsNullOrEmpty(txtLastName.Text)&&!string.IsNullOrEmpty(txtPassword.Text)&&
            !string.IsNullOrEmpty(txtConfirmPass.Text)&&!string.IsNullOrEmpty(txtEmail.Text)&&
            !string.IsNullOrEmpty(txtAddress.Text) && !string.IsNullOrEmpty(txtAge.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
            
            var username=txtUsername.Text.Trim();
            var firstname=txtFirstName.Text.Trim();
            var lastname=txtLastName.Text.Trim();
            var password=txtPassword.Text.Trim();
            var Confirmpass=txtConfirmPass.Text.Trim();
            var email=txtEmail.Text.Trim();
            var address=txtAddress.Text.Trim();
            var age=txtAge.Text.Trim();
            var phonenum = txtPhoneNumber.Text.Trim();

            CustregTable.firstname=firstname;
            CustregTable.lastname=lastname;
            CustregTable.username=username;
            CustregTable.password = password;
            CustregTable.confirmpassword=Confirmpass;
                if (password == Confirmpass)
                    {
                        CustregTable.email = email;
                        CustregTable.address = address;
                        CustregTable.age = Convert.ToInt32(age);
                        CustregTable.phonenumber = Convert.ToInt32(phonenum);

                        confirm.AddCustomer(CustregTable);

                        MetroMessageBox.Show(this, "Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
               else
                    {
                        MetroMessageBox.Show(this, "Ooops!!!Password Missmatch!!Please Re-Check your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            

            }
            
            else
            {
                MetroMessageBox.Show(this, "You Need To FillUp All Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
          }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPass_Click(object sender, EventArgs e)
        {

        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Homepage customerReg = new Homepage();
            this.Hide();
            customerReg.ShowDialog();
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
