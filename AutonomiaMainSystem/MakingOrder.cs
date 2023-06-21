using System;
using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    public partial class MakingOrder : Form
    {
        Order order = new Order();
        TableManagement tableManagement = new TableManagement();
        ApplicationNavigation applicationNavigation = new ApplicationNavigation();

        private string _selectedCarID;
        private string _selectedServiceID;

        private string _carBrandColumn = "car_model_brand_ID";
        private string _carServiceColumn = "detail_service_car_service_ID";

        public MakingOrder()
        {
            InitializeComponent();
        }

        private void MakingOrder_Load(object sender, EventArgs e)
        {
            auto_ordersBindingSource.AddNew();
            
            this.detail_servicesTableAdapter.Fill(this.aUTONOMIADataSet.detail_services);
            this.car_servicesTableAdapter.Fill(this.aUTONOMIADataSet.car_services);
            this.car_modelsTableAdapter.Fill(this.aUTONOMIADataSet.car_models);
            this.car_brandsTableAdapter.Fill(this.aUTONOMIADataSet.car_brands);

            order.UpdateField(auto_order_car_brand_IDComboBox, carmodelsBindingSource, _selectedCarID, _carBrandColumn);
            order.UpdateField(auto_order_car_service_IDComboBox, detailservicesBindingSource, _selectedServiceID, _carServiceColumn);
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            tableManagement.SaveNewItem(this, auto_ordersBindingSource, tableAdapterManager, aUTONOMIADataSet);
        }

        private void auto_order_car_brand_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            order.UpdateField(auto_order_car_brand_IDComboBox, carmodelsBindingSource, _selectedCarID, _carBrandColumn);
        }

        private void auto_order_car_service_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            order.UpdateField(auto_order_car_service_IDComboBox, detailservicesBindingSource, _selectedServiceID, _carServiceColumn);
        }

        private void btnOpenMainMenu_Click(object sender, EventArgs e)
        {
            applicationNavigation.OpenMainMenu(this);
        }
    }
}
