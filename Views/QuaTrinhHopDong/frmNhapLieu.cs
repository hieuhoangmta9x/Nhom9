using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.QuaTrinhHopDong
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private int id;
        private int nhanSuId;

        readonly QuaTrinhHopDongController ctrlQuaTrinhHopDong;
        readonly LoaiHopDongController ctrlLoaiHopDong = new LoaiHopDongController();
        readonly ChucVuController ctrlChucVu = new ChucVuController();
        readonly PhongBanController ctrlPhongBan = new PhongBanController();

        public frmNhapLieu(int _nhanSuId, string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlQuaTrinhHopDong = new QuaTrinhHopDongController();
            id = _id;
            nhanSuId = _nhanSuId;
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            DataTable dt = ctrlLoaiHopDong.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenLoaiHopDong"].ToString());

                cboLoaiHopDong.DataSource = new BindingSource(dic, null);
                cboLoaiHopDong.DisplayMember = "Value";
                cboLoaiHopDong.ValueMember = "Key";
                cboLoaiHopDong.SelectedIndex = 0;
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

            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                dt = ctrlQuaTrinhHopDong.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                dtpTuNgay.Value = DateTime.Parse(dt.Rows[0]["TuNgay"].ToString());
                dtpDenNgay.Value = DateTime.Parse(dt.Rows[0]["DenNgay"].ToString());
                txtGhiChu.Text = dt.Rows[0]["GhiChu"].ToString();
                cboChucVu.SelectedValue = dt.Rows[0]["ChucVuId"].ToString();
                cboLoaiHopDong.SelectedValue = dt.Rows[0]["LoaiHopDongId"].ToString();
                cboPhongBan.SelectedValue = dt.Rows[0]["PhongBanId"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QuaTrinhHopDongModel obj = new QuaTrinhHopDongModel();
            obj.NhanSuId = nhanSuId;
            obj.ChucVuId = int.Parse(((KeyValuePair<string, string>)cboChucVu.SelectedItem).Key);
            obj.LoaiHopDongId = int.Parse(((KeyValuePair<string, string>)cboLoaiHopDong.SelectedItem).Key);
            obj.PhongBanId = int.Parse(((KeyValuePair<string, string>)cboPhongBan.SelectedItem).Key);
            obj.TuNgay = dtpTuNgay.Value;
            obj.DenNgay = dtpDenNgay.Value;
            obj.GhiChu = txtGhiChu.Text;

            if (statusAction.Equals("Add"))
            {
                if (ctrlQuaTrinhHopDong.Add(obj))
                {
                    MessageBox.Show("Thao tác thành công!", "Thông báo...");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thao tác đã xẩy ra lỗi ! Xin vui lòng kiểm tra lại !", "Thông báo...");
                }
            }
            else
            {
                obj.Id = id;
                if (ctrlQuaTrinhHopDong.Edit(obj))
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

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
