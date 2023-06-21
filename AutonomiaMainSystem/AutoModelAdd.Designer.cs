namespace AutonomiaMainSystem
{
    partial class AutoModelAdd
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
            System.Windows.Forms.Label car_model_brand_IDLabel;
            System.Windows.Forms.Label car_model_nameLabel;
            this.aUTONOMIADataSet = new AutonomiaMainSystem.AUTONOMIADataSet();
            this.car_modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_modelsTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.car_modelsTableAdapter();
            this.tableAdapterManager = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.TableAdapterManager();
            this.car_brandsTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.car_brandsTableAdapter();
            this.car_model_nameTextBox = new System.Windows.Forms.TextBox();
            this.car_model_brand_IDComboBox = new System.Windows.Forms.ComboBox();
            this.carbrandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnOpenMainMenu = new System.Windows.Forms.Button();
            car_model_brand_IDLabel = new System.Windows.Forms.Label();
            car_model_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aUTONOMIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbrandsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // car_model_brand_IDLabel
            // 
            car_model_brand_IDLabel.AutoSize = true;
            car_model_brand_IDLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            car_model_brand_IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            car_model_brand_IDLabel.Location = new System.Drawing.Point(8, 61);
            car_model_brand_IDLabel.Name = "car_model_brand_IDLabel";
            car_model_brand_IDLabel.Size = new System.Drawing.Size(250, 25);
            car_model_brand_IDLabel.TabIndex = 1;
            car_model_brand_IDLabel.Text = "Выберите марку автомобиля";
            // 
            // car_model_nameLabel
            // 
            car_model_nameLabel.AutoSize = true;
            car_model_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            car_model_nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            car_model_nameLabel.Location = new System.Drawing.Point(8, 100);
            car_model_nameLabel.Name = "car_model_nameLabel";
            car_model_nameLabel.Size = new System.Drawing.Size(248, 25);
            car_model_nameLabel.TabIndex = 3;
            car_model_nameLabel.Text = "Введите модель автомобиля";
            // 
            // aUTONOMIADataSet
            // 
            this.aUTONOMIADataSet.DataSetName = "AUTONOMIADataSet";
            this.aUTONOMIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_modelsBindingSource
            // 
            this.car_modelsBindingSource.DataMember = "car_models";
            this.car_modelsBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // car_modelsTableAdapter
            // 
            this.car_modelsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.auto_ordersTableAdapter = null;
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
            // car_model_nameTextBox
            // 
            this.car_model_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_modelsBindingSource, "car_model_name", true));
            this.car_model_nameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_model_nameTextBox.Location = new System.Drawing.Point(262, 97);
            this.car_model_nameTextBox.Name = "car_model_nameTextBox";
            this.car_model_nameTextBox.Size = new System.Drawing.Size(471, 33);
            this.car_model_nameTextBox.TabIndex = 4;
            // 
            // car_model_brand_IDComboBox
            // 
            this.car_model_brand_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.car_modelsBindingSource, "car_model_brand_ID", true));
            this.car_model_brand_IDComboBox.DataSource = this.carbrandsBindingSource;
            this.car_model_brand_IDComboBox.DisplayMember = "car_brand_name";
            this.car_model_brand_IDComboBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_model_brand_IDComboBox.FormattingEnabled = true;
            this.car_model_brand_IDComboBox.Location = new System.Drawing.Point(264, 58);
            this.car_model_brand_IDComboBox.Name = "car_model_brand_IDComboBox";
            this.car_model_brand_IDComboBox.Size = new System.Drawing.Size(469, 33);
            this.car_model_brand_IDComboBox.TabIndex = 5;
            this.car_model_brand_IDComboBox.ValueMember = "car_brand_ID";
            // 
            // carbrandsBindingSource
            // 
            this.carbrandsBindingSource.DataMember = "car_brands";
            this.carbrandsBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Добавление новой модели автомобиля";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveNew.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveNew.Location = new System.Drawing.Point(12, 136);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(721, 66);
            this.btnSaveNew.TabIndex = 7;
            this.btnSaveNew.Text = "Добавить";
            this.btnSaveNew.UseVisualStyleBackColor = false;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnOpenMainMenu
            // 
            this.btnOpenMainMenu.BackColor = System.Drawing.Color.Gray;
            this.btnOpenMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenMainMenu.Location = new System.Drawing.Point(567, 11);
            this.btnOpenMainMenu.Name = "btnOpenMainMenu";
            this.btnOpenMainMenu.Size = new System.Drawing.Size(166, 40);
            this.btnOpenMainMenu.TabIndex = 8;
            this.btnOpenMainMenu.Text = "Назад в главное меню";
            this.btnOpenMainMenu.UseVisualStyleBackColor = false;
            this.btnOpenMainMenu.Click += new System.EventHandler(this.btnOpenMainMenu_Click);
            // 
            // AutoModelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(745, 210);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpenMainMenu);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.car_model_brand_IDComboBox);
            this.Controls.Add(car_model_nameLabel);
            this.Controls.Add(this.car_model_nameTextBox);
            this.Controls.Add(car_model_brand_IDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutoModelAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СИСТЕМА \"АВТОНОМИЯ\"";
            this.Load += new System.EventHandler(this.AutoModelAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUTONOMIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carbrandsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AUTONOMIADataSet aUTONOMIADataSet;
        private System.Windows.Forms.BindingSource car_modelsBindingSource;
        private AUTONOMIADataSetTableAdapters.car_modelsTableAdapter car_modelsTableAdapter;
        private AUTONOMIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AUTONOMIADataSetTableAdapters.car_brandsTableAdapter car_brandsTableAdapter;
        private System.Windows.Forms.TextBox car_model_nameTextBox;
        private System.Windows.Forms.ComboBox car_model_brand_IDComboBox;
        private System.Windows.Forms.BindingSource carbrandsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnOpenMainMenu;
    }
}