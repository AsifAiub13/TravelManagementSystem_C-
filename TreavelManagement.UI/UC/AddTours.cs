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
using MetroFramework;


namespace TreavelManagement.UI
{
    public partial class pageAddTours : MetroForm
    {
        public pageAddTours()
        {
            InitializeComponent();
        }

        private void AddTours_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AdminControl admincontrol = new AdminControl();
            this.Hide();
            admincontrol.ShowDialog();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTourLogic confirmTour = new AddTourLogic();
            AddToursTable objaddtourstable = new AddToursTable();
            if (!string.IsNullOrEmpty(txtAddTours.Text) &&
                !string.IsNullOrEmpty(txtAddHotel.Text) &&
                !string.IsNullOrEmpty(txtHotelprice.Text) &&
                !string.IsNullOrEmpty(txtLocation.Text) &&
                !string.IsNullOrEmpty(txtDestination.Text) &&
                !string.IsNullOrEmpty(txtTransportcost.Text))
            {
                var addtours = txtAddTours.Text.Trim();
                var addhotel = txtAddHotel.Text.Trim();
                var hotelprice = txtHotelprice.Text.Trim();
                var location = txtLocation.Text.Trim();
                var destination = txtDestination.Text.Trim();
                var transportcost = txtTransportcost.Text.Trim();

                objaddtourstable.AddTour = addtours;
                objaddtourstable.AddHotel = addhotel;
                objaddtourstable.AddHotelCost = hotelprice;
                objaddtourstable.AddLocation = location;
                objaddtourstable.AddDestination = destination;
                objaddtourstable.Selecttransport = CmbTransport.Text;
                objaddtourstable.AddTransportCost = transportcost;

                confirmTour.AddTour(objaddtourstable);
                



                MetroMessageBox.Show(this, "Saved");

            }
            else
            {
                MetroMessageBox.Show(this, "You Need To FillUp All Field");

            }


        }
    }
}
