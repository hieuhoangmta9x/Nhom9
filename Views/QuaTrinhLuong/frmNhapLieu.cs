using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.QuaTrinhLuong
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private int id;
        private int nhanSuId;

        readonly QuaTrinhLuongController ctrlQuaTrinhLuong;
        readonly HinhThucHuongLuongController ctrlHinhThucHuongLuong = new HinhThucHuongLuongController();
        readonly BacLuongController ctrlBacLuong = new BacLuongController();

        public frmNhapLieu(int nhanSuId, string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlQuaTrinhLuong = new QuaTrinhLuongController();
            id = _id;
            this.nhanSuId = nhanSuId;
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            DataTable dt = ctrlHinhThucHuongLuong.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenHinhThucHuongLuong"].ToString());

                cboHinhThucHuongLuong.DataSource = new BindingSource(dic, null);
                cboHinhThucHuongLuong.DisplayMember = "Value";
                cboHinhThucHuongLuong.ValueMember = "Key";
                cboHinhThucHuongLuong.SelectedIndex = 0;
            }

            dic = new Dictionary<string, string>();
            dt = ctrlBacLuong.FindAll();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                    dic.Add(row["Id"].ToString(), row["TenBacLuong"].ToString());

                cboBacLuong.DataSource = new BindingSource(dic, null);
                cboBacLuong.DisplayMember = "Value";
                cboBacLuong.ValueMember = "Key";
                cboBacLuong.SelectedIndex = 0;
            }

            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                dt = ctrlQuaTrinhLuong.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();

                cboHinhThucHuongLuong.SelectedValue = dt.Rows[0]["HinhThucHuongLuongId"].ToString();

                cboBacLuong.SelectedValue = dt.Rows[0]["BacLuongId"].ToString();

                dtpTuNgay.Value = DateTime.Parse(dt.Rows[0]["TuNgay"].ToString());
                dtpDenNgay.Value = DateTime.Parse(dt.Rows[0]["DenNgay"].ToString());
                txtTienLuong.Text = dt.Rows[0]["TienLuong"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QuaTrinhLuongModel obj = new QuaTrinhLuongModel();
            obj.NhanSuId = nhanSuId;
            obj.HinhThucHuongLuongId = int.Parse(((KeyValuePair<string, string>)cboHinhThucHuongLuong.SelectedItem).Key);
            obj.BacLuongId = int.Parse(((KeyValuePair<string, string>)cboBacLuong.SelectedItem).Key);
            obj.TuNgay = dtpTuNgay.Value;
            obj.DenNgay = dtpDenNgay.Value;
            obj.TienLuong = float.Parse(txtTienLuong.Text);

            if (statusAction.Equals("Add"))
            {
                if (ctrlQuaTrinhLuong.Add(obj))
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
                if (ctrlQuaTrinhLuong.Edit(obj))
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

        private void txtTienLuong_KeyPress(object sender, KeyPressEventArgs e)
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
