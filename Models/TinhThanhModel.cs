using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class TinhThanhModel
    {
        public int Id { get; set; }
        public string TenTinhThanh { get; set; }
        public static string TableName = "TinhThanh";
    }
}
