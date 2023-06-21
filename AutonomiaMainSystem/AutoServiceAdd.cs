using System;
using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    public partial class AutoServiceAdd : Form
    {
        ApplicationNavigation applicationNavigation = new ApplicationNavigation();
        TableManagement tableManagement = new TableManagement();

        public AutoServiceAdd()
        {
            InitializeComponent();
        }

        private void AutoServiceAdd_Load(object sender, EventArgs e)
        {
            tableManagement.AddNewItem(car_servicesBindingSource);
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            tableManagement.SaveNewItem(this, car_servicesBindingSource, tableAdapterManager, aUTONOMIADataSet);
        }

        private void btnOpenMainMenu_Click(object sender, EventArgs e)
        {
            applicationNavigation.OpenMainMenu(this);
        }
    }
}
