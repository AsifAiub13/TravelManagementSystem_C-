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
using BussinessLogic.bll;
using ClassLibrary1;


namespace TreavelManagement.UI
{
    public partial class AdminControl : MetroForm
    {
        public AdminControl()
        {
            InitializeComponent();
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tavelagencyDataSet4.AddToursTable' table. You can move, or remove it, as needed.
            this.addToursTableTableAdapter.Fill(this.tavelagencyDataSet4.AddToursTable);

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            pageAddTours pageaddtours = new pageAddTours();
            this.Hide();
            pageaddtours.ShowDialog();
            
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            this.Hide();
            homepage.ShowDialog();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            BussinessLogic.bll.AddTourLogic add = new BussinessLogic.bll.AddTourLogic();
            metroGrid1.DataSource = add.GetAllInformation();
        }

        private void BtnAdminDelete_Click(object sender, EventArgs e)
        {
            AddTourLogic ad = new AddTourLogic();
            ad.deleteData();
        }

        private void btnAdminRefresh_Click(object sender, EventArgs e)
        {
            BussinessLogic.bll.AddTourLogic add = new BussinessLogic.bll.AddTourLogic();
            metroGrid1.DataSource = add.GetAllInformation();
        }
    }
}
