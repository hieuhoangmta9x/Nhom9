using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;
using VB2QLNS.Helper;

namespace VB2QLNS.Views.NhanSu
{
    public partial class frmQuanLy : Form
    {
        public static DataGridViewRow selectCurrRow = null;
        private bool isPopup = false;

        readonly NhanSuController ctrlNhanSu = new NhanSuController();
        readonly PhongBanController ctrlPhongBan = new PhongBanController();
        readonly TinhTrangHonNhanController ctrlTinhTrangHonNhan = new TinhTrangHonNhanController();
        readonly DanTocController ctrlDanToc = new DanTocController();
        readonly TonGiaoController ctrlTonGiao = new TonGiaoController();
        readonly TinhThanhController ctrlTinhThanh = new TinhThanhController();
        readonly QuocGiaController ctrlQuocGia = new QuocGiaController();
        readonly ChucVuController ctrlChucVu = new ChucVuController();
        readonly ChucDanhController ctrlChucDanh = new ChucDanhController();
        readonly HinhThucDaoTaoController ctrlHinhThucDaoTao = new HinhThucDaoTaoController();
        readonly ChuyenNganhDaoTaoController ctrlChuyenNganhDaoTao = new ChuyenNganhDaoTaoController();
        readonly TrinhDoNgoaiNguController ctrlTrinhDoNgoaiNgu = new TrinhDoNgoaiNguController();
        readonly TrinhDoTinHocController ctrlTrinhDoTinHoc = new TrinhDoTinHocController();
        readonly TruongDaoTaoController ctrlTruongDaoTao = new TruongDaoTaoController();
        readonly TrinhDoVanHoaController ctrlTrinhDoVanHoa = new TrinhDoVanHoaController();

        public frmQuanLy()
        {
            InitializeComponent();
            this.dgwv.ForeColor = System.Drawing.Color.Black;
        }

        private void LoadData(DataTable dt)
        {
            dgwv.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgwv.Rows.Add(
                    row["AnhDaiDien"].ToString() == "" ? null : Image.FromFile(Application.StartupPath + row["AnhDaiDien"].ToString()),
                    row["Id"].ToString(),
                    row["HoTen"].ToString(),
                    row["TenPhongBan"].ToString(),
                    row["TenChucVu"].ToString(),
                    row["TenChucDanh"].ToString(),
                    row["EmailCongTy"].ToString(),
                    row["SoDienThoaiDiDong"].ToString(),
                    DateTime.Parse(row["NgaySinh"].ToString()).ToString("d-M-yyy"),
                    row["TrinhDoTotNghiep"].ToString(),
                    row["TrinhDoNgoaiNgu"].ToString(),
                    row["TrinhDoTinHoc"].ToString(),
                    row["TenTinhThanh"].ToString(),
                    row["TenQuocGia"].ToString()
                );
            }

            dgwv.Refresh();
            labelStatus.Text = "Có tổng số " + dt.Rows.Count + " bản ghi";
        }

        private void LoadDataNhanSu()
        {
            string contentSearch = txtNoiDungTimKiem.Text.Trim();
            int phongBanIdSelect = int.Parse(((KeyValuePair<string, string>)cboPhongBan.SelectedItem).Key);
            int TinhTrangHonNhanId = int.Parse(((KeyValuePair<string, string>)cboTinhTrangHonNhan.SelectedItem).Key);
            int TinhThanhId = int.Parse(((KeyValuePair<string, string>)cboTinhThanh.SelectedItem).Key);
            int QuocGiaId = int.Parse(((KeyValuePair<string, string>)cboQuocGia.SelectedItem).Key);
            int ChucVuId = int.Parse(((KeyValuePair<string, string>)cboChucVu.SelectedItem).Key);
            int ChucDanhId = int.Parse(((KeyValuePair<string, string>)cboChucDanh.SelectedItem).Key);
            int PhongBanId = int.Parse(((KeyValuePair<string, string>)cboPhongBan.SelectedItem).Key);
            int HinhThucDaoTaoId = int.Parse(((KeyValuePair<string, string>)cboHinhThucDaoTao.SelectedItem).Key);
            int ChuyenNganhDaoTaoId = int.Parse(((KeyValuePair<string, string>)cboChuyenNganhDaoTao.SelectedItem).Key);
            int TrinhDoNgoaiNguId = int.Parse(((KeyValuePair<string, string>)cboTrinhDoNgoaiNgu.SelectedItem).Key);
            int TrinhDoTinHocId = int.Parse(((KeyValuePair<string, string>)cboTrinhDoTinHoc.SelectedItem).Key);
            int TrinhDoVanHoaId = int.Parse(((KeyValuePair<string, string>)cboTrinhDoVanHoa.SelectedItem).Key);
            int fromAge = txtFromAge.Text.Trim() == "" ? 0 : int.Parse(txtFromAge.Text.Trim());
            int toAge = txtToAge.Text.Trim() == "" ? 100 : int.Parse(txtToAge.Text.Trim());

            LoadData(ctrlNhanSu.AdvanceSearch(
                ctrlPhongBan.GetChildIds(phongBanIdSelect),
                contentSearch,
                TinhTrangHonNhanId,
                TinhThanhId,
                QuocGiaId,
                ChucVuId,
                ChucDanhId,
                HinhThucDaoTaoId,
                ChuyenNganhDaoTaoId,
                TrinhDoNgoaiNguId,
                TrinhDoTinHocId,
                TrinhDoVanHoaId,
                fromAge,
                toAge
            ));
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            //LoadData(ctrlNhanSu.FindAll(NhanSuPrefixProc.FindAll));

            Dictionary<string, string> dicChildForm = new Dictionary<string, string>();
            Dictionary<string, PhongBanModel> dicPhongBan = ctrlPhongBan.FindChildForm(ctrlPhongBan.FindAll(), 1);
            DataTable dt = ctrlPhongBan.FindById(1);
            //dicChildForm.Add("1", "> Tất cả phòng ban");            

            foreach (string key in dicPhongBan.Keys)
            {
                dicChildForm.Add(key, key == "1" ? "> Tất cả phòng ban" : dicPhongBan[key].TenPhongBan);
                //dicChildForm.Add(key, dicPhongBan[key].TenPhongBan);
            }

            cboPhongBan.DataSource = new BindingSource(dicChildForm, null);
            cboPhongBan.DisplayMember = "Value";
            cboPhongBan.ValueMember = "Key";
            cboPhongBan.SelectedIndex = 0;


            Dictionary<string, string> dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
            dt = ctrlTinhTrangHonNhan.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TinhTrangHonNhan"].ToString());

                cboTinhTrangHonNhan.DataSource = new BindingSource(dic, null);
                cboTinhTrangHonNhan.DisplayMember = "Value";
                cboTinhTrangHonNhan.ValueMember = "Key";
                cboTinhTrangHonNhan.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
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

            dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
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

            dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
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

            dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
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

            dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
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

            dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
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

            dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
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

            dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
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

            dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
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

            dic = new Dictionary<string, string>(); dic.Add("0", "Tất cả");
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

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            (new frmNhapLieu("Add")).ShowDialog();

            int phongBanIdSelect = int.Parse(((KeyValuePair<string, string>)cboPhongBan.SelectedItem).Key);
            LoadData(ctrlNhanSu.FindAllByPhongBan(ctrlPhongBan.GetChildIds(phongBanIdSelect)));
        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int phongBanIdSelect = int.Parse(((KeyValuePair<string, string>)cboPhongBan.SelectedItem).Key);
            LoadData(ctrlNhanSu.FindAllByPhongBan(ctrlPhongBan.GetChildIds(phongBanIdSelect)));
        }

        private void dgwv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (!isPopup)
                {
                    int idRecord = int.Parse(dgwv.CurrentRow.Cells[0].Value.ToString());
                    frmNhapLieu frm = new frmNhapLieu("Edit", idRecord);
                    frm.ShowDialog();
                    LoadDataNhanSu();
                }
                else
                {
                    selectCurrRow = dgwv.CurrentRow;
                    this.Close();
                }
            }
        }

        private void dgwv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                ContextMenuStrip m = new ContextMenuStrip();
                int positionMouseRow = dgwv.HitTest(e.X, e.Y).RowIndex;
                if (positionMouseRow >= 0)
                {
                    //Image newImage = Image.FromFile("D:\\apple-touch-icon-144x144-precomposed.png");
                    dgwv.Rows[positionMouseRow].Selected = true;
                    m.Items.Add("Sửa").Name = "Edit";
                    m.Items.Add("Xóa").Name = "Delete";
                }
                m.Show(dgwv, new Point(e.X, e.Y));

                m.ItemClicked += new ToolStripItemClickedEventHandler(m_ItemClicked);
            }
        }
        private void m_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmNhapLieu frm;
            int idRecord = int.Parse(dgwv.CurrentRow.Cells[1].Value.ToString());
            switch (e.ClickedItem.Name.ToString())
            {
                case "Edit":
                    frm = new frmNhapLieu("Edit", idRecord);
                    frm.ShowDialog();
                    break;
                case "Delete":
                    ((ContextMenuStrip)sender).Hide();
                    if (MessageBox.Show("Bạn có muốn xóa bản ghi này?", "Thông báo...", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                    {
                        ctrlPhongBan.Delete(new PhongBanModel() { Id = idRecord });
                    }
                    break;
            }
            btnThem_Click(sender, e);
        }

        private void txtNoiDungTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string contentSearch = txtNoiDungTimKiem.Text.Trim();
            int phongBanIdSelect = int.Parse(((KeyValuePair<string, string>)cboPhongBan.SelectedItem).Key);
            int TinhTrangHonNhanId = int.Parse(((KeyValuePair<string, string>)cboTinhTrangHonNhan.SelectedItem).Key);
            int TinhThanhId = int.Parse(((KeyValuePair<string, string>)cboTinhThanh.SelectedItem).Key);
            int QuocGiaId = int.Parse(((KeyValuePair<string, string>)cboQuocGia.SelectedItem).Key);
            int ChucVuId = int.Parse(((KeyValuePair<string, string>)cboChucVu.SelectedItem).Key);
            int ChucDanhId = int.Parse(((KeyValuePair<string, string>)cboChucDanh.SelectedItem).Key);
            int PhongBanId = int.Parse(((KeyValuePair<string, string>)cboPhongBan.SelectedItem).Key);
            int HinhThucDaoTaoId = int.Parse(((KeyValuePair<string, string>)cboHinhThucDaoTao.SelectedItem).Key);
            int ChuyenNganhDaoTaoId = int.Parse(((KeyValuePair<string, string>)cboChuyenNganhDaoTao.SelectedItem).Key);
            int TrinhDoNgoaiNguId = int.Parse(((KeyValuePair<string, string>)cboTrinhDoNgoaiNgu.SelectedItem).Key);
            int TrinhDoTinHocId = int.Parse(((KeyValuePair<string, string>)cboTrinhDoTinHoc.SelectedItem).Key);
            int TrinhDoVanHoaId = int.Parse(((KeyValuePair<string, string>)cboTrinhDoVanHoa.SelectedItem).Key);
            int fromAge = txtFromAge.Text.Trim() == "" ? 0 : int.Parse(txtFromAge.Text.Trim());
            int toAge = txtToAge.Text.Trim() == "" ? 100 : int.Parse(txtToAge.Text.Trim());

            LoadData(ctrlNhanSu.AdvanceSearch(
                ctrlPhongBan.GetChildIds(phongBanIdSelect),
                contentSearch,
                TinhTrangHonNhanId,
                TinhThanhId,
                QuocGiaId,
                ChucVuId,
                ChucDanhId,
                HinhThucDaoTaoId,
                ChuyenNganhDaoTaoId,
                TrinhDoNgoaiNguId,
                TrinhDoTinHocId,
                TrinhDoVanHoaId,
                fromAge,
                toAge
            ));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void txtFromAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') { e.Handled = true; }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtToAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') { e.Handled = true; }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
