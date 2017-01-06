using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;
using VB2QLNS.Helper;

namespace VB2QLNS.Views.PhongBanView
{
    public partial class frmNhapLieu : Form
    {
        readonly PhongBanController ctrlPhongBan = new PhongBanController();
        private string statusAction;
        private int id;

        public frmNhapLieu(string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            id = _id;
        }

        public frmNhapLieu()
        {
            InitializeComponent();
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            Dictionary<string, PhongBanModel> dicPhongBan = ctrlPhongBan.FindChildForm(ctrlPhongBan.FindAll(), 1);
            Dictionary<string, string> dicChildForm = new Dictionary<string, string>();
            foreach (string key in dicPhongBan.Keys)
            {
                dicChildForm.Add(key, dicPhongBan[key].TenPhongBan);
            }

            cboPhongBan.DataSource = new BindingSource(dicChildForm, null);
            cboPhongBan.DisplayMember = "Value";
            cboPhongBan.ValueMember = "Key";
            cboPhongBan.SelectedIndex = 0;

            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlPhongBan.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                cboPhongBan.SelectedValue = dt.Rows[0]["ParentId"].ToString();
                txtTenPhongBan.Text = dt.Rows[0]["TenPhongBan"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtSoDienThoai.Text = dt.Rows[0]["SoDienThoai"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            PhongBanModel obj = new PhongBanModel();
            obj.ParentId = int.Parse(((KeyValuePair<string, string>)cboPhongBan.SelectedItem).Key);
            obj.TenPhongBan = txtTenPhongBan.Text.Trim();
            obj.DiaChi = txtDiaChi.Text.Trim();
            obj.SoDienThoai = txtSoDienThoai.Text.Trim();
            obj.Email = txtEmail.Text.Trim();

            if (statusAction.Equals("Add"))
            {
                if (ctrlPhongBan.Add(obj))
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
                if (ctrlPhongBan.Edit(obj))
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
