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
using MetroFramework;
using ClassLibrary1;
using BussinessLogic.bll;
namespace TreavelManagement.UI
{
    public partial class CustomerControl : MetroForm
    {
        public CustomerControl()
        {
            InitializeComponent();
            metroTextBox1.PasswordChar = '*';
            metroTextBox1.MaxLength = 80;
        }

        private void CustomerControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tavelagencyDataSet2.AddToursTable' table. You can move, or remove it, as needed.
            this.addToursTableTableAdapter.Fill(this.tavelagencyDataSet2.AddToursTable);
            // TODO: This line of code loads data into the 'tavelagencyDataSet1.custregTable' table. You can move, or remove it, as needed.
            this.custregTableTableAdapter.Fill(this.tavelagencyDataSet1.custregTable);

        }

        private void btncustLogout_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            this.Hide();
            home.ShowDialog();
        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnShowTours_Click(object sender, EventArgs e)
        {
            Choose_Your_Tour choose = new Choose_Your_Tour();
            this.Hide();
            choose.ShowDialog();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnShowMyInfo_Click(object sender, EventArgs e)
        {
           
            
            
            
        }

        private void txtexp_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            BussinessLogic.bll.CustomerInfoLogic add = new BussinessLogic.bll.CustomerInfoLogic();
            metroGrid1.DataSource = add.GetInfo(metrotxtBox.Text);
            CustomerInfoLogic cs2 = new CustomerInfoLogic();
            if (cs2.Check1(metroTextBox1.Text))
            {
                MetroMessageBox.Show(this, "OK", "Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong password!!","Password",MessageBoxButtons.OK,MessageBoxIcon.Error);

                
            }


            


            
        }

        private void btncustoffer_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroGridShowTours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metrotxtBox_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonShowTours_Click(object sender, EventArgs e)
        {
            BussinessLogic.bll.AddTourLogic add = new BussinessLogic.bll.AddTourLogic();
            metroGrid2.DataSource = add.AddTour(metroComboBox1.Text);
        }

        private void metroButtonConfirm_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Congratulation!! Sucessfully added!!! Happy Journey!!!!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
