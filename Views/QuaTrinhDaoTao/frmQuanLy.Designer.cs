namespace VB2QLNS.Views.QuaTrinhDaoTao
{
    partial class frmQuanLy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip5 = new System.Windows.Forms.ToolStrip();
			this.btnLamMoi = new System.Windows.Forms.ToolStripButton();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.dgvwQuaTrinhDaoTao = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox6.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.toolStrip5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvwQuaTrinhDaoTao)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox6
			// 
			this.groupBox6.BackgroundImage = global::VB2QLNS.Properties.Resources.bg;
			this.groupBox6.Controls.Add(this.dgvwQuaTrinhDaoTao);
			this.groupBox6.Controls.Add(this.statusStrip1);
			this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox6.ForeColor = System.Drawing.Color.White;
			this.groupBox6.Location = new System.Drawing.Point(0, 0);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(839, 481);
			this.groupBox6.TabIndex = 7;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Thông tin quá trình đào tạo";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
			this.statusStrip1.Location = new System.Drawing.Point(3, 456);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(833, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// labelStatus
			// 
			this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatus.ForeColor = System.Drawing.Color.Black;
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(119, 17);
			this.labelStatus.Text = "toolStripStatusLabel1";
			// 
			// toolStrip5
			// 
			this.toolStrip5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLamMoi,
            this.btnThem});
			this.toolStrip5.Location = new System.Drawing.Point(0, 481);
			this.toolStrip5.Name = "toolStrip5";
			this.toolStrip5.Size = new System.Drawing.Size(839, 39);
			this.toolStrip5.TabIndex = 6;
			this.toolStrip5.Text = "toolStrip3";
			// 
			// btnLamMoi
			// 
			this.btnLamMoi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLamMoi.Image = global::VB2QLNS.Properties.Resources.refresh_blue;
			this.btnLamMoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnLamMoi.Name = "btnLamMoi";
			this.btnLamMoi.Size = new System.Drawing.Size(91, 36);
			this.btnLamMoi.Text = "Làm mới";
			this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
			// 
			// btnThem
			// 
			this.btnThem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Image = global::VB2QLNS.Properties.Resources.pencil_icon;
			this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(100, 36);
			this.btnThem.Text = "Thêm mới";
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// dgvwQuaTrinhDaoTao
			// 
			this.dgvwQuaTrinhDaoTao.AllowUserToAddRows = false;
			this.dgvwQuaTrinhDaoTao.AllowUserToDeleteRows = false;
			this.dgvwQuaTrinhDaoTao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvwQuaTrinhDaoTao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvwQuaTrinhDaoTao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18});
			this.dgvwQuaTrinhDaoTao.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvwQuaTrinhDaoTao.Location = new System.Drawing.Point(3, 18);
			this.dgvwQuaTrinhDaoTao.MultiSelect = false;
			this.dgvwQuaTrinhDaoTao.Name = "dgvwQuaTrinhDaoTao";
			this.dgvwQuaTrinhDaoTao.ReadOnly = true;
			this.dgvwQuaTrinhDaoTao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvwQuaTrinhDaoTao.Size = new System.Drawing.Size(833, 438);
			this.dgvwQuaTrinhDaoTao.TabIndex = 2;
			this.dgvwQuaTrinhDaoTao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwQuaTrinhDaoTao_CellDoubleClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Id";
			this.Column1.HeaderText = "Mã";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "NhanSuId";
			this.Column2.HeaderText = "Mã nhân sự";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Visible = false;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "TuNgay";
			this.dataGridViewTextBoxColumn10.HeaderText = "Từ ngày";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "DenNgay";
			this.dataGridViewTextBoxColumn11.HeaderText = "Đến ngày";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			// 
			// Column13
			// 
			this.Column13.DataPropertyName = "Loai";
			this.Column13.HeaderText = "Loại";
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			// 
			// Column14
			// 
			this.Column14.DataPropertyName = "HinhThuc";
			this.Column14.HeaderText = "Hình thức";
			this.Column14.Name = "Column14";
			this.Column14.ReadOnly = true;
			// 
			// Column15
			// 
			this.Column15.DataPropertyName = "ChuyenNganh";
			this.Column15.HeaderText = "Chuyên ngành";
			this.Column15.Name = "Column15";
			this.Column15.ReadOnly = true;
			// 
			// Column16
			// 
			this.Column16.DataPropertyName = "ChungChi";
			this.Column16.HeaderText = "Chứng chỉ";
			this.Column16.Name = "Column16";
			this.Column16.ReadOnly = true;
			// 
			// Column17
			// 
			this.Column17.DataPropertyName = "TenTruongDaoTao";
			this.Column17.HeaderText = "Tên trường đào tạo";
			this.Column17.Name = "Column17";
			this.Column17.ReadOnly = true;
			// 
			// Column18
			// 
			this.Column18.DataPropertyName = "NuocDaoTao";
			this.Column18.HeaderText = "Nước đào tạo";
			this.Column18.Name = "Column18";
			this.Column18.ReadOnly = true;
			// 
			// frmQuanLy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.toolStrip5);
			this.Name = "frmQuanLy";
			this.Size = new System.Drawing.Size(839, 520);
			this.Load += new System.EventHandler(this.frmQuanLy_Load);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip5.ResumeLayout(false);
			this.toolStrip5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvwQuaTrinhDaoTao)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnLamMoi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
		private System.Windows.Forms.DataGridView dgvwQuaTrinhDaoTao;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
	}
}
