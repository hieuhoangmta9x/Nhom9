using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class QuaTrinhLuongModel
    {
        public int Id { get; set; }
        public int NhanSuId { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public int HinhThucHuongLuongId { get; set; }
        public int BacLuongId { get; set; }
        public float TienLuong { get; set; }
        public static string TableName = "NhanSu_QuaTrinhLuong";
    }
}
