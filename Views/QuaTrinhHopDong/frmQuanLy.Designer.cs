namespace VB2QLNS.Views.QuaTrinhHopDong
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnLamMoi = new System.Windows.Forms.ToolStripButton();
			this.btnThem = new System.Windows.Forms.ToolStripButton();
			this.dgvwQuaTrinhHopDong = new System.Windows.Forms.DataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TuNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DenNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HinhThucHuongLuongId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhongBanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChucVuId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TienLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvwQuaTrinhHopDong)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackgroundImage = global::VB2QLNS.Properties.Resources.bg;
			this.groupBox2.Controls.Add(this.dgvwQuaTrinhHopDong);
			this.groupBox2.Controls.Add(this.statusStrip1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(662, 387);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thông tin quá trình hợp đồng";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
			this.statusStrip1.Location = new System.Drawing.Point(3, 362);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(656, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// labelStatus
			// 
			this.labelStatus.ForeColor = System.Drawing.Color.Black;
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(118, 17);
			this.labelStatus.Text = "toolStripStatusLabel1";
			// 
			// toolStrip2
			// 
			this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLamMoi,
            this.btnThem});
			this.toolStrip2.Location = new System.Drawing.Point(0, 387);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(662, 39);
			this.toolStrip2.TabIndex = 4;
			this.toolStrip2.Text = "toolStrip2";
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
			// dgvwQuaTrinhHopDong
			// 
			this.dgvwQuaTrinhHopDong.AllowUserToAddRows = false;
			this.dgvwQuaTrinhHopDong.AllowUserToDeleteRows = false;
			this.dgvwQuaTrinhHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvwQuaTrinhHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvwQuaTrinhHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.TuNgay,
            this.DenNgay,
            this.HinhThucHuongLuongId,
            this.PhongBanId,
            this.ChucVuId,
            this.TienLuong});
			this.dgvwQuaTrinhHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvwQuaTrinhHopDong.Location = new System.Drawing.Point(3, 18);
			this.dgvwQuaTrinhHopDong.MultiSelect = false;
			this.dgvwQuaTrinhHopDong.Name = "dgvwQuaTrinhHopDong";
			this.dgvwQuaTrinhHopDong.ReadOnly = true;
			this.dgvwQuaTrinhHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvwQuaTrinhHopDong.Size = new System.Drawing.Size(656, 344);
			this.dgvwQuaTrinhHopDong.TabIndex = 2;
			this.dgvwQuaTrinhHopDong.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwQuaTrinhLuong_CellDoubleClick);
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Id";
			this.Column2.HeaderText = "Mã";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Visible = false;
			// 
			// TuNgay
			// 
			this.TuNgay.DataPropertyName = "TuNgay";
			this.TuNgay.HeaderText = "Từ ngày";
			this.TuNgay.Name = "TuNgay";
			this.TuNgay.ReadOnly = true;
			// 
			// DenNgay
			// 
			this.DenNgay.DataPropertyName = "DenNgay";
			this.DenNgay.HeaderText = "Đến ngày";
			this.DenNgay.Name = "DenNgay";
			this.DenNgay.ReadOnly = true;
			// 
			// HinhThucHuongLuongId
			// 
			this.HinhThucHuongLuongId.DataPropertyName = "TenLoaiHopDong";
			this.HinhThucHuongLuongId.HeaderText = "Loại hợp đồng";
			this.HinhThucHuongLuongId.Name = "HinhThucHuongLuongId";
			this.HinhThucHuongLuongId.ReadOnly = true;
			// 
			// PhongBanId
			// 
			this.PhongBanId.DataPropertyName = "TenPhongBan";
			this.PhongBanId.HeaderText = "Phòng ban";
			this.PhongBanId.Name = "PhongBanId";
			this.PhongBanId.ReadOnly = true;
			// 
			// ChucVuId
			// 
			this.ChucVuId.DataPropertyName = "TenChucVu";
			this.ChucVuId.HeaderText = "Chức vụ";
			this.ChucVuId.Name = "ChucVuId";
			this.ChucVuId.ReadOnly = true;
			// 
			// TienLuong
			// 
			this.TienLuong.DataPropertyName = "GhiChu";
			this.TienLuong.HeaderText = "Ghi chú";
			this.TienLuong.Name = "TienLuong";
			this.TienLuong.ReadOnly = true;
			// 
			// frmQuanLy
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.toolStrip2);
			this.Name = "frmQuanLy";
			this.Size = new System.Drawing.Size(662, 426);
			this.Load += new System.EventHandler(this.frmQuanLy_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvwQuaTrinhHopDong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnLamMoi;
		private System.Windows.Forms.DataGridView dgvwQuaTrinhHopDong;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn TuNgay;
		private System.Windows.Forms.DataGridViewTextBoxColumn DenNgay;
		private System.Windows.Forms.DataGridViewTextBoxColumn HinhThucHuongLuongId;
		private System.Windows.Forms.DataGridViewTextBoxColumn PhongBanId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChucVuId;
		private System.Windows.Forms.DataGridViewTextBoxColumn TienLuong;
	}
}
