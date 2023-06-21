using System;
using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    public partial class MainMenu : Form
    {
        ApplicationNavigation applicationNavigation = new ApplicationNavigation();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            MakingOrder makingOrder = new MakingOrder();
            applicationNavigation.OpenNewWindow(this, makingOrder);
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewActiveOrders viewActiveOrders = new ViewActiveOrders();
            applicationNavigation.OpenNewWindow(this, viewActiveOrders);
        }

        private void btnAddNewAutoBrand_Click(object sender, EventArgs e)
        {
            AutoBrandsAdd autoBrandsAdd = new AutoBrandsAdd();
            applicationNavigation.OpenNewWindow(this, autoBrandsAdd);
        }

        private void btnAddNewAutoModel_Click(object sender, EventArgs e)
        {
            AutoModelAdd autoModelAdd = new AutoModelAdd();
            applicationNavigation.OpenNewWindow(this, autoModelAdd);
        }

        private void btnAddNewAutoService_Click(object sender, EventArgs e)
        {
            AutoServiceAdd autoServiceAdd = new AutoServiceAdd();
            applicationNavigation.OpenNewWindow(this, autoServiceAdd);
        }

        private void btnAddNewDetailService_Click(object sender, EventArgs e)
        {
            DetailServiceAdd detailServiceAdd = new DetailServiceAdd();
            applicationNavigation.OpenNewWindow(this, detailServiceAdd);
        }

        private void btnApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
