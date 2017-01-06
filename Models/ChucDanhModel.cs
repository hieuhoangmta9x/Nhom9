using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class ChucDanhModel
    {
        public int Id { get; set; }
        public string TenChucDanh { get; set; }
        public string TenVietTat { get; set; }
        public string ThongTinMoTa { get; set; }
        public bool KichHoat { get; set; }
        public static string TableName = "ChucDanh";
    }
}
