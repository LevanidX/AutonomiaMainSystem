using System;
using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    public partial class DetailServiceAdd : Form
    {
        TableManagement tableManagement = new TableManagement();
        ApplicationNavigation applicationNavigation = new ApplicationNavigation();

        public DetailServiceAdd()
        {
            InitializeComponent();
        }

        private void DetailServiceAdd_Load(object sender, EventArgs e)
        {
            tableManagement.AddNewItem(detail_servicesBindingSource);

            this.car_servicesTableAdapter.Fill(this.aUTONOMIADataSet.car_services);
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            tableManagement.SaveNewItem(this, detail_servicesBindingSource, tableAdapterManager, aUTONOMIADataSet);
        }

        private void btnOpenMainMenu_Click(object sender, EventArgs e)
        {
            applicationNavigation.OpenMainMenu(this);
        }
    }
}
