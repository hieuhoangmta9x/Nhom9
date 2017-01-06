using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.BacLuongView
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private BacLuongController ctrlBacLuong;
        private int id;

        public frmNhapLieu(string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlBacLuong = new BacLuongController();
            id = _id;
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlBacLuong.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtMaBacLuong.Text = dt.Rows[0]["MaBacLuong"].ToString();
                txtTenBacLuong.Text = dt.Rows[0]["TenBacLuong"].ToString();
                txtThongTinMoTa.Text = dt.Rows[0]["ThongTinMoTa"].ToString();
                txtHeSoLuong.Text = dt.Rows[0]["HeSoLuong"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            BacLuongModel obj = new BacLuongModel();
            obj.MaBacLuong = txtMaBacLuong.Text.ToString();
            obj.TenBacLuong = txtTenBacLuong.Text.ToString();
            obj.ThongTinMoTa = txtThongTinMoTa.Text.ToString();
            obj.HeSoLuong = float.Parse(txtHeSoLuong.Text.ToString());


            if (statusAction.Equals("Add"))
            {
                if (ctrlBacLuong.Add(obj))
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
                if (ctrlBacLuong.Edit(obj))
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
