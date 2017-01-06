namespace VB2QLNS.Views.NhanSu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwv = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTrinhDoVanHoa = new System.Windows.Forms.ComboBox();
            this.cboTrinhDoTinHoc = new System.Windows.Forms.ComboBox();
            this.cboTrinhDoNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.cboChuyenNganhDaoTao = new System.Windows.Forms.ComboBox();
            this.cboHinhThucDaoTao = new System.Windows.Forms.ComboBox();
            this.cboChucDanh = new System.Windows.Forms.ComboBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cboQuocGia = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cboTinhThanh = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cboTinhTrangHonNhan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.txtNoiDungTimKiem = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnDong = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToAge = new System.Windows.Forms.TextBox();
            this.txtFromAge = new System.Windows.Forms.TextBox();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwv)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::VB2QLNS.Properties.Resources.bg;
            this.groupBox1.Controls.Add(this.dgwv);
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(356, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 424);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dữ liệu";
            // 
            // dgwv
            // 
            this.dgwv.AllowUserToAddRows = false;
            this.dgwv.AllowUserToDeleteRows = false;
            this.dgwv.ColumnHeadersHeight = 30;
            this.dgwv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column4,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgwv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwv.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwv.Location = new System.Drawing.Point(3, 18);
            this.dgwv.MultiSelect = false;
            this.dgwv.Name = "dgwv";
            this.dgwv.ReadOnly = true;
            this.dgwv.RowTemplate.Height = 50;
            this.dgwv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwv.Size = new System.Drawing.Size(924, 381);
            this.dgwv.TabIndex = 7;
            this.dgwv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwv_CellDoubleClick);
            this.dgwv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwv_MouseClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::VB2QLNS.Properties.Resources.bg;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(3, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(85, 17);
            this.labelStatus.Text = "Trạng thái của ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::VB2QLNS.Properties.Resources.bg;
            this.groupBox2.Controls.Add(this.txtToAge);
            this.groupBox2.Controls.Add(this.txtFromAge);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboTrinhDoVanHoa);
            this.groupBox2.Controls.Add(this.cboTrinhDoTinHoc);
            this.groupBox2.Controls.Add(this.cboTrinhDoNgoaiNgu);
            this.groupBox2.Controls.Add(this.cboChuyenNganhDaoTao);
            this.groupBox2.Controls.Add(this.cboHinhThucDaoTao);
            this.groupBox2.Controls.Add(this.cboChucDanh);
            this.groupBox2.Controls.Add(this.cboChucVu);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.cboQuocGia);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.cboTinhThanh);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.cboTinhTrangHonNhan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboPhongBan);
            this.groupBox2.Controls.Add(this.txtNoiDungTimKiem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 424);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn";
            // 
            // cboTrinhDoVanHoa
            // 
            this.cboTrinhDoVanHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrinhDoVanHoa.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrinhDoVanHoa.FormattingEnabled = true;
            this.cboTrinhDoVanHoa.Location = new System.Drawing.Point(134, 346);
            this.cboTrinhDoVanHoa.Name = "cboTrinhDoVanHoa";
            this.cboTrinhDoVanHoa.Size = new System.Drawing.Size(216, 21);
            this.cboTrinhDoVanHoa.TabIndex = 126;
            // 
            // cboTrinhDoTinHoc
            // 
            this.cboTrinhDoTinHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrinhDoTinHoc.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrinhDoTinHoc.FormattingEnabled = true;
            this.cboTrinhDoTinHoc.Location = new System.Drawing.Point(134, 319);
            this.cboTrinhDoTinHoc.Name = "cboTrinhDoTinHoc";
            this.cboTrinhDoTinHoc.Size = new System.Drawing.Size(216, 21);
            this.cboTrinhDoTinHoc.TabIndex = 124;
            // 
            // cboTrinhDoNgoaiNgu
            // 
            this.cboTrinhDoNgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrinhDoNgoaiNgu.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrinhDoNgoaiNgu.FormattingEnabled = true;
            this.cboTrinhDoNgoaiNgu.Location = new System.Drawing.Point(134, 292);
            this.cboTrinhDoNgoaiNgu.Name = "cboTrinhDoNgoaiNgu";
            this.cboTrinhDoNgoaiNgu.Size = new System.Drawing.Size(216, 21);
            this.cboTrinhDoNgoaiNgu.TabIndex = 123;
            // 
            // cboChuyenNganhDaoTao
            // 
            this.cboChuyenNganhDaoTao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenNganhDaoTao.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuyenNganhDaoTao.FormattingEnabled = true;
            this.cboChuyenNganhDaoTao.Location = new System.Drawing.Point(134, 265);
            this.cboChuyenNganhDaoTao.Name = "cboChuyenNganhDaoTao";
            this.cboChuyenNganhDaoTao.Size = new System.Drawing.Size(216, 21);
            this.cboChuyenNganhDaoTao.TabIndex = 122;
            // 
            // cboHinhThucDaoTao
            // 
            this.cboHinhThucDaoTao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucDaoTao.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHinhThucDaoTao.FormattingEnabled = true;
            this.cboHinhThucDaoTao.Location = new System.Drawing.Point(134, 238);
            this.cboHinhThucDaoTao.Name = "cboHinhThucDaoTao";
            this.cboHinhThucDaoTao.Size = new System.Drawing.Size(216, 21);
            this.cboHinhThucDaoTao.TabIndex = 121;
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucDanh.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucDanh.FormattingEnabled = true;
            this.cboChucDanh.Location = new System.Drawing.Point(134, 102);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(216, 21);
            this.cboChucDanh.TabIndex = 119;
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(134, 75);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(216, 21);
            this.cboChucVu.TabIndex = 118;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(6, 349);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 13);
            this.label31.TabIndex = 117;
            this.label31.Text = "Trình độ văn hóa";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(6, 322);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 13);
            this.label29.TabIndex = 115;
            this.label29.Text = "Trình độ tin học";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(6, 295);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(99, 13);
            this.label28.TabIndex = 114;
            this.label28.Text = "Trình độ ngoại ngữ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(6, 268);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(117, 13);
            this.label27.TabIndex = 113;
            this.label27.Text = "Chuyên ngành đào tạo";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(6, 241);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 13);
            this.label26.TabIndex = 112;
            this.label26.Text = "Hình thức đào tạo";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(6, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 13);
            this.label22.TabIndex = 110;
            this.label22.Text = "Chức danh";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(6, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 109;
            this.label21.Text = "Chức vụ";
            // 
            // cboQuocGia
            // 
            this.cboQuocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuocGia.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuocGia.FormattingEnabled = true;
            this.cboQuocGia.Location = new System.Drawing.Point(134, 184);
            this.cboQuocGia.Name = "cboQuocGia";
            this.cboQuocGia.Size = new System.Drawing.Size(216, 21);
            this.cboQuocGia.TabIndex = 97;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(6, 187);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 13);
            this.label24.TabIndex = 96;
            this.label24.Text = "Quốc gia";
            // 
            // cboTinhThanh
            // 
            this.cboTinhThanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhThanh.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinhThanh.FormattingEnabled = true;
            this.cboTinhThanh.Location = new System.Drawing.Point(134, 157);
            this.cboTinhThanh.Name = "cboTinhThanh";
            this.cboTinhThanh.Size = new System.Drawing.Size(216, 21);
            this.cboTinhThanh.TabIndex = 95;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(6, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 94;
            this.label20.Text = "Tỉnh thành";
            // 
            // cboTinhTrangHonNhan
            // 
            this.cboTinhTrangHonNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrangHonNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTinhTrangHonNhan.FormattingEnabled = true;
            this.cboTinhTrangHonNhan.Location = new System.Drawing.Point(134, 211);
            this.cboTinhTrangHonNhan.Name = "cboTinhTrangHonNhan";
            this.cboTinhTrangHonNhan.Size = new System.Drawing.Size(216, 21);
            this.cboTinhTrangHonNhan.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Tình trạng hôn nhân";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Image = global::VB2QLNS.Properties.Resources.search_purple_icon1;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(253, 373);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 41);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Phòng ban";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(134, 20);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(216, 21);
            this.cboPhongBan.TabIndex = 6;
            // 
            // txtNoiDungTimKiem
            // 
            this.txtNoiDungTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungTimKiem.Location = new System.Drawing.Point(134, 47);
            this.txtNoiDungTimKiem.Name = "txtNoiDungTimKiem";
            this.txtNoiDungTimKiem.Size = new System.Drawing.Size(216, 22);
            this.txtNoiDungTimKiem.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::VB2QLNS.Properties.Resources.rsz_background_2;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnRefresh,
            this.btnDong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1286, 39);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::VB2QLNS.Properties.Resources.pencil_icon;
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 36);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::VB2QLNS.Properties.Resources.refresh_blue;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 36);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.Image = global::VB2QLNS.Properties.Resources.application_delete_icon;
            this.btnDong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(77, 36);
            this.btnDong.Text = "Đóng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 128;
            this.label3.Text = "Độ tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(131, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 129;
            this.label4.Text = "Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(235, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 131;
            this.label5.Text = "đến";
            // 
            // txtToAge
            // 
            this.txtToAge.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToAge.Location = new System.Drawing.Point(267, 129);
            this.txtToAge.Name = "txtToAge";
            this.txtToAge.Size = new System.Drawing.Size(83, 22);
            this.txtToAge.TabIndex = 133;
            this.txtToAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToAge_KeyPress);
            // 
            // txtFromAge
            // 
            this.txtFromAge.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromAge.Location = new System.Drawing.Point(154, 129);
            this.txtFromAge.Name = "txtFromAge";
            this.txtFromAge.Size = new System.Drawing.Size(75, 22);
            this.txtFromAge.TabIndex = 132;
            this.txtFromAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromAge_KeyPress);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "AnhDaiDien";
            this.Column3.FillWeight = 20F;
            this.Column3.HeaderText = "Hình Ảnh";
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Mã nhân sự";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 88;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TenPhongBan";
            this.Column7.HeaderText = "Phòng ban";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenChucVu";
            this.Column8.HeaderText = "Chức vụ";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TenChucDanh";
            this.Column9.HeaderText = "Chức danh";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 130;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EmailCongTy";
            this.Column5.HeaderText = "Email công ty";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoDienThoaiDiDong";
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 95;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 79;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TrinhDoTotNghiep";
            this.Column10.HeaderText = "Trình độ văn hóa";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 114;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TrinhDoNgoaiNgu";
            this.Column11.HeaderText = "Trình độ ngoại ngữ";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 122;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TrinhDoTinHoc";
            this.Column12.HeaderText = "Trình độ tin học";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 107;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "TenTinhThanh";
            this.Column13.HeaderText = "Tỉnh thành";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 83;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "TenQuocGia";
            this.Column14.HeaderText = "Quốc gia";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 75;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC NHÂN SỰ - QUẢN LÝ";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwv)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.TextBox txtNoiDungTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ComboBox cboTinhTrangHonNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTinhThanh;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboQuocGia;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cboTrinhDoVanHoa;
        private System.Windows.Forms.ComboBox cboTrinhDoTinHoc;
        private System.Windows.Forms.ComboBox cboTrinhDoNgoaiNgu;
        private System.Windows.Forms.ComboBox cboChuyenNganhDaoTao;
        private System.Windows.Forms.ComboBox cboHinhThucDaoTao;
        private System.Windows.Forms.ComboBox cboChucDanh;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToAge;
        private System.Windows.Forms.TextBox txtFromAge;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}