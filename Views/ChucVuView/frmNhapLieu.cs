using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.ChucVuView
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private ChucVuController ctrlChucVu;
        private int id;
        public frmNhapLieu(string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlChucVu = new ChucVuController();
            id = _id;
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlChucVu.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtTenChucVu.Text = dt.Rows[0]["TenChucVu"].ToString();
                txtGhiChu.Text = dt.Rows[0]["GhiChu"].ToString();
                chkKichHoat.Checked = bool.Parse(dt.Rows[0]["KichHoat"].ToString());

            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            ChucVuModel obj = new ChucVuModel();
            obj.TenChucVu = txtTenChucVu.Text.ToString();
            obj.GhiChu = txtGhiChu.Text.ToString();
            obj.KichHoat = chkKichHoat.Checked;


            if (statusAction.Equals("Add"))
            {
                if (ctrlChucVu.Add(obj))
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
                if (ctrlChucVu.Edit(obj))
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
