using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VB2QLNS.Models;
using VB2QLNS.Controllers;


namespace VB2QLNS.Views.ChuyenNganhDaoTaoView
{
    public partial class frmNhapLieu : Form
    {
        private string statusAction;
        private ChuyenNganhDaoTaoController ctrlChuyenNganhDaoTao;
        private int id;
        public frmNhapLieu(string _statusAction, int _id = -1)
        {
            InitializeComponent();
            statusAction = _statusAction;
            ctrlChuyenNganhDaoTao = new ChuyenNganhDaoTaoController();
            id = _id;
        }

        private void frmNhapLieu_Load(object sender, EventArgs e)
        {
            btnXacNhan.Text = statusAction.Equals("Add") ? "Thêm" : "Sửa";

            if (id != -1)
            {
                DataTable dt = ctrlChuyenNganhDaoTao.FindById(id);
                txtId.Text = dt.Rows[0]["Id"].ToString();
                txtMaChuyenNganhDaoTao.Text = dt.Rows[0]["MaChuyenNganhDaoTao"].ToString();
                txtTenChuyenNganhDaoTao.Text = dt.Rows[0]["TenChuyenNganhDaoTao"].ToString();
                txtThongTinMoTa.Text = dt.Rows[0]["ThongTinMoTa"].ToString();
                chkKichHoat.Checked = bool.Parse(dt.Rows[0]["KichHoat"].ToString());

            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            ChuyenNganhDaoTaoModel obj = new ChuyenNganhDaoTaoModel();
            obj.MaChuyenNganhDaoTao = txtMaChuyenNganhDaoTao.Text.ToString();
            obj.TenChuyenNganhDaoTao = txtTenChuyenNganhDaoTao.Text.ToString();
            obj.ThongTinMoTa = txtThongTinMoTa.Text.ToString();
            obj.KichHoat = chkKichHoat.Checked;
            if (statusAction.Equals("Add"))
            {
                if (ctrlChuyenNganhDaoTao.Add(obj))
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
                if (ctrlChuyenNganhDaoTao.Edit(obj))
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
