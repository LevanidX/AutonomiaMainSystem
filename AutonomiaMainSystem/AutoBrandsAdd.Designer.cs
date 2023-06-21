namespace AutonomiaMainSystem
{
    partial class AutoBrandsAdd
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
            System.Windows.Forms.Label car_brand_nameLabel;
            this.aUTONOMIADataSet = new AutonomiaMainSystem.AUTONOMIADataSet();
            this.car_brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_brandsTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.car_brandsTableAdapter();
            this.tableAdapterManager = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.TableAdapterManager();
            this.car_brand_nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnOpenMainMenu = new System.Windows.Forms.Button();
            car_brand_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aUTONOMIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_brandsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // car_brand_nameLabel
            // 
            car_brand_nameLabel.AutoSize = true;
            car_brand_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            car_brand_nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            car_brand_nameLabel.Location = new System.Drawing.Point(7, 52);
            car_brand_nameLabel.Name = "car_brand_nameLabel";
            car_brand_nameLabel.Size = new System.Drawing.Size(293, 25);
            car_brand_nameLabel.TabIndex = 1;
            car_brand_nameLabel.Text = "Наименование марки автомобиля";
            // 
            // aUTONOMIADataSet
            // 
            this.aUTONOMIADataSet.DataSetName = "AUTONOMIADataSet";
            this.aUTONOMIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_brandsBindingSource
            // 
            this.car_brandsBindingSource.DataMember = "car_brands";
            this.car_brandsBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // car_brandsTableAdapter
            // 
            this.car_brandsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.auto_ordersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.car_brandsTableAdapter = this.car_brandsTableAdapter;
            this.tableAdapterManager.car_modelsTableAdapter = null;
            this.tableAdapterManager.car_servicesTableAdapter = null;
            this.tableAdapterManager.detail_servicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // car_brand_nameTextBox
            // 
            this.car_brand_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_brandsBindingSource, "car_brand_name", true));
            this.car_brand_nameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_brand_nameTextBox.Location = new System.Drawing.Point(306, 49);
            this.car_brand_nameTextBox.Name = "car_brand_nameTextBox";
            this.car_brand_nameTextBox.Size = new System.Drawing.Size(410, 33);
            this.car_brand_nameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавление новой марки автомобиля";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveNew.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveNew.Location = new System.Drawing.Point(12, 88);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(705, 66);
            this.btnSaveNew.TabIndex = 3;
            this.btnSaveNew.Text = "Добавить";
            this.btnSaveNew.UseVisualStyleBackColor = false;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnOpenMainMenu
            // 
            this.btnOpenMainMenu.BackColor = System.Drawing.Color.Gray;
            this.btnOpenMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenMainMenu.Location = new System.Drawing.Point(550, 3);
            this.btnOpenMainMenu.Name = "btnOpenMainMenu";
            this.btnOpenMainMenu.Size = new System.Drawing.Size(166, 40);
            this.btnOpenMainMenu.TabIndex = 6;
            this.btnOpenMainMenu.Text = "Назад в главное меню";
            this.btnOpenMainMenu.UseVisualStyleBackColor = false;
            this.btnOpenMainMenu.Click += new System.EventHandler(this.btnOpenMainMenu_Click);
            // 
            // AutoBrandsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(729, 159);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpenMainMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(car_brand_nameLabel);
            this.Controls.Add(this.car_brand_nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutoBrandsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СИСТЕМА \"АВТОНОМИЯ\"";
            this.Load += new System.EventHandler(this.AutoBrandsAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUTONOMIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_brandsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AUTONOMIADataSet aUTONOMIADataSet;
        private System.Windows.Forms.BindingSource car_brandsBindingSource;
        private AUTONOMIADataSetTableAdapters.car_brandsTableAdapter car_brandsTableAdapter;
        private AUTONOMIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox car_brand_nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnOpenMainMenu;
    }
}