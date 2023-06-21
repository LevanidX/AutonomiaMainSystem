using System;
using System.Windows.Forms;

namespace AutonomiaMainSystem
{
    public partial class ViewActiveOrders : Form
    {
        Order order = new Order();
        ApplicationNavigation applicationNavigation = new ApplicationNavigation();

        public ViewActiveOrders()
        {
            InitializeComponent();
        }

        private void ViewActiveOrders_Load(object sender, EventArgs e)
        {
            this.auto_orders_viewTableAdapter.Fill(this.aUTONOMIADataSet.auto_orders_view);
            this.auto_orders_viewTableAdapter.Fill(this.aUTONOMIADataSet.auto_orders_view);
            this.auto_orders_viewTableAdapter.Fill(this.aUTONOMIADataSet.auto_orders_view);
            this.auto_orders_viewTableAdapter.Fill(this.aUTONOMIADataSet.auto_orders_view);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            order.Search(auto_orders_viewDataGridView, searchTextBox);
        }

        private void btnOpenMainMenu_Click(object sender, EventArgs e)
        {
            applicationNavigation.OpenMainMenu(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            order.Clear(auto_orders_viewDataGridView, auto_orders_viewBindingSource, searchTextBox);
        }
    }
}
