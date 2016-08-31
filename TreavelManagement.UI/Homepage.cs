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
using TreavelManagement.UI.UC;

namespace TreavelManagement.UI
{
    public partial class Homepage : MetroForm
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            CustomerRegistration customerReg = new CustomerRegistration();
            this.Hide();
            customerReg.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogIn login = new btnLogIn();
            this.Hide();
            login.ShowDialog();
            if (!pnlmain.Controls.Contains(ucLogin.Instance))
            {
                pnlmain.Controls.Add(ucLogin.Instance);
                ucLogin.Instance.Dock = DockStyle.Fill;
                ucLogin.Instance.BringToFront();
            }
            else
            {
                ucLogin.Instance.BringToFront();
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            HomeHelp homehelp = new HomeHelp();
            homehelp.ShowDialog();
            homehelp.Dispose();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ViewTours view = new ViewTours();
            this.Hide();
            view.ShowDialog();
        }

        private void btnHomeSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHomeContactinfo_Click(object sender, EventArgs e)
        {
           
        }
    }
}
