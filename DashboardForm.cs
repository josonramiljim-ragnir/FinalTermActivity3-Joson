using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACTIVITY3_JOSONN
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SignInForm login = new SignInForm();
            login.Show();
            this.Close();
        }
    }
}
