using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class PhongBanModel
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string TenPhongBan { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public static string TableName = "PhongBan";
    }
}
