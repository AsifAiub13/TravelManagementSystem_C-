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
using System.Data.SqlClient;

namespace TreavelManagement.UI
{
    public partial class ViewTours : MetroForm


    {
        public ViewTours()
        {
            InitializeComponent();
        }

        private void ViewTours_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tavelagencyDataSet.AddToursTable' table. You can move, or remove it, as needed.
            this.addToursTableTableAdapter.Fill(this.tavelagencyDataSet.AddToursTable);

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            this.Hide();
            home.ShowDialog();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvViewTours_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void metroViewToursGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnShowTours_Click(object sender, EventArgs e)
        {
            BussinessLogic.bll.AddTourLogic add = new BussinessLogic.bll.AddTourLogic();
            metroViewToursGrid.DataSource = add.GetAllInformation();
        }
    }
}
