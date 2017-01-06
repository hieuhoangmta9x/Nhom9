using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.ChucDanhView
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private ChucDanhController ctrlChucDanh;
        private int id;
        public frmNhapLieu(string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlChucDanh = new ChucDanhController();
            id = _id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlChucDanh.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtTenChucDanh.Text = dt.Rows[0]["TenChucDanh"].ToString();
                txtTenVietTat.Text = dt.Rows[0]["TenVietTat"].ToString();
                txtThongTinMoTa.Text = dt.Rows[0]["ThongTinMoTa"].ToString();
                chkKichHoat.Checked = bool.Parse(dt.Rows[0]["TrangThaiSuDung"].ToString());

            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            ChucDanhModel obj = new ChucDanhModel();
            obj.TenChucDanh = txtTenChucDanh.Text.ToString();
            obj.TenVietTat = txtTenVietTat.Text.ToString();
            obj.ThongTinMoTa = txtThongTinMoTa.Text.ToString();
            obj.KichHoat = chkKichHoat.Checked;


            if (statusAction.Equals("Add"))
            {
                if (ctrlChucDanh.Add(obj))
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
                if (ctrlChucDanh.Edit(obj))
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
