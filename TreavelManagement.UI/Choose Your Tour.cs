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

namespace TreavelManagement.UI
{
    public partial class Choose_Your_Tour : MetroForm
    {
        public Choose_Your_Tour()
        {
            InitializeComponent();
        }

        private void Choose_Your_Tour_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tavelagencyDataSet3.AddToursTable' table. You can move, or remove it, as needed.
            this.addToursTableTableAdapter.Fill(this.tavelagencyDataSet3.AddToursTable);

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroButtonBack_Click(object sender, EventArgs e)
        {
            CustomerControl cs = new CustomerControl();
            this.Hide();
            cs.ShowDialog();
        }

        private void metrobtnShow_Click(object sender, EventArgs e)
        {
            BussinessLogic.bll.AddTourLogic add = new BussinessLogic.bll.AddTourLogic();
            metroGrid1.DataSource = add.GetAllInformation();
        }
    }
}
