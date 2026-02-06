namespace SmartStock.WinForms
{
    partial class frmMain
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
            this.lkInventoryexchangeorder = new System.Windows.Forms.LinkLabel();
            this.Purchasesinvoice = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.WarehouseSupplyOrder = new System.Windows.Forms.LinkLabel();
            this.lkProductsDetails = new System.Windows.Forms.LinkLabel();
            this.lkNonAvalibelQuantites = new System.Windows.Forms.LinkLabel();
            this.lkemployeesmangement = new System.Windows.Forms.LinkLabel();
            this.lkusersmanagement = new System.Windows.Forms.LinkLabel();
            this.lkPeopleManagment = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lkInventoryexchangeorder
            // 
            this.lkInventoryexchangeorder.AutoSize = true;
            this.lkInventoryexchangeorder.Location = new System.Drawing.Point(46, 201);
            this.lkInventoryexchangeorder.Name = "lkInventoryexchangeorder";
            this.lkInventoryexchangeorder.Size = new System.Drawing.Size(149, 25);
            this.lkInventoryexchangeorder.TabIndex = 0;
            this.lkInventoryexchangeorder.TabStop = true;
            this.lkInventoryexchangeorder.Text = "أمر الصرف المخزني";
            // 
            // Purchasesinvoice
            // 
            this.Purchasesinvoice.AutoSize = true;
            this.Purchasesinvoice.Location = new System.Drawing.Point(73, 115);
            this.Purchasesinvoice.Name = "Purchasesinvoice";
            this.Purchasesinvoice.Size = new System.Drawing.Size(122, 25);
            this.Purchasesinvoice.TabIndex = 1;
            this.Purchasesinvoice.TabStop = true;
            this.Purchasesinvoice.Text = "فاتورة المشتريات";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(86, 155);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 25);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "فاتورة المبيعات";
            // 
            // WarehouseSupplyOrder
            // 
            this.WarehouseSupplyOrder.AutoSize = true;
            this.WarehouseSupplyOrder.Location = new System.Drawing.Point(54, 250);
            this.WarehouseSupplyOrder.Name = "WarehouseSupplyOrder";
            this.WarehouseSupplyOrder.Size = new System.Drawing.Size(141, 25);
            this.WarehouseSupplyOrder.TabIndex = 3;
            this.WarehouseSupplyOrder.TabStop = true;
            this.WarehouseSupplyOrder.Text = "أمر التوريد المخزني";
            // 
            // lkProductsDetails
            // 
            this.lkProductsDetails.AutoSize = true;
            this.lkProductsDetails.Location = new System.Drawing.Point(81, 307);
            this.lkProductsDetails.Name = "lkProductsDetails";
            this.lkProductsDetails.Size = new System.Drawing.Size(114, 25);
            this.lkProductsDetails.TabIndex = 4;
            this.lkProductsDetails.TabStop = true;
            this.lkProductsDetails.Text = "بيانات ألاصناف";
            // 
            // lkNonAvalibelQuantites
            // 
            this.lkNonAvalibelQuantites.AutoSize = true;
            this.lkNonAvalibelQuantites.Location = new System.Drawing.Point(7, 357);
            this.lkNonAvalibelQuantites.Name = "lkNonAvalibelQuantites";
            this.lkNonAvalibelQuantites.Size = new System.Drawing.Size(188, 25);
            this.lkNonAvalibelQuantites.TabIndex = 5;
            this.lkNonAvalibelQuantites.TabStop = true;
            this.lkNonAvalibelQuantites.Text = "تقارير الكميات الغير متوفرة";
            // 
            // lkemployeesmangement
            // 
            this.lkemployeesmangement.AutoSize = true;
            this.lkemployeesmangement.Location = new System.Drawing.Point(90, 403);
            this.lkemployeesmangement.Name = "lkemployeesmangement";
            this.lkemployeesmangement.Size = new System.Drawing.Size(105, 25);
            this.lkemployeesmangement.TabIndex = 6;
            this.lkemployeesmangement.TabStop = true;
            this.lkemployeesmangement.Text = "أدارة الموظفين";
            // 
            // lkusersmanagement
            // 
            this.lkusersmanagement.AutoSize = true;
            this.lkusersmanagement.Location = new System.Drawing.Point(73, 447);
            this.lkusersmanagement.Name = "lkusersmanagement";
            this.lkusersmanagement.Size = new System.Drawing.Size(122, 25);
            this.lkusersmanagement.TabIndex = 7;
            this.lkusersmanagement.TabStop = true;
            this.lkusersmanagement.Text = "أدارة المستخدمين";
            // 
            // lkPeopleManagment
            // 
            this.lkPeopleManagment.AutoSize = true;
            this.lkPeopleManagment.Location = new System.Drawing.Point(119, 501);
            this.lkPeopleManagment.Name = "lkPeopleManagment";
            this.lkPeopleManagment.Size = new System.Drawing.Size(76, 25);
            this.lkPeopleManagment.TabIndex = 8;
            this.lkPeopleManagment.TabStop = true;
            this.lkPeopleManagment.Text = "الأشخاص";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(728, 708);
            this.Controls.Add(this.lkPeopleManagment);
            this.Controls.Add(this.lkusersmanagement);
            this.Controls.Add(this.lkemployeesmangement);
            this.Controls.Add(this.lkNonAvalibelQuantites);
            this.Controls.Add(this.lkProductsDetails);
            this.Controls.Add(this.WarehouseSupplyOrder);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Purchasesinvoice);
            this.Controls.Add(this.lkInventoryexchangeorder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "الشاشة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lkInventoryexchangeorder;
        private System.Windows.Forms.LinkLabel Purchasesinvoice;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel WarehouseSupplyOrder;
        private System.Windows.Forms.LinkLabel lkProductsDetails;
        private System.Windows.Forms.LinkLabel lkNonAvalibelQuantites;
        private System.Windows.Forms.LinkLabel lkemployeesmangement;
        private System.Windows.Forms.LinkLabel lkusersmanagement;
        private System.Windows.Forms.LinkLabel lkPeopleManagment;
    }
}

