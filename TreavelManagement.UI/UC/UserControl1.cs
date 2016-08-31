using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreavelManagement.UI.UC
{
    public partial class ucLogin : UserControl
    {
        private static ucLogin _instance;
        public static ucLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLogin();
                return _instance;
            }
        }
        public ucLogin()
        {
            InitializeComponent();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        
        }
    }
}
