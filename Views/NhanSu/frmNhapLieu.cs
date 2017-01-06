using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;
using System.IO;

namespace VB2QLNS.Views.NhanSu
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private int id;

        readonly TinhTrangHonNhanController ctrlTinhTrangHonNhan = new TinhTrangHonNhanController();
        readonly DanTocController ctrlDanToc = new DanTocController();
        readonly TonGiaoController ctrlTonGiao = new TonGiaoController();
        readonly TinhThanhController ctrlTinhThanh = new TinhThanhController();
        readonly QuocGiaController ctrlQuocGia = new QuocGiaController();
        readonly ChucVuController ctrlChucVu = new ChucVuController();
        readonly ChucDanhController ctrlChucDanh = new ChucDanhController();
        readonly PhongBanController ctrlPhongBan = new PhongBanController();
        readonly HinhThucDaoTaoController ctrlHinhThucDaoTao = new HinhThucDaoTaoController();
        readonly ChuyenNganhDaoTaoController ctrlChuyenNganhDaoTao = new ChuyenNganhDaoTaoController();
        readonly TrinhDoNgoaiNguController ctrlTrinhDoNgoaiNgu = new TrinhDoNgoaiNguController();
        readonly TrinhDoTinHocController ctrlTrinhDoTinHoc = new TrinhDoTinHocController();
        readonly TruongDaoTaoController ctrlTruongDaoTao = new TruongDaoTaoController();
        readonly TrinhDoVanHoaController ctrlTrinhDoVanHoa = new TrinhDoVanHoaController();
        readonly NhanSuController ctrlNhanSu = new NhanSuController();

        public frmNhapLieu()
        {
            InitializeComponent();
        }

        public frmNhapLieu(string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            id = _id;
        }

        private void ShowMore()
        {
            Dictionary<string, string> dicInfoSummary = new Dictionary<string, string>();
            dicInfoSummary.Add("info_Id", txtId.Text);
            dicInfoSummary.Add("info_HoTen", txtHoTen.Text);
            dicInfoSummary.Add("info_NgaySinh", dtpNgaySinh.Value.ToString("d-M-yyy"));
            dicInfoSummary.Add("info_SoDienThoai", txtSoDienThoaiDiDong.Text);
            dicInfoSummary.Add("info_TinhThanh", ((KeyValuePair<string, string>)cboTinhThanh.SelectedItem).Value);
            dicInfoSummary.Add("info_QuocGia", ((KeyValuePair<string, string>)cboQuocGia.SelectedItem).Value);
            dicInfoSummary.Add("info_ChucVu", ((KeyValuePair<string, string>)cboChucVu.SelectedItem).Value);
            dicInfoSummary.Add("info_ChucDanh", ((KeyValuePair<string, string>)cboChucDanh.SelectedItem).Value);
            dicInfoSummary.Add("info_PhongBan", ((KeyValuePair<string, string>)cboPhongBan.SelectedItem).Value.Split('>')[1].Trim());

            InfoSummary ucInfoSummary1 = new InfoSummary(dicInfoSummary);
            ucInfoSummary1.Dock = DockStyle.Top;
            QuaTrinhHopDong.frmQuanLy ucQuaTrinhHopDong = new QuaTrinhHopDong.frmQuanLy(int.Parse(txtId.Text));
            ucQuaTrinhHopDong.Dock = DockStyle.Bottom;
            ucQuaTrinhHopDong.Height = 405;
            tabPage2.Controls.AddRange(new Control[] { ucInfoSummary1, ucQuaTrinhHopDong });

            InfoSummary ucInfoSummary2 = new InfoSummary(dicInfoSummary);
            ucInfoSummary2.Dock = DockStyle.Top;
            QuaTrinhLuong.frmQuanLy ucQuaTrinhLuong = new QuaTrinhLuong.frmQuanLy(int.Parse(txtId.Text));
            ucQuaTrinhLuong.Dock = DockStyle.Bottom;
            ucQuaTrinhLuong.Height = 410;
            tabPage3.Controls.AddRange(new Control[] { ucInfoSummary2, ucQuaTrinhLuong });

            InfoSummary ucInfoSummary3 = new InfoSummary(dicInfoSummary);
            ucInfoSummary3.Dock = DockStyle.Top;
            QuaTrinhDaoTao.frmQuanLy ucQuaTrinhDaoTao = new QuaTrinhDaoTao.frmQuanLy(int.Parse(txtId.Text));
            ucQuaTrinhDaoTao.Dock = DockStyle.Bottom;
            ucQuaTrinhDaoTao.Height = 410;
            tabPage4.Controls.AddRange(new Control[] { ucInfoSummary3, ucQuaTrinhDaoTao });

            InfoSummary ucInfoSummary4 = new InfoSummary(dicInfoSummary);
            ucInfoSummary4.Dock = DockStyle.Top;
            QuaTrinhKhenThuong.frmQuanLy ucQuaTrinhKhenThuong = new QuaTrinhKhenThuong.frmQuanLy(int.Parse(txtId.Text));
            ucQuaTrinhKhenThuong.Dock = DockStyle.Bottom;
            ucQuaTrinhKhenThuong.Height = 410;            
            tabPage5.Controls.AddRange(new Control[] { ucInfoSummary4, ucQuaTrinhKhenThuong });

            InfoSummary ucInfoSummary5 = new InfoSummary(dicInfoSummary);
            ucInfoSummary5.Dock = DockStyle.Top;
            QuaTrinhKyLuat.frmQuanLy ucQuaTrinhKyLuat = new QuaTrinhKyLuat.frmQuanLy(int.Parse(txtId.Text));
            ucQuaTrinhKyLuat.Dock = DockStyle.Bottom;
            ucQuaTrinhKyLuat.Height = 410;
            tabPage6.Controls.AddRange(new Control[] { ucInfoSummary5, ucQuaTrinhKyLuat });
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            DataTable dt = ctrlTinhTrangHonNhan.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TinhTrangHonNhan"].ToString());

                cboTinhTrangHonNhan.DataSource = new BindingSource(dic, null);
                cboTinhTrangHonNhan.DisplayMember = "Value";
                cboTinhTrangHonNhan.ValueMember = "Key";
                cboTinhTrangHonNhan.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlDanToc.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenDanToc"].ToString());

                cboDanToc.DataSource = new BindingSource(dic, null);
                cboDanToc.DisplayMember = "Value";
                cboDanToc.ValueMember = "Key";
                cboDanToc.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlTonGiao.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenTonGiao"].ToString());

                cboTonGiao.DataSource = new BindingSource(dic, null);
                cboTonGiao.DisplayMember = "Value";
                cboTonGiao.ValueMember = "Key";
                cboTonGiao.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlTinhThanh.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenTinhThanh"].ToString());

                cboTinhThanh.DataSource = new BindingSource(dic, null);
                cboTinhThanh.DisplayMember = "Value";
                cboTinhThanh.ValueMember = "Key";
                cboTinhThanh.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlQuocGia.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenQuocGia"].ToString());

                cboQuocGia.DataSource = new BindingSource(dic, null);
                cboQuocGia.DisplayMember = "Value";
                cboQuocGia.ValueMember = "Key";
                cboQuocGia.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlQuocGia.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenQuocGia"].ToString());

                cboQuocGia.DataSource = new BindingSource(dic, null);
                cboQuocGia.DisplayMember = "Value";
                cboQuocGia.ValueMember = "Key";
                cboQuocGia.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlChucVu.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenChucVu"].ToString());

                cboChucVu.DataSource = new BindingSource(dic, null);
                cboChucVu.DisplayMember = "Value";
                cboChucVu.ValueMember = "Key";
                cboChucVu.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlChucDanh.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenChucDanh"].ToString());

                cboChucDanh.DataSource = new BindingSource(dic, null);
                cboChucDanh.DisplayMember = "Value";
                cboChucDanh.ValueMember = "Key";
                cboChucDanh.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlHinhThucDaoTao.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenHinhThucDaoTao"].ToString());

                cboHinhThucDaoTao.DataSource = new BindingSource(dic, null);
                cboHinhThucDaoTao.DisplayMember = "Value";
                cboHinhThucDaoTao.ValueMember = "Key";
                cboHinhThucDaoTao.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlChuyenNganhDaoTao.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenChuyenNganhDaoTao"].ToString());

                cboChuyenNganhDaoTao.DataSource = new BindingSource(dic, null);
                cboChuyenNganhDaoTao.DisplayMember = "Value";
                cboChuyenNganhDaoTao.ValueMember = "Key";
                cboChuyenNganhDaoTao.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlTrinhDoNgoaiNgu.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TrinhDoNgoaiNgu"].ToString());

                cboTrinhDoNgoaiNgu.DataSource = new BindingSource(dic, null);
                cboTrinhDoNgoaiNgu.DisplayMember = "Value";
                cboTrinhDoNgoaiNgu.ValueMember = "Key";
                cboTrinhDoNgoaiNgu.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlTrinhDoTinHoc.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TrinhDoTinHoc"].ToString());

                cboTrinhDoTinHoc.DataSource = new BindingSource(dic, null);
                cboTrinhDoTinHoc.DisplayMember = "Value";
                cboTrinhDoTinHoc.ValueMember = "Key";
                cboTrinhDoTinHoc.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlTruongDaoTao.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenTruongDaoTao"].ToString());

                cboTruongDaoTao.DataSource = new BindingSource(dic, null);
                cboTruongDaoTao.DisplayMember = "Value";
                cboTruongDaoTao.ValueMember = "Key";
                cboTruongDaoTao.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlTrinhDoVanHoa.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TrinhDoTotNghiep"].ToString());

                cboTrinhDoVanHoa.DataSource = new BindingSource(dic, null);
                cboTrinhDoVanHoa.DisplayMember = "Value";
                cboTrinhDoVanHoa.ValueMember = "Key";
                cboTrinhDoVanHoa.SelectedIndex = 0;
            }

            Dictionary<string, PhongBanModel> dicPhongBan = ctrlPhongBan.FindChildForm(ctrlPhongBan.FindAll(), 1);
            Dictionary<string, string> dicChildForm = new Dictionary<string, string>();
            foreach (string key in dicPhongBan.Keys)
            {
                dicChildForm.Add(key, dicPhongBan[key].TenPhongBan);
            }

            cboPhongBan.DataSource = new BindingSource(dicChildForm, null);
            cboPhongBan.DisplayMember = "Value";
            cboPhongBan.ValueMember = "Key";
            cboPhongBan.SelectedIndex = 0;


            btnThem.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                dt = ctrlNhanSu.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtHoTen.Text = dt.Rows[0]["HoTen"].ToString();
                txtTenGoiKhac.Text = dt.Rows[0]["TenKhac"].ToString();
                dtpNgaySinh.Value = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
                if (bool.Parse(dt.Rows[0]["GioiTinh"].ToString()))
                    radGioiTinh_Nam.Checked = true;
                else
                    radGioiTinh_Nu.Checked = true;
                txtCMND.Text = dt.Rows[0]["SoCMND"].ToString();
                dtpNgayCapCMND.Value = DateTime.Parse(dt.Rows[0]["NgayCapCMND"].ToString());
                txtNoiCapCMND.Text = dt.Rows[0]["NoiCapCMND"].ToString();
                txtNoiSinh.Text = dt.Rows[0]["NoiSinh"].ToString();
                txtQueQuan.Text = dt.Rows[0]["QueQuan"].ToString();
                txtHoKhauThuongTru.Text = dt.Rows[0]["HoKhauThuongTru"].ToString();
                txtNoiSongHienTai.Text = dt.Rows[0]["NoiSongHienTai"].ToString();
                txtSoDienThoaiDiDong.Text = dt.Rows[0]["SoDienThoaiDiDong"].ToString();
                txtSoDienThoaiBan.Text = dt.Rows[0]["SoDienThoaiBan"].ToString();
                txtEmailCaNhan.Text = dt.Rows[0]["EmailCaNhan"].ToString();
                txtEmailCongTy.Text = dt.Rows[0]["EmailCongTy"].ToString();

                cboTinhTrangHonNhan.SelectedValue = dt.Rows[0]["TinhTrangHonNhanId"].ToString();
                cboDanToc.SelectedValue = dt.Rows[0]["DanTocId"].ToString();
                cboTonGiao.SelectedValue = dt.Rows[0]["TonGiaoId"].ToString();
                cboTinhThanh.SelectedValue = dt.Rows[0]["TinhThanhId"].ToString();
                cboQuocGia.SelectedValue = dt.Rows[0]["QuocGiaId"].ToString();
                cboChucVu.SelectedValue = dt.Rows[0]["ChucVuId"].ToString();
                cboChucDanh.SelectedValue = dt.Rows[0]["ChucDanhId"].ToString();
                cboPhongBan.SelectedValue = dt.Rows[0]["PhongBanId"].ToString();
                cboHinhThucDaoTao.SelectedValue = dt.Rows[0]["HinhThucDaoTaoId"].ToString();
                cboChuyenNganhDaoTao.SelectedValue = dt.Rows[0]["ChuyenNganhDaoTaoId"].ToString();
                cboTrinhDoNgoaiNgu.SelectedValue = dt.Rows[0]["TrinhDoNgoaiNguId"].ToString();
                cboTrinhDoTinHoc.SelectedValue = dt.Rows[0]["TrinhDoTinHocId"].ToString();
                cboTruongDaoTao.SelectedValue = dt.Rows[0]["TruongDaoTaoId"].ToString();
                cboTrinhDoVanHoa.SelectedValue = dt.Rows[0]["TrinhDoVanHoaId"].ToString();

                string pathHinhAnh = Application.StartupPath + dt.Rows[0]["AnhDaiDien"].ToString();
                if (File.Exists(pathHinhAnh))
                {
                    picAnhDaiDien.Image = Image.FromFile(pathHinhAnh);
                }

                ShowMore();
            }
            else
            {
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);
                tabControl1.TabPages.Remove(tabPage6);
            }
        }

        private void btnAnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofd.DefaultExt = ".png"; // Default file extension 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnhDaiDien.Image = Image.FromFile(ofd.FileName);
                txtAnhDaiDien.Text = ofd.FileName;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanSuModel obj = new NhanSuModel();
            obj.HoTen = txtHoTen.Text.Trim();
            obj.TenKhac = txtTenGoiKhac.Text.Trim();
            obj.AnhDaiDien = txtAnhDaiDien.Text.Trim();
            obj.NgaySinh = dtpNgaySinh.Value;
            obj.GioiTinh = radGioiTinh_Nam.Checked ? true : false;
            obj.SoCMND = txtCMND.Text.Trim();
            obj.NgayCapCMND = dtpNgayCapCMND.Value;
            obj.NoiCapCMND = txtNoiCapCMND.Text.Trim();
            obj.NoiSinh = txtNoiSinh.Text.Trim();
            obj.QueQuan = txtQueQuan.Text.Trim();
            obj.HoKhauThuongTru = txtHoKhauThuongTru.Text.Trim();
            obj.NoiSongHienTai = txtNoiSongHienTai.Text.Trim();
            obj.SoDienThoaiDiDong = txtSoDienThoaiDiDong.Text.Trim();
            obj.SoDienThoaiBan = txtSoDienThoaiBan.Text.Trim();
            obj.EmailCaNhan = txtEmailCaNhan.Text.Trim();
            obj.EmailCongTy = txtEmailCongTy.Text.Trim();
            obj.TinhTrangHonNhanId = int.Parse(((KeyValuePair<string, string>)cboTinhTrangHonNhan.SelectedItem).Key);
            obj.DanTocId = int.Parse(((KeyValuePair<string, string>)cboDanToc.SelectedItem).Key);
            obj.TonGiaoId = int.Parse(((KeyValuePair<string, string>)cboTonGiao.SelectedItem).Key);
            obj.TinhThanhId = int.Parse(((KeyValuePair<string, string>)cboTinhThanh.SelectedItem).Key);
            obj.QuocGiaId = int.Parse(((KeyValuePair<string, string>)cboQuocGia.SelectedItem).Key);
            obj.ChucVuId = int.Parse(((KeyValuePair<string, string>)cboChucVu.SelectedItem).Key);
            obj.ChucDanhId = int.Parse(((KeyValuePair<string, string>)cboChucDanh.SelectedItem).Key);
            obj.PhongBanId = int.Parse(((KeyValuePair<string, string>)cboPhongBan.SelectedItem).Key);
            obj.HinhThucDaoTaoId = int.Parse(((KeyValuePair<string, string>)cboHinhThucDaoTao.SelectedItem).Key);
            obj.ChuyenNganhDaoTaoId = int.Parse(((KeyValuePair<string, string>)cboChuyenNganhDaoTao.SelectedItem).Key);
            obj.TrinhDoNgoaiNguId = int.Parse(((KeyValuePair<string, string>)cboTrinhDoNgoaiNgu.SelectedItem).Key);
            obj.TrinhDoTinHocId = int.Parse(((KeyValuePair<string, string>)cboTrinhDoTinHoc.SelectedItem).Key);
            obj.TruongDaoTaoId = int.Parse(((KeyValuePair<string, string>)cboTruongDaoTao.SelectedItem).Key);
            obj.TrinhDoVanHoaId = int.Parse(((KeyValuePair<string, string>)cboTrinhDoVanHoa.SelectedItem).Key);


            if (txtAnhDaiDien.Text.Trim() != "")
            {
                obj.AnhDaiDien = Helper.Component.GetMovePathImage(txtAnhDaiDien.Text);
                File.Copy(txtAnhDaiDien.Text, Application.StartupPath + obj.AnhDaiDien);
            }
            else
            {
                obj.AnhDaiDien = "";
            }

            if (statusAction.Equals("Add"))
            {
                if (ctrlNhanSu.Add(obj))
                {
                    MessageBox.Show("Thao tác thành công!", "Thông báo...");
                    this.Close();

                    if (MessageBox.Show("Bạn có muốn cập nhật thêm thông tin cho nhân sự này ?", "Thông báo...", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                    {
                        tabControl1.TabPages.Add(tabPage2);
                        tabControl1.TabPages.Add(tabPage3);
                        tabControl1.TabPages.Add(tabPage4);
                        tabControl1.TabPages.Add(tabPage5);
                        tabControl1.TabPages.Add(tabPage6);

                        ShowMore();
                    } else
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Thao tác đã xẩy ra lỗi ! Xin vui lòng kiểm tra lại !", "Thông báo...");
                }
            }
            else
            {
                obj.Id = id;
                if (ctrlNhanSu.Edit(obj))
                {
                    MessageBox.Show("Thao tác thành công!", "Thông báo...");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thao tác đã xẩy ra lỗi ! Xin vui lòng kiểm tra lại !", "Thông báo...");
                }
            }
        }

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
