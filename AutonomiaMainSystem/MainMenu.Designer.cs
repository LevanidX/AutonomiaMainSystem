namespace AutonomiaMainSystem
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnAddNewAutoBrand = new System.Windows.Forms.Button();
            this.btnAddNewAutoModel = new System.Windows.Forms.Button();
            this.btnAddNewAutoService = new System.Windows.Forms.Button();
            this.btnAddNewDetailService = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.btnApplicationExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.Orange;
            this.btnMakeOrder.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMakeOrder.Location = new System.Drawing.Point(7, 402);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(504, 62);
            this.btnMakeOrder.TabIndex = 0;
            this.btnMakeOrder.Text = "Оформление заказа на ремонт";
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.Orange;
            this.btnViewOrders.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewOrders.Location = new System.Drawing.Point(7, 480);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(504, 62);
            this.btnViewOrders.TabIndex = 1;
            this.btnViewOrders.Text = "Просмотреть все заказы";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnAddNewAutoBrand
            // 
            this.btnAddNewAutoBrand.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewAutoBrand.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewAutoBrand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewAutoBrand.Location = new System.Drawing.Point(7, 246);
            this.btnAddNewAutoBrand.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAddNewAutoBrand.Name = "btnAddNewAutoBrand";
            this.btnAddNewAutoBrand.Size = new System.Drawing.Size(504, 62);
            this.btnAddNewAutoBrand.TabIndex = 2;
            this.btnAddNewAutoBrand.Text = "Добавление новой марки автомобиля";
            this.btnAddNewAutoBrand.UseVisualStyleBackColor = false;
            this.btnAddNewAutoBrand.Click += new System.EventHandler(this.btnAddNewAutoBrand_Click);
            // 
            // btnAddNewAutoModel
            // 
            this.btnAddNewAutoModel.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewAutoModel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewAutoModel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewAutoModel.Location = new System.Drawing.Point(7, 324);
            this.btnAddNewAutoModel.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAddNewAutoModel.Name = "btnAddNewAutoModel";
            this.btnAddNewAutoModel.Size = new System.Drawing.Size(504, 62);
            this.btnAddNewAutoModel.TabIndex = 3;
            this.btnAddNewAutoModel.Text = "Добавление новой модели автомобиля";
            this.btnAddNewAutoModel.UseVisualStyleBackColor = false;
            this.btnAddNewAutoModel.Click += new System.EventHandler(this.btnAddNewAutoModel_Click);
            // 
            // btnAddNewAutoService
            // 
            this.btnAddNewAutoService.BackColor = System.Drawing.Color.DimGray;
            this.btnAddNewAutoService.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewAutoService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewAutoService.Location = new System.Drawing.Point(7, 90);
            this.btnAddNewAutoService.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAddNewAutoService.Name = "btnAddNewAutoService";
            this.btnAddNewAutoService.Size = new System.Drawing.Size(504, 62);
            this.btnAddNewAutoService.TabIndex = 4;
            this.btnAddNewAutoService.Text = "Добавление нового типа работ";
            this.btnAddNewAutoService.UseVisualStyleBackColor = false;
            this.btnAddNewAutoService.Click += new System.EventHandler(this.btnAddNewAutoService_Click);
            // 
            // btnAddNewDetailService
            // 
            this.btnAddNewDetailService.BackColor = System.Drawing.Color.DimGray;
            this.btnAddNewDetailService.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewDetailService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddNewDetailService.Location = new System.Drawing.Point(7, 168);
            this.btnAddNewDetailService.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAddNewDetailService.Name = "btnAddNewDetailService";
            this.btnAddNewDetailService.Size = new System.Drawing.Size(504, 62);
            this.btnAddNewDetailService.TabIndex = 5;
            this.btnAddNewDetailService.Text = "Добавление нового наименования работ";
            this.btnAddNewDetailService.UseVisualStyleBackColor = false;
            this.btnAddNewDetailService.Click += new System.EventHandler(this.btnAddNewDetailService_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMainTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMainTitle.Location = new System.Drawing.Point(88, 5);
            this.lblMainTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(345, 77);
            this.lblMainTitle.TabIndex = 6;
            this.lblMainTitle.Text = "АВТОНОМИЯ";
            // 
            // btnApplicationExit
            // 
            this.btnApplicationExit.BackColor = System.Drawing.Color.Red;
            this.btnApplicationExit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplicationExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApplicationExit.Location = new System.Drawing.Point(7, 558);
            this.btnApplicationExit.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnApplicationExit.Name = "btnApplicationExit";
            this.btnApplicationExit.Size = new System.Drawing.Size(504, 88);
            this.btnApplicationExit.TabIndex = 7;
            this.btnApplicationExit.Text = "Выход из программы";
            this.btnApplicationExit.UseVisualStyleBackColor = false;
            this.btnApplicationExit.Click += new System.EventHandler(this.btnApplicationExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(519, 658);
            this.ControlBox = false;
            this.Controls.Add(this.btnApplicationExit);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.btnAddNewDetailService);
            this.Controls.Add(this.btnAddNewAutoService);
            this.Controls.Add(this.btnAddNewAutoModel);
            this.Controls.Add(this.btnAddNewAutoBrand);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnMakeOrder);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СИСТЕМА \"АВТОНОМИЯ\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnAddNewAutoBrand;
        private System.Windows.Forms.Button btnAddNewAutoModel;
        private System.Windows.Forms.Button btnAddNewAutoService;
        private System.Windows.Forms.Button btnAddNewDetailService;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Button btnApplicationExit;
    }
}

