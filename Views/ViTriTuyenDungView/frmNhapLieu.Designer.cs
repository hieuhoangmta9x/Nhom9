namespace VB2QLNS.Views.ViTriTuyenDungView
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTrangThaiSuDung = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHuyBo = new System.Windows.Forms.ToolStripButton();
            this.btnXacNhan = new System.Windows.Forms.ToolStripButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenViTriTuyenDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTrangThaiSuDung);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTenViTriTuyenDung);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(579, 167);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // chkTrangThaiSuDung
            // 
            this.chkTrangThaiSuDung.AutoSize = true;
            this.chkTrangThaiSuDung.Location = new System.Drawing.Point(155, 96);
            this.chkTrangThaiSuDung.Margin = new System.Windows.Forms.Padding(4);
            this.chkTrangThaiSuDung.Name = "chkTrangThaiSuDung";
            this.chkTrangThaiSuDung.Size = new System.Drawing.Size(96, 21);
            this.chkTrangThaiSuDung.TabIndex = 115;
            this.chkTrangThaiSuDung.Text = "Hoạt động";
            this.chkTrangThaiSuDung.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 114;
            this.label5.Text = "Trạng thái sử dụng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHuyBo,
            this.btnXacNhan});
            this.toolStrip1.Location = new System.Drawing.Point(4, 136);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(571, 27);
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
            this.btnHuyBo.Size = new System.Drawing.Size(61, 24);
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
            this.btnXacNhan.Size = new System.Drawing.Size(73, 24);
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(154, 23);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Mã";
            // 
            // txtTenViTriTuyenDung
            // 
            this.txtTenViTriTuyenDung.Location = new System.Drawing.Point(154, 55);
            this.txtTenViTriTuyenDung.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenViTriTuyenDung.Name = "txtTenViTriTuyenDung";
            this.txtTenViTriTuyenDung.Size = new System.Drawing.Size(409, 22);
            this.txtTenViTriTuyenDung.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 108;
            this.label3.Text = "Tên vị trí tuyển dụng";
            // 
            // frmNhapLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 167);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmNhapLieu";
            this.Text = "frmNhapLieu";
            this.Load += new System.EventHandler(this.frmNhapLieu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenViTriTuyenDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkTrangThaiSuDung;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHuyBo;
        private System.Windows.Forms.ToolStripButton btnXacNhan;
    }
}