using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.HinhThucTuyenDungView
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private HinhThucTuyenDungController ctrlHinhThucTuyenDung;
        private int id;

        public frmNhapLieu(string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlHinhThucTuyenDung = new HinhThucTuyenDungController();
            id = _id;
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlHinhThucTuyenDung.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtTenHinhThucTuyenDung.Text = dt.Rows[0]["TenHinhThucTuyenDung"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            HinhThucTuyenDungModel obj = new HinhThucTuyenDungModel();
            obj.TenHinhThucTuyenDung = txtTenHinhThucTuyenDung.Text.Trim();

            if (statusAction.Equals("Add"))
            {
                if (ctrlHinhThucTuyenDung.Add(obj))
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
                if (ctrlHinhThucTuyenDung.Edit(obj))
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
