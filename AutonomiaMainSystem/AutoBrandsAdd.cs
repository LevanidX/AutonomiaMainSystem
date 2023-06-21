using System;
using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    public partial class AutoBrandsAdd : Form
    {
        TableManagement tableManagement = new TableManagement();
        ApplicationNavigation applicationNavigation = new ApplicationNavigation();

        public AutoBrandsAdd()
        {
            InitializeComponent();
        }

        private void AutoBrandsAdd_Load(object sender, EventArgs e)
        {
            tableManagement.AddNewItem(car_brandsBindingSource);
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            tableManagement.SaveNewItem(this, car_brandsBindingSource, tableAdapterManager, aUTONOMIADataSet);
        }

        private void btnOpenMainMenu_Click(object sender, EventArgs e)
        {
            applicationNavigation.OpenMainMenu(this);
        }
    }
}
