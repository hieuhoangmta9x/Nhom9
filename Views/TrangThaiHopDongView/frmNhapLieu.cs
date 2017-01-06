using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.TrangThaiHopDongView
{

    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private TrangThaiHopDongController ctrlTrangThaiHopDong;
        private int id;
        public frmNhapLieu(string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlTrangThaiHopDong = new TrangThaiHopDongController();
            id = _id;
        }
        public frmNhapLieu()
        {
            // TODO: Complete member initialization
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlTrangThaiHopDong.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtTenTrangThaiHD.Text = dt.Rows[0]["TenTrangThaiHD"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            TrangThaiHopDongModel obj = new TrangThaiHopDongModel();
            obj.TenTrangThaiHD = txtTenTrangThaiHD.Text.Trim();

            if (statusAction.Equals("Add"))
            {
                if (ctrlTrangThaiHopDong.Add(obj))
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
                if (ctrlTrangThaiHopDong.Edit(obj))
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
