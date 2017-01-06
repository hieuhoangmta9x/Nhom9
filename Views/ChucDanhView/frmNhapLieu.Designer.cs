namespace VB2QLNS.Views.ChucDanhView
{
    partial class frmNhapLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapLieu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkKichHoat = new System.Windows.Forms.CheckBox();
            this.txtThongTinMoTa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenVietTat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHuyBo = new System.Windows.Forms.ToolStripButton();
            this.btnXacNhan = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenChucDanh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkKichHoat);
            this.groupBox1.Controls.Add(this.txtThongTinMoTa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenVietTat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenChucDanh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 162);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 119;
            this.label7.Text = "Trạng thái sử dụng";
            // 
            // chkKichHoat
            // 
            this.chkKichHoat.AutoSize = true;
            this.chkKichHoat.Location = new System.Drawing.Point(115, 123);
            this.chkKichHoat.Name = "chkKichHoat";
            this.chkKichHoat.Size = new System.Drawing.Size(77, 17);
            this.chkKichHoat.TabIndex = 118;
            this.chkKichHoat.Text = "Hoạt động";
            this.chkKichHoat.UseVisualStyleBackColor = true;
            // 
            // txtThongTinMoTa
            // 
            this.txtThongTinMoTa.Location = new System.Drawing.Point(115, 97);
            this.txtThongTinMoTa.Name = "txtThongTinMoTa";
            this.txtThongTinMoTa.Size = new System.Drawing.Size(308, 20);
            this.txtThongTinMoTa.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Thông tin mô tả";
            // 
            // txtTenVietTat
            // 
            this.txtTenVietTat.Location = new System.Drawing.Point(115, 71);
            this.txtTenVietTat.Name = "txtTenVietTat";
            this.txtTenVietTat.Size = new System.Drawing.Size(308, 20);
            this.txtTenVietTat.TabIndex = 115;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 114;
            this.label2.Text = "Tên viết tắt";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHuyBo,
            this.btnXacNhan});
            this.toolStrip1.Location = new System.Drawing.Point(3, 134);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(427, 25);
            this.toolStrip1.TabIndex = 113;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnHuyBo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHuyBo.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.Image")));
            this.btnHuyBo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(50, 22);
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXacNhan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.Image")));
            this.btnXacNhan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(60, 22);
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 19);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Mã";
            // 
            // txtTenChucDanh
            // 
            this.txtTenChucDanh.Location = new System.Drawing.Point(115, 45);
            this.txtTenChucDanh.Name = "txtTenChucDanh";
            this.txtTenChucDanh.Size = new System.Drawing.Size(308, 20);
            this.txtTenChucDanh.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Tên chức danh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmNhapLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 162);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNhapLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC CHỨC DANH - NHẬP LIỆU";
            this.Load += new System.EventHandler(this.frmNhapLieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThongTinMoTa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenVietTat;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHuyBo;
        private System.Windows.Forms.ToolStripButton btnXacNhan;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenChucDanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkKichHoat;
    }
}