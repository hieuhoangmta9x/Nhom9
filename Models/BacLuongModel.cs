using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class BacLuongModel
    {
        public int Id { get; set; }
        public string MaBacLuong { get; set; }
        public string TenBacLuong { get; set; }
        public string ThongTinMoTa { get; set; }
        public double HeSoLuong { get; set; }
        public static string TableName = "BacLuong";
    }
}
