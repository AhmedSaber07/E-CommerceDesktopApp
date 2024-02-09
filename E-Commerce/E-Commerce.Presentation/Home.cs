using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Presentation
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SelectHomePage();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = pageRegister;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = pageLogin;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SelectHomePage();
        }
        private void SelectHomePage()
        {
            tabControl1.SelectedTab = pageHome;
        }

        private void btnECommerce_Click(object sender, EventArgs e)
        {
            SelectHomePage();
        }
    }
}
