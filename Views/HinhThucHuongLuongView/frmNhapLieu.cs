using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;


namespace VB2QLNS.Views.HinhThucHuongLuongView
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private HinhThucHuongLuongController ctrlHinhThucHuongLuong;
        private int id;

        public frmNhapLieu(string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlHinhThucHuongLuong = new HinhThucHuongLuongController();
            id = _id;
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlHinhThucHuongLuong.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtTenHinhThucHuongLuong.Text = dt.Rows[0]["TenHinhThucHuongLuong"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            HinhThucHuongLuongModel obj = new HinhThucHuongLuongModel();
            obj.TenHinhThucHuongLuong = txtTenHinhThucHuongLuong.Text.Trim();

            if (statusAction.Equals("Add"))
            {
                if (ctrlHinhThucHuongLuong.Add(obj))
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
                if (ctrlHinhThucHuongLuong.Edit(obj))
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
