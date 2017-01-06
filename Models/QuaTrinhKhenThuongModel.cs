using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class QuaTrinhKhenThuongModel
    {
        public int Id { get; set; }
        public int NhanSuId { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string HinhThuc { get; set; }
        public string LyDo { get; set; }
        public float GiaTri { get; set; }
        public static string TableName = "NhanSu_QuaTrinhKhenThuong";
    }
}
