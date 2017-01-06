using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Views;

namespace VB2QLNS.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            menuStrip1.Visible = true;
        }

        private void mnuDanToc_Click(object sender, EventArgs e)
        {
            (new DanTocView.frmQuanLy()).ShowDialog();
        }

        private void mnuHinhThucDaoTao_Click(object sender, EventArgs e)
        {
            (new HinhThucDaoTaoView.frmQuanLy()).ShowDialog();
        }

        private void mnuHinhThucNghi_Click(object sender, EventArgs e)
        {
            (new HinhThucNghiView.frmQuanLy()).ShowDialog();
        }

        private void mnuHinhThucTuyenDung_Click(object sender, EventArgs e)
        {
            (new HinhThucTuyenDungView.frmQuanLy()).ShowDialog();
        }

        private void mnuLoaiHopDong_Click(object sender, EventArgs e)
        {
            (new LoaiHopDongView.frmQuanLy()).ShowDialog();
        }

        private void mnuPhuCap_Click(object sender, EventArgs e)
        {
            (new PhuCapView.frmQuanLy()).ShowDialog();
        }

        private void mnuQuocGia_Click(object sender, EventArgs e)
        {
            (new QuocGiaView.frmQuanLy()).ShowDialog();
        }

        private void mnuTinhThanh_Click(object sender, EventArgs e)
        {
            (new TinhThanhView.frmQuanLy()).ShowDialog();
        }

        private void mnuTinhTrangHonNhan_Click(object sender, EventArgs e)
        {
            (new TinhTrangHonNhanView.frmQuanLy()).ShowDialog();
        }

        private void mnuTonGiao_Click(object sender, EventArgs e)
        {
            (new TonGiaoView.frmQuanLy()).ShowDialog();
        }

        private void mnuTrangThaiHopDong_Click(object sender, EventArgs e)
        {
            (new TrangThaiHopDongView.frmQuanLy()).ShowDialog();
        }

        private void mnuTrinhDoNgoaiNgu_Click(object sender, EventArgs e)
        {
            (new TrinhDoNgoaiNguView.frmQuanLy()).ShowDialog();
        }

        private void mnuTrinhDoTinHoc_Click(object sender, EventArgs e)
        {
            (new TrinhDoTinHocView.frmQuanLy()).ShowDialog();
        }

        private void mnuTrinhDoVanHoa_Click(object sender, EventArgs e)
        {
            (new TrinhDoVanHoaView.frmQuanLy()).ShowDialog();
        }

        private void mnuTruongDaoTao_Click(object sender, EventArgs e)
        {
            (new TruongDaoTaoView.frmQuanLy()).ShowDialog();
        }

        private void mnuViTriTuyenDung_Click(object sender, EventArgs e)
        {
            (new ViTriTuyenDungView.frmQuanLy()).ShowDialog();
        }

        private void mnuBacLuong_Click(object sender, EventArgs e)
        {
            (new BacLuongView.frmQuanLy()).ShowDialog();
        }

        private void mnuChucDanh_Click(object sender, EventArgs e)
        {
            (new ChucDanhView.frmQuanLy()).ShowDialog();
        }

        private void mnuChucVu_Click(object sender, EventArgs e)
        {
            (new ChucVuView.frmQuanLy()).ShowDialog();
        }

        private void mnuChuyenNganhDaoTao_Click(object sender, EventArgs e)
        {
            (new ChuyenNganhDaoTaoView.frmQuanLy()).ShowDialog();
        }

        private void mnuHinhThucHuongLuong_Click(object sender, EventArgs e)
        {
            (new HinhThucHuongLuongView.frmQuanLy()).ShowDialog();
        }

        private void mnuNhanSu_Click(object sender, EventArgs e)
        {
            (new NhanSu.frmQuanLy()).ShowDialog();
        }

        private void mnuPhongBan_Click(object sender, EventArgs e)
        {
            (new PhongBanView.frmQuanLy()).ShowDialog();
        }


        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
