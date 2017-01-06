using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;

namespace VB2QLNS.Views.PhuCapView
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private PhuCapController ctrlPhuCap;
        private int id;
        public frmNhapLieu(string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlPhuCap = new PhuCapController();
            id = _id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlPhuCap.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtTenPhuCap.Text = dt.Rows[0]["PhuCap"].ToString();
                txtGiaTri.Text = dt.Rows[0]["GiaTri"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            PhuCapModel obj = new PhuCapModel();
            obj.PhuCap = txtTenPhuCap.Text.Trim();
            obj.GiaTri = txtGiaTri.Text.Trim();

            if (statusAction.Equals("Add"))
            {
                if (ctrlPhuCap.Add(obj))
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
                if (ctrlPhuCap.Edit(obj))
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
