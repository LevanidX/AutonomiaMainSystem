namespace AutonomiaMainSystem
{
    partial class MakingOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label auto_order_car_brand_IDLabel;
            System.Windows.Forms.Label auto_order_car_model_IDLabel;
            System.Windows.Forms.Label auto_order_car_service_IDLabel;
            System.Windows.Forms.Label auto_order_detail_service_IDLabel;
            System.Windows.Forms.Label detail_service_minimum_priceLabel;
            System.Windows.Forms.Label auto_order_client_nameLabel;
            System.Windows.Forms.Label auto_order_client_phone_numberLabel;
            System.Windows.Forms.Label auto_order_priceLabel;
            this.aUTONOMIADataSet = new AutonomiaMainSystem.AUTONOMIADataSet();
            this.auto_ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auto_ordersTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.auto_ordersTableAdapter();
            this.tableAdapterManager = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.TableAdapterManager();
            this.car_brandsTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.car_brandsTableAdapter();
            this.car_modelsTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.car_modelsTableAdapter();
            this.carmodelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carbrandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_servicesTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.car_servicesTableAdapter();
            this.detail_servicesTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.detail_servicesTableAdapter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.auto_order_client_nameTextBox = new System.Windows.Forms.TextBox();
            this.auto_order_client_phone_numberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.auto_order_priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.auto_order_car_brand_IDComboBox = new System.Windows.Forms.ComboBox();
            this.auto_order_car_model_IDComboBox = new System.Windows.Forms.ComboBox();
            this.auto_order_car_service_IDComboBox = new System.Windows.Forms.ComboBox();
            this.auto_order_detail_service_IDComboBox = new System.Windows.Forms.ComboBox();
            this.btnOpenMainMenu = new System.Windows.Forms.Button();
            auto_order_car_brand_IDLabel = new System.Windows.Forms.Label();
            auto_order_car_model_IDLabel = new System.Windows.Forms.Label();
            auto_order_car_service_IDLabel = new System.Windows.Forms.Label();
            auto_order_detail_service_IDLabel = new System.Windows.Forms.Label();
            detail_service_minimum_priceLabel = new System.Windows.Forms.Label();
            auto_order_client_nameLabel = new System.Windows.Forms.Label();
            auto_order_client_phone_numberLabel = new System.Windows.Forms.Label();
            auto_order_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aUTONOMIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto_ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carmodelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbrandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailservicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // auto_order_car_brand_IDLabel
            // 
            auto_order_car_brand_IDLabel.AutoSize = true;
            auto_order_car_brand_IDLabel.BackColor = System.Drawing.Color.DarkOrange;
            auto_order_car_brand_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            auto_order_car_brand_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            auto_order_car_brand_IDLabel.Location = new System.Drawing.Point(16, 61);
            auto_order_car_brand_IDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            auto_order_car_brand_IDLabel.Name = "auto_order_car_brand_IDLabel";
            auto_order_car_brand_IDLabel.Size = new System.Drawing.Size(250, 25);
            auto_order_car_brand_IDLabel.TabIndex = 1;
            auto_order_car_brand_IDLabel.Text = "Выберите марку автомобиля";
            // 
            // auto_order_car_model_IDLabel
            // 
            auto_order_car_model_IDLabel.AutoSize = true;
            auto_order_car_model_IDLabel.BackColor = System.Drawing.Color.DarkOrange;
            auto_order_car_model_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            auto_order_car_model_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            auto_order_car_model_IDLabel.Location = new System.Drawing.Point(16, 131);
            auto_order_car_model_IDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            auto_order_car_model_IDLabel.Name = "auto_order_car_model_IDLabel";
            auto_order_car_model_IDLabel.Size = new System.Drawing.Size(261, 25);
            auto_order_car_model_IDLabel.TabIndex = 3;
            auto_order_car_model_IDLabel.Text = "Выберите модель автомобиля";
            // 
            // auto_order_car_service_IDLabel
            // 
            auto_order_car_service_IDLabel.AutoSize = true;
            auto_order_car_service_IDLabel.BackColor = System.Drawing.Color.DarkOrange;
            auto_order_car_service_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            auto_order_car_service_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            auto_order_car_service_IDLabel.Location = new System.Drawing.Point(356, 61);
            auto_order_car_service_IDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            auto_order_car_service_IDLabel.Name = "auto_order_car_service_IDLabel";
            auto_order_car_service_IDLabel.Size = new System.Drawing.Size(258, 25);
            auto_order_car_service_IDLabel.TabIndex = 5;
            auto_order_car_service_IDLabel.Text = "Выберите тип неисправности";
            // 
            // auto_order_detail_service_IDLabel
            // 
            auto_order_detail_service_IDLabel.AutoSize = true;
            auto_order_detail_service_IDLabel.BackColor = System.Drawing.Color.DarkOrange;
            auto_order_detail_service_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            auto_order_detail_service_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            auto_order_detail_service_IDLabel.Location = new System.Drawing.Point(356, 131);
            auto_order_detail_service_IDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            auto_order_detail_service_IDLabel.Name = "auto_order_detail_service_IDLabel";
            auto_order_detail_service_IDLabel.Size = new System.Drawing.Size(180, 25);
            auto_order_detail_service_IDLabel.TabIndex = 7;
            auto_order_detail_service_IDLabel.Text = "Выберите тип работ";
            // 
            // detail_service_minimum_priceLabel
            // 
            detail_service_minimum_priceLabel.AutoSize = true;
            detail_service_minimum_priceLabel.BackColor = System.Drawing.Color.DarkOrange;
            detail_service_minimum_priceLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            detail_service_minimum_priceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            detail_service_minimum_priceLabel.Location = new System.Drawing.Point(8, 318);
            detail_service_minimum_priceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            detail_service_minimum_priceLabel.Name = "detail_service_minimum_priceLabel";
            detail_service_minimum_priceLabel.Size = new System.Drawing.Size(340, 35);
            detail_service_minimum_priceLabel.TabIndex = 11;
            detail_service_minimum_priceLabel.Text = "Минимальная цена ремонта";
            // 
            // auto_order_client_nameLabel
            // 
            auto_order_client_nameLabel.AutoSize = true;
            auto_order_client_nameLabel.BackColor = System.Drawing.Color.DarkOrange;
            auto_order_client_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            auto_order_client_nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            auto_order_client_nameLabel.Location = new System.Drawing.Point(16, 215);
            auto_order_client_nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            auto_order_client_nameLabel.Name = "auto_order_client_nameLabel";
            auto_order_client_nameLabel.Size = new System.Drawing.Size(117, 25);
            auto_order_client_nameLabel.TabIndex = 13;
            auto_order_client_nameLabel.Text = "Имя клиента";
            // 
            // auto_order_client_phone_numberLabel
            // 
            auto_order_client_phone_numberLabel.AutoSize = true;
            auto_order_client_phone_numberLabel.BackColor = System.Drawing.Color.DarkOrange;
            auto_order_client_phone_numberLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            auto_order_client_phone_numberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            auto_order_client_phone_numberLabel.Location = new System.Drawing.Point(14, 260);
            auto_order_client_phone_numberLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            auto_order_client_phone_numberLabel.Name = "auto_order_client_phone_numberLabel";
            auto_order_client_phone_numberLabel.Size = new System.Drawing.Size(223, 25);
            auto_order_client_phone_numberLabel.TabIndex = 14;
            auto_order_client_phone_numberLabel.Text = "Номер телефона клиента";
            // 
            // auto_order_priceLabel
            // 
            auto_order_priceLabel.AutoSize = true;
            auto_order_priceLabel.BackColor = System.Drawing.Color.DarkOrange;
            auto_order_priceLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            auto_order_priceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            auto_order_priceLabel.Location = new System.Drawing.Point(447, 323);
            auto_order_priceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            auto_order_priceLabel.Name = "auto_order_priceLabel";
            auto_order_priceLabel.Size = new System.Drawing.Size(128, 25);
            auto_order_priceLabel.TabIndex = 16;
            auto_order_priceLabel.Text = "Цена ремонта";
            // 
            // aUTONOMIADataSet
            // 
            this.aUTONOMIADataSet.DataSetName = "AUTONOMIADataSet";
            this.aUTONOMIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auto_ordersBindingSource
            // 
            this.auto_ordersBindingSource.DataMember = "auto_orders";
            this.auto_ordersBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // auto_ordersTableAdapter
            // 
            this.auto_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.auto_ordersTableAdapter = this.auto_ordersTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.car_brandsTableAdapter = this.car_brandsTableAdapter;
            this.tableAdapterManager.car_modelsTableAdapter = this.car_modelsTableAdapter;
            this.tableAdapterManager.car_servicesTableAdapter = null;
            this.tableAdapterManager.detail_servicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // car_brandsTableAdapter
            // 
            this.car_brandsTableAdapter.ClearBeforeFill = true;
            // 
            // car_modelsTableAdapter
            // 
            this.car_modelsTableAdapter.ClearBeforeFill = true;
            // 
            // carmodelsBindingSource
            // 
            this.carmodelsBindingSource.DataMember = "car_models";
            this.carmodelsBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // carbrandsBindingSource
            // 
            this.carbrandsBindingSource.DataMember = "car_brands";
            this.carbrandsBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // carservicesBindingSource
            // 
            this.carservicesBindingSource.DataMember = "car_services";
            this.carservicesBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // detailservicesBindingSource
            // 
            this.detailservicesBindingSource.DataMember = "detail_services";
            this.detailservicesBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // car_servicesTableAdapter
            // 
            this.car_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // detail_servicesTableAdapter
            // 
            this.detail_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DarkOrange;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(14, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 42);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Оформление заказа на ремонт";
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMakeOrder.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeOrder.Location = new System.Drawing.Point(14, 363);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(748, 129);
            this.btnMakeOrder.TabIndex = 13;
            this.btnMakeOrder.Text = "Оформить заказ";
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // auto_order_client_nameTextBox
            // 
            this.auto_order_client_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auto_ordersBindingSource, "auto_order_client_name", true));
            this.auto_order_client_nameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_order_client_nameTextBox.Location = new System.Drawing.Point(143, 212);
            this.auto_order_client_nameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.auto_order_client_nameTextBox.Name = "auto_order_client_nameTextBox";
            this.auto_order_client_nameTextBox.Size = new System.Drawing.Size(619, 33);
            this.auto_order_client_nameTextBox.TabIndex = 14;
            // 
            // auto_order_client_phone_numberMaskedTextBox
            // 
            this.auto_order_client_phone_numberMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auto_ordersBindingSource, "auto_order_client_phone_number", true));
            this.auto_order_client_phone_numberMaskedTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_order_client_phone_numberMaskedTextBox.Location = new System.Drawing.Point(247, 257);
            this.auto_order_client_phone_numberMaskedTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.auto_order_client_phone_numberMaskedTextBox.Mask = "70000000000";
            this.auto_order_client_phone_numberMaskedTextBox.Name = "auto_order_client_phone_numberMaskedTextBox";
            this.auto_order_client_phone_numberMaskedTextBox.Size = new System.Drawing.Size(515, 33);
            this.auto_order_client_phone_numberMaskedTextBox.TabIndex = 15;
            // 
            // auto_order_priceTextBox
            // 
            this.auto_order_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auto_ordersBindingSource, "auto_order_price", true));
            this.auto_order_priceTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_order_priceTextBox.Location = new System.Drawing.Point(585, 318);
            this.auto_order_priceTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.auto_order_priceTextBox.Name = "auto_order_priceTextBox";
            this.auto_order_priceTextBox.Size = new System.Drawing.Size(177, 33);
            this.auto_order_priceTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detailservicesBindingSource, "detail_service_minimum_price", true));
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(358, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "00000";
            // 
            // auto_order_car_brand_IDComboBox
            // 
            this.auto_order_car_brand_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.auto_ordersBindingSource, "auto_order_car_brand_ID", true));
            this.auto_order_car_brand_IDComboBox.DataSource = this.carbrandsBindingSource;
            this.auto_order_car_brand_IDComboBox.DisplayMember = "car_brand_name";
            this.auto_order_car_brand_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_order_car_brand_IDComboBox.FormattingEnabled = true;
            this.auto_order_car_brand_IDComboBox.Location = new System.Drawing.Point(21, 92);
            this.auto_order_car_brand_IDComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.auto_order_car_brand_IDComboBox.Name = "auto_order_car_brand_IDComboBox";
            this.auto_order_car_brand_IDComboBox.Size = new System.Drawing.Size(286, 33);
            this.auto_order_car_brand_IDComboBox.TabIndex = 19;
            this.auto_order_car_brand_IDComboBox.ValueMember = "car_brand_ID";
            this.auto_order_car_brand_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.auto_order_car_brand_IDComboBox_SelectedIndexChanged);
            // 
            // auto_order_car_model_IDComboBox
            // 
            this.auto_order_car_model_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.auto_ordersBindingSource, "auto_order_car_model_ID", true));
            this.auto_order_car_model_IDComboBox.DataSource = this.carmodelsBindingSource;
            this.auto_order_car_model_IDComboBox.DisplayMember = "car_model_name";
            this.auto_order_car_model_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_order_car_model_IDComboBox.FormattingEnabled = true;
            this.auto_order_car_model_IDComboBox.Location = new System.Drawing.Point(21, 163);
            this.auto_order_car_model_IDComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.auto_order_car_model_IDComboBox.Name = "auto_order_car_model_IDComboBox";
            this.auto_order_car_model_IDComboBox.Size = new System.Drawing.Size(286, 33);
            this.auto_order_car_model_IDComboBox.TabIndex = 20;
            this.auto_order_car_model_IDComboBox.ValueMember = "car_model_ID";
            // 
            // auto_order_car_service_IDComboBox
            // 
            this.auto_order_car_service_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.auto_ordersBindingSource, "auto_order_car_service_ID", true));
            this.auto_order_car_service_IDComboBox.DataSource = this.carservicesBindingSource;
            this.auto_order_car_service_IDComboBox.DisplayMember = "car_service_name";
            this.auto_order_car_service_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_order_car_service_IDComboBox.FormattingEnabled = true;
            this.auto_order_car_service_IDComboBox.Location = new System.Drawing.Point(361, 92);
            this.auto_order_car_service_IDComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.auto_order_car_service_IDComboBox.Name = "auto_order_car_service_IDComboBox";
            this.auto_order_car_service_IDComboBox.Size = new System.Drawing.Size(401, 33);
            this.auto_order_car_service_IDComboBox.TabIndex = 21;
            this.auto_order_car_service_IDComboBox.ValueMember = "car_service_ID";
            this.auto_order_car_service_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.auto_order_car_service_IDComboBox_SelectedIndexChanged);
            // 
            // auto_order_detail_service_IDComboBox
            // 
            this.auto_order_detail_service_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.auto_ordersBindingSource, "auto_order_detail_service_ID", true));
            this.auto_order_detail_service_IDComboBox.DataSource = this.detailservicesBindingSource;
            this.auto_order_detail_service_IDComboBox.DisplayMember = "detail_service_name";
            this.auto_order_detail_service_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auto_order_detail_service_IDComboBox.FormattingEnabled = true;
            this.auto_order_detail_service_IDComboBox.Location = new System.Drawing.Point(361, 163);
            this.auto_order_detail_service_IDComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.auto_order_detail_service_IDComboBox.Name = "auto_order_detail_service_IDComboBox";
            this.auto_order_detail_service_IDComboBox.Size = new System.Drawing.Size(401, 33);
            this.auto_order_detail_service_IDComboBox.TabIndex = 22;
            this.auto_order_detail_service_IDComboBox.ValueMember = "detail_service_ID";
            // 
            // btnOpenMainMenu
            // 
            this.btnOpenMainMenu.BackColor = System.Drawing.Color.Gray;
            this.btnOpenMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenMainMenu.Location = new System.Drawing.Point(596, 11);
            this.btnOpenMainMenu.Name = "btnOpenMainMenu";
            this.btnOpenMainMenu.Size = new System.Drawing.Size(166, 40);
            this.btnOpenMainMenu.TabIndex = 23;
            this.btnOpenMainMenu.Text = "Назад в главное меню";
            this.btnOpenMainMenu.UseVisualStyleBackColor = false;
            this.btnOpenMainMenu.Click += new System.EventHandler(this.btnOpenMainMenu_Click);
            // 
            // MakingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(778, 496);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpenMainMenu);
            this.Controls.Add(this.auto_order_detail_service_IDComboBox);
            this.Controls.Add(this.auto_order_car_service_IDComboBox);
            this.Controls.Add(this.auto_order_car_model_IDComboBox);
            this.Controls.Add(this.auto_order_car_brand_IDComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(auto_order_priceLabel);
            this.Controls.Add(this.auto_order_priceTextBox);
            this.Controls.Add(this.auto_order_client_phone_numberMaskedTextBox);
            this.Controls.Add(auto_order_client_phone_numberLabel);
            this.Controls.Add(auto_order_client_nameLabel);
            this.Controls.Add(this.auto_order_client_nameTextBox);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(detail_service_minimum_priceLabel);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(auto_order_detail_service_IDLabel);
            this.Controls.Add(auto_order_car_service_IDLabel);
            this.Controls.Add(auto_order_car_model_IDLabel);
            this.Controls.Add(auto_order_car_brand_IDLabel);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MakingOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СИСТЕМА \"АВТОНОМИЯ\"";
            this.Load += new System.EventHandler(this.MakingOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUTONOMIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto_ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carmodelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbrandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailservicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AUTONOMIADataSet aUTONOMIADataSet;
        private System.Windows.Forms.BindingSource auto_ordersBindingSource;
        private AUTONOMIADataSetTableAdapters.auto_ordersTableAdapter auto_ordersTableAdapter;
        private AUTONOMIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AUTONOMIADataSetTableAdapters.car_brandsTableAdapter car_brandsTableAdapter;
        private System.Windows.Forms.BindingSource carbrandsBindingSource;
        private AUTONOMIADataSetTableAdapters.car_modelsTableAdapter car_modelsTableAdapter;
        private System.Windows.Forms.BindingSource carmodelsBindingSource;
        private System.Windows.Forms.BindingSource carservicesBindingSource;
        private AUTONOMIADataSetTableAdapters.car_servicesTableAdapter car_servicesTableAdapter;
        private System.Windows.Forms.BindingSource detailservicesBindingSource;
        private AUTONOMIADataSetTableAdapters.detail_servicesTableAdapter detail_servicesTableAdapter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.TextBox auto_order_client_nameTextBox;
        private System.Windows.Forms.MaskedTextBox auto_order_client_phone_numberMaskedTextBox;
        private System.Windows.Forms.TextBox auto_order_priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox auto_order_car_brand_IDComboBox;
        private System.Windows.Forms.ComboBox auto_order_car_model_IDComboBox;
        private System.Windows.Forms.ComboBox auto_order_car_service_IDComboBox;
        private System.Windows.Forms.ComboBox auto_order_detail_service_IDComboBox;
        private System.Windows.Forms.Button btnOpenMainMenu;
    }
}