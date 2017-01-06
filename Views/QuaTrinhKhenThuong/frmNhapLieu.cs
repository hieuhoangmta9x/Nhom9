using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.QuaTrinhKhenThuong
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private int id;
        private int nhanSuId;

        readonly QuaTrinhKhenThuongController ctrlQuaTrinhKhenThuong = new QuaTrinhKhenThuongController();

        public frmNhapLieu(int nhanSuId, string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            id = _id;
            this.nhanSuId = nhanSuId;
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlQuaTrinhKhenThuong.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                dtpTuNgay.Value = DateTime.Parse(dt.Rows[0]["TuNgay"].ToString());
                dtpDenNgay.Value = DateTime.Parse(dt.Rows[0]["DenNgay"].ToString());
                txtHinhThuc.Text = dt.Rows[0]["HinhThuc"].ToString();
                txtLyDo.Text = dt.Rows[0]["LyDo"].ToString();
                txtGiaTri.Text = dt.Rows[0]["GiaTri"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QuaTrinhKhenThuongModel obj = new QuaTrinhKhenThuongModel();
            obj.NhanSuId = nhanSuId;
            obj.HinhThuc = txtHinhThuc.Text.Trim();
            obj.LyDo = txtLyDo.Text.Trim();
            obj.TuNgay = dtpTuNgay.Value;
            obj.DenNgay = dtpDenNgay.Value;
            obj.GiaTri = float.Parse(txtGiaTri.Text.Trim());

            if (statusAction.Equals("Add"))
            {
                if (ctrlQuaTrinhKhenThuong.Add(obj))
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
                if (ctrlQuaTrinhKhenThuong.Edit(obj))
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

        private void txtGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
