using System;
using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    public partial class AutoModelAdd : Form
    {
        TableManagement tableManagement = new TableManagement();
        ApplicationNavigation applicationNavigation = new ApplicationNavigation();

        public AutoModelAdd()
        {
            InitializeComponent();
        }

        private void AutoModelAdd_Load(object sender, EventArgs e)
        {
            tableManagement.AddNewItem(car_modelsBindingSource);

            this.car_brandsTableAdapter.Fill(this.aUTONOMIADataSet.car_brands);
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            tableManagement.SaveNewItem(this, car_modelsBindingSource, tableAdapterManager, aUTONOMIADataSet);
        }

        private void btnOpenMainMenu_Click(object sender, EventArgs e)
        {
            applicationNavigation.OpenMainMenu(this);
        }
    }
}
