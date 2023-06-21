namespace AutonomiaMainSystem
{
    partial class DetailServiceAdd
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
            System.Windows.Forms.Label detail_service_car_service_IDLabel;
            System.Windows.Forms.Label detail_service_nameLabel;
            System.Windows.Forms.Label detail_service_minimum_priceLabel;
            this.aUTONOMIADataSet = new AutonomiaMainSystem.AUTONOMIADataSet();
            this.detail_servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detail_servicesTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.detail_servicesTableAdapter();
            this.tableAdapterManager = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.TableAdapterManager();
            this.car_servicesTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.car_servicesTableAdapter();
            this.detail_service_nameTextBox = new System.Windows.Forms.TextBox();
            this.detail_service_minimum_priceTextBox = new System.Windows.Forms.TextBox();
            this.detail_service_car_service_IDComboBox = new System.Windows.Forms.ComboBox();
            this.carservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnOpenMainMenu = new System.Windows.Forms.Button();
            detail_service_car_service_IDLabel = new System.Windows.Forms.Label();
            detail_service_nameLabel = new System.Windows.Forms.Label();
            detail_service_minimum_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aUTONOMIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // detail_service_car_service_IDLabel
            // 
            detail_service_car_service_IDLabel.AutoSize = true;
            detail_service_car_service_IDLabel.BackColor = System.Drawing.Color.DarkOrange;
            detail_service_car_service_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            detail_service_car_service_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            detail_service_car_service_IDLabel.Location = new System.Drawing.Point(6, 64);
            detail_service_car_service_IDLabel.Name = "detail_service_car_service_IDLabel";
            detail_service_car_service_IDLabel.Size = new System.Drawing.Size(201, 25);
            detail_service_car_service_IDLabel.TabIndex = 1;
            detail_service_car_service_IDLabel.Text = "Выберите тип ремонта";
            // 
            // detail_service_nameLabel
            // 
            detail_service_nameLabel.AutoSize = true;
            detail_service_nameLabel.BackColor = System.Drawing.Color.DarkOrange;
            detail_service_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            detail_service_nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            detail_service_nameLabel.Location = new System.Drawing.Point(6, 103);
            detail_service_nameLabel.Name = "detail_service_nameLabel";
            detail_service_nameLabel.Size = new System.Drawing.Size(259, 25);
            detail_service_nameLabel.TabIndex = 3;
            detail_service_nameLabel.Text = "Введите наименование работ";
            // 
            // detail_service_minimum_priceLabel
            // 
            detail_service_minimum_priceLabel.AutoSize = true;
            detail_service_minimum_priceLabel.BackColor = System.Drawing.Color.DarkOrange;
            detail_service_minimum_priceLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            detail_service_minimum_priceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            detail_service_minimum_priceLabel.Location = new System.Drawing.Point(6, 142);
            detail_service_minimum_priceLabel.Name = "detail_service_minimum_priceLabel";
            detail_service_minimum_priceLabel.Size = new System.Drawing.Size(245, 25);
            detail_service_minimum_priceLabel.TabIndex = 5;
            detail_service_minimum_priceLabel.Text = "Введите минимальную цену";
            // 
            // aUTONOMIADataSet
            // 
            this.aUTONOMIADataSet.DataSetName = "AUTONOMIADataSet";
            this.aUTONOMIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detail_servicesBindingSource
            // 
            this.detail_servicesBindingSource.DataMember = "detail_services";
            this.detail_servicesBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // detail_servicesTableAdapter
            // 
            this.detail_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.auto_ordersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.car_brandsTableAdapter = null;
            this.tableAdapterManager.car_modelsTableAdapter = null;
            this.tableAdapterManager.car_servicesTableAdapter = this.car_servicesTableAdapter;
            this.tableAdapterManager.detail_servicesTableAdapter = this.detail_servicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // car_servicesTableAdapter
            // 
            this.car_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // detail_service_nameTextBox
            // 
            this.detail_service_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detail_servicesBindingSource, "detail_service_name", true));
            this.detail_service_nameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detail_service_nameTextBox.Location = new System.Drawing.Point(268, 100);
            this.detail_service_nameTextBox.Name = "detail_service_nameTextBox";
            this.detail_service_nameTextBox.Size = new System.Drawing.Size(495, 33);
            this.detail_service_nameTextBox.TabIndex = 4;
            // 
            // detail_service_minimum_priceTextBox
            // 
            this.detail_service_minimum_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detail_servicesBindingSource, "detail_service_minimum_price", true));
            this.detail_service_minimum_priceTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detail_service_minimum_priceTextBox.Location = new System.Drawing.Point(257, 139);
            this.detail_service_minimum_priceTextBox.Name = "detail_service_minimum_priceTextBox";
            this.detail_service_minimum_priceTextBox.Size = new System.Drawing.Size(506, 33);
            this.detail_service_minimum_priceTextBox.TabIndex = 6;
            // 
            // detail_service_car_service_IDComboBox
            // 
            this.detail_service_car_service_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detail_servicesBindingSource, "detail_service_car_service_ID", true));
            this.detail_service_car_service_IDComboBox.DataSource = this.carservicesBindingSource;
            this.detail_service_car_service_IDComboBox.DisplayMember = "car_service_name";
            this.detail_service_car_service_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detail_service_car_service_IDComboBox.FormattingEnabled = true;
            this.detail_service_car_service_IDComboBox.Location = new System.Drawing.Point(213, 61);
            this.detail_service_car_service_IDComboBox.Name = "detail_service_car_service_IDComboBox";
            this.detail_service_car_service_IDComboBox.Size = new System.Drawing.Size(550, 33);
            this.detail_service_car_service_IDComboBox.TabIndex = 7;
            this.detail_service_car_service_IDComboBox.ValueMember = "car_service_ID";
            // 
            // carservicesBindingSource
            // 
            this.carservicesBindingSource.DataMember = "car_services";
            this.carservicesBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(4, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(582, 42);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Добавление нового наименования работ";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveNew.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveNew.Location = new System.Drawing.Point(11, 178);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(752, 58);
            this.btnSaveNew.TabIndex = 9;
            this.btnSaveNew.Text = "Добавить";
            this.btnSaveNew.UseVisualStyleBackColor = false;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnOpenMainMenu
            // 
            this.btnOpenMainMenu.BackColor = System.Drawing.Color.Gray;
            this.btnOpenMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenMainMenu.Location = new System.Drawing.Point(597, 11);
            this.btnOpenMainMenu.Name = "btnOpenMainMenu";
            this.btnOpenMainMenu.Size = new System.Drawing.Size(166, 40);
            this.btnOpenMainMenu.TabIndex = 10;
            this.btnOpenMainMenu.Text = "Назад в главное меню";
            this.btnOpenMainMenu.UseVisualStyleBackColor = false;
            this.btnOpenMainMenu.Click += new System.EventHandler(this.btnOpenMainMenu_Click);
            // 
            // DetailServiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(775, 243);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpenMainMenu);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.detail_service_car_service_IDComboBox);
            this.Controls.Add(detail_service_minimum_priceLabel);
            this.Controls.Add(this.detail_service_minimum_priceTextBox);
            this.Controls.Add(detail_service_nameLabel);
            this.Controls.Add(this.detail_service_nameTextBox);
            this.Controls.Add(detail_service_car_service_IDLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DetailServiceAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СИСТЕМА \"АВТОНОМИЯ\"";
            this.Load += new System.EventHandler(this.DetailServiceAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUTONOMIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detail_servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carservicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AUTONOMIADataSet aUTONOMIADataSet;
        private System.Windows.Forms.BindingSource detail_servicesBindingSource;
        private AUTONOMIADataSetTableAdapters.detail_servicesTableAdapter detail_servicesTableAdapter;
        private AUTONOMIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox detail_service_nameTextBox;
        private System.Windows.Forms.TextBox detail_service_minimum_priceTextBox;
        private AUTONOMIADataSetTableAdapters.car_servicesTableAdapter car_servicesTableAdapter;
        private System.Windows.Forms.ComboBox detail_service_car_service_IDComboBox;
        private System.Windows.Forms.BindingSource carservicesBindingSource;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnOpenMainMenu;
    }
}