using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VB2QLNS.Views.NhanSu
{
    public partial class InfoSummary : UserControl
    {
        public InfoSummary()
        {
            InitializeComponent();
        }

        public InfoSummary(Dictionary<string, string> dicInfo)
        {
            InitializeComponent();
            txtId.Text = dicInfo["info_Id"];
            txtHoTen.Text = dicInfo["info_HoTen"];
            txtNgaySinh.Text = dicInfo["info_NgaySinh"];
            txtSoDienThoai.Text = dicInfo["info_SoDienThoai"];
            txtTinhThanh.Text = dicInfo["info_TinhThanh"];
            txtQuocGia.Text = dicInfo["info_QuocGia"];
            txtChucVu.Text = dicInfo["info_ChucVu"];
            txtChucDanh.Text = dicInfo["info_ChucDanh"];
            txtPhongBan.Text = dicInfo["info_PhongBan"];
        }
    }
}
