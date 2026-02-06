namespace SmartStock.WinForms.People
{
    partial class frmListPeople
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
            this.labelPeopleTitle = new System.Windows.Forms.Label();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.عرضبياناتألشخصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.أضافةشخصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلبياناتالشخصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.labelRecords = new System.Windows.Forms.Label();
            this.labelRecordsResult = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbGenderFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.contextMenuPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPeopleTitle
            // 
            this.labelPeopleTitle.AutoSize = true;
            this.labelPeopleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelPeopleTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelPeopleTitle.Location = new System.Drawing.Point(610, 231);
            this.labelPeopleTitle.Name = "labelPeopleTitle";
            this.labelPeopleTitle.Size = new System.Drawing.Size(128, 39);
            this.labelPeopleTitle.TabIndex = 0;
            this.labelPeopleTitle.Text = "ألاشخاص";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.contextMenuPeople;
            this.dgvPeople.Location = new System.Drawing.Point(12, 333);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            this.dgvPeople.RowHeadersWidth = 51;
            this.dgvPeople.RowTemplate.Height = 24;
            this.dgvPeople.Size = new System.Drawing.Size(1258, 282);
            this.dgvPeople.TabIndex = 2;
            // 
            // contextMenuPeople
            // 
            this.contextMenuPeople.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضبياناتألشخصToolStripMenuItem,
            this.أضافةشخصToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.تعديلبياناتالشخصToolStripMenuItem});
            this.contextMenuPeople.Name = "contextMenuStrip1";
            this.contextMenuPeople.Size = new System.Drawing.Size(244, 156);
            // 
            // عرضبياناتألشخصToolStripMenuItem
            // 
            this.عرضبياناتألشخصToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.عرضبياناتألشخصToolStripMenuItem.Image = global::SmartStock.WinForms.Properties.Resources.PersonDetails_32;
            this.عرضبياناتألشخصToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.عرضبياناتألشخصToolStripMenuItem.Name = "عرضبياناتألشخصToolStripMenuItem";
            this.عرضبياناتألشخصToolStripMenuItem.Size = new System.Drawing.Size(243, 38);
            this.عرضبياناتألشخصToolStripMenuItem.Text = "عرض بيانات ألشخص";
            // 
            // أضافةشخصToolStripMenuItem
            // 
            this.أضافةشخصToolStripMenuItem.Image = global::SmartStock.WinForms.Properties.Resources.AddPerson_32;
            this.أضافةشخصToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.أضافةشخصToolStripMenuItem.Name = "أضافةشخصToolStripMenuItem";
            this.أضافةشخصToolStripMenuItem.Size = new System.Drawing.Size(243, 38);
            this.أضافةشخصToolStripMenuItem.Text = "أضافة شخص";
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.حذفToolStripMenuItem.Image = global::SmartStock.WinForms.Properties.Resources.Delete_32_2;
            this.حذفToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(243, 38);
            this.حذفToolStripMenuItem.Text = "حذف";
            // 
            // تعديلبياناتالشخصToolStripMenuItem
            // 
            this.تعديلبياناتالشخصToolStripMenuItem.Image = global::SmartStock.WinForms.Properties.Resources.edit_32;
            this.تعديلبياناتالشخصToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.تعديلبياناتالشخصToolStripMenuItem.Name = "تعديلبياناتالشخصToolStripMenuItem";
            this.تعديلبياناتالشخصToolStripMenuItem.Size = new System.Drawing.Size(243, 38);
            this.تعديلبياناتالشخصToolStripMenuItem.Text = "تعديل بيانات الشخص";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(29, 283);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(235, 30);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = ": أبحث ب ";
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "فارغ",
            "ألاسم الكامل",
            "ألبريد ألالكتروني",
            "البلد",
            "الهاتف",
            "الجنس",
            "رقم الشخص"});
            this.cbFilter.Location = new System.Drawing.Point(270, 283);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(228, 33);
            this.cbFilter.TabIndex = 6;
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRecords.Location = new System.Drawing.Point(115, 639);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(72, 29);
            this.labelRecords.TabIndex = 7;
            this.labelRecords.Text = ": النتائج";
            // 
            // labelRecordsResult
            // 
            this.labelRecordsResult.AutoSize = true;
            this.labelRecordsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelRecordsResult.Location = new System.Drawing.Point(60, 639);
            this.labelRecordsResult.Name = "labelRecordsResult";
            this.labelRecordsResult.Size = new System.Drawing.Size(49, 29);
            this.labelRecordsResult.TabIndex = 8;
            this.labelRecordsResult.Text = "???";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SmartStock.WinForms.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1099, 628);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "أغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = global::SmartStock.WinForms.Properties.Resources.Add_Person_72;
            this.buttonAdd.Location = new System.Drawing.Point(1175, 240);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 87);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartStock.WinForms.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(535, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbGenderFilter
            // 
            this.cbGenderFilter.FormattingEnabled = true;
            this.cbGenderFilter.Items.AddRange(new object[] {
            "الكل",
            "ذكر",
            "انثى"});
            this.cbGenderFilter.Location = new System.Drawing.Point(120, 240);
            this.cbGenderFilter.Name = "cbGenderFilter";
            this.cbGenderFilter.Size = new System.Drawing.Size(121, 33);
            this.cbGenderFilter.TabIndex = 10;
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1282, 677);
            this.Controls.Add(this.cbGenderFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelRecordsResult);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPeopleTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListPeople";
            this.Text = "frmListPeople";
            this.Load += new System.EventHandler(this.frmListPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.contextMenuPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPeopleTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.Label labelRecordsResult;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuPeople;
        private System.Windows.Forms.ToolStripMenuItem عرضبياناتألشخصToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem أضافةشخصToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلبياناتالشخصToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbGenderFilter;
    }
}