using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class QuaTrinhHopDongModel
    {
        public int Id { get; set; }
        public int NhanSuId { get; set; }
        public int LoaiHopDongId { get; set; }
        public int ChucVuId { get; set; }
        public int PhongBanId { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string GhiChu { get; set; }
        public static string TableName = "NhanSu_QuaTrinhHopDong";
    }
}
