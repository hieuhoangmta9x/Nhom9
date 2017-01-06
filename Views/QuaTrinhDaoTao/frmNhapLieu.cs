using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.QuaTrinhDaoTao
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private QuaTrinhDaoTaoController ctrlQuaTrinhDaoTao;
        private int id;
        private int nhanSuId;

        public frmNhapLieu(int nhanSuId,string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlQuaTrinhDaoTao = new QuaTrinhDaoTaoController();
            id = _id;
            this.nhanSuId = nhanSuId;
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlQuaTrinhDaoTao.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();

                dtpTuNgay.Value = DateTime.Parse(dt.Rows[0]["TuNgay"].ToString());
                dtpDenNgay.Value = DateTime.Parse(dt.Rows[0]["DenNgay"].ToString());
                txtLoai.Text = dt.Rows[0]["Loai"].ToString();
                txtChungChi.Text = dt.Rows[0]["ChungChi"].ToString();
                txtChuyenNganh.Text = dt.Rows[0]["ChuyenNganh"].ToString();
                txtHinhThuc.Text = dt.Rows[0]["HinhThuc"].ToString();
                txtTruongDaoTao.Text = dt.Rows[0]["TenTruongDaoTao"].ToString();
                txtNuocDaoTao.Text = dt.Rows[0]["NuocDaoTao"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QuaTrinhDaoTaoModel obj = new QuaTrinhDaoTaoModel();
            obj.NhanSuId = nhanSuId;
            obj.TuNgay = dtpTuNgay.Value;
            obj.DenNgay = dtpDenNgay.Value;
            obj.Loai = txtLoai.Text.Trim();
            obj.HinhThuc = txtHinhThuc.Text.Trim();
            obj.ChuyenNganh = txtChuyenNganh.Text.Trim();
            obj.ChungChi = txtChungChi.Text.Trim();
            obj.TenTruongDaoTao = txtTruongDaoTao.Text.Trim();
            obj.NuocDaoTao = txtNuocDaoTao.Text.Trim();

            if (statusAction.Equals("Add"))
            {
                if (ctrlQuaTrinhDaoTao.Add(obj))
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
                if (ctrlQuaTrinhDaoTao.Edit(obj))
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
