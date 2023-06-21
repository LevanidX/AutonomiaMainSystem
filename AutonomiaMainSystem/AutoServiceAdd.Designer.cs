namespace AutonomiaMainSystem
{
    partial class AutoServiceAdd
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
            System.Windows.Forms.Label car_service_nameLabel;
            this.aUTONOMIADataSet = new AutonomiaMainSystem.AUTONOMIADataSet();
            this.car_servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_servicesTableAdapter = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.car_servicesTableAdapter();
            this.tableAdapterManager = new AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.TableAdapterManager();
            this.car_service_nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnOpenMainMenu = new System.Windows.Forms.Button();
            car_service_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aUTONOMIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // car_service_nameLabel
            // 
            car_service_nameLabel.AutoSize = true;
            car_service_nameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            car_service_nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            car_service_nameLabel.Location = new System.Drawing.Point(7, 61);
            car_service_nameLabel.Name = "car_service_nameLabel";
            car_service_nameLabel.Size = new System.Drawing.Size(225, 25);
            car_service_nameLabel.TabIndex = 1;
            car_service_nameLabel.Text = "Введите новый тип работ";
            // 
            // aUTONOMIADataSet
            // 
            this.aUTONOMIADataSet.DataSetName = "AUTONOMIADataSet";
            this.aUTONOMIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_servicesBindingSource
            // 
            this.car_servicesBindingSource.DataMember = "car_services";
            this.car_servicesBindingSource.DataSource = this.aUTONOMIADataSet;
            // 
            // car_servicesTableAdapter
            // 
            this.car_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.auto_ordersTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.car_brandsTableAdapter = null;
            this.tableAdapterManager.car_modelsTableAdapter = null;
            this.tableAdapterManager.car_servicesTableAdapter = this.car_servicesTableAdapter;
            this.tableAdapterManager.detail_servicesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AutonomiaMainSystem.AUTONOMIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // car_service_nameTextBox
            // 
            this.car_service_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_servicesBindingSource, "car_service_name", true));
            this.car_service_nameTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.car_service_nameTextBox.Location = new System.Drawing.Point(238, 58);
            this.car_service_nameTextBox.Name = "car_service_nameTextBox";
            this.car_service_nameTextBox.Size = new System.Drawing.Size(381, 33);
            this.car_service_nameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавление нового типа работ";
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveNew.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveNew.Location = new System.Drawing.Point(9, 97);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(610, 61);
            this.btnSaveNew.TabIndex = 4;
            this.btnSaveNew.Text = "Добавить";
            this.btnSaveNew.UseVisualStyleBackColor = false;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnOpenMainMenu
            // 
            this.btnOpenMainMenu.BackColor = System.Drawing.Color.Gray;
            this.btnOpenMainMenu.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpenMainMenu.Location = new System.Drawing.Point(453, 11);
            this.btnOpenMainMenu.Name = "btnOpenMainMenu";
            this.btnOpenMainMenu.Size = new System.Drawing.Size(166, 40);
            this.btnOpenMainMenu.TabIndex = 5;
            this.btnOpenMainMenu.Text = "Назад в главное меню";
            this.btnOpenMainMenu.UseVisualStyleBackColor = false;
            this.btnOpenMainMenu.Click += new System.EventHandler(this.btnOpenMainMenu_Click);
            // 
            // AutoServiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(631, 167);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpenMainMenu);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(car_service_nameLabel);
            this.Controls.Add(this.car_service_nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutoServiceAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СИСТЕМА \"АВТОНОМИЯ\"";
            this.Load += new System.EventHandler(this.AutoServiceAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUTONOMIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_servicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AUTONOMIADataSet aUTONOMIADataSet;
        private System.Windows.Forms.BindingSource car_servicesBindingSource;
        private AUTONOMIADataSetTableAdapters.car_servicesTableAdapter car_servicesTableAdapter;
        private AUTONOMIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox car_service_nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnOpenMainMenu;
    }
}