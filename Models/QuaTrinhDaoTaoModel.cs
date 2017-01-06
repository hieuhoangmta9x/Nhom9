using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class QuaTrinhDaoTaoModel
    {
        public int Id { get; set; }
        public int NhanSuId { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string Loai { get; set; }
        public string HinhThuc { get; set; }
        public string ChuyenNganh { get; set; }
        public string ChungChi { get; set; }
        public string TenTruongDaoTao { get; set; }
        public string NuocDaoTao { get; set; }
        public static string TableName = "NhanSu_QuaTrinhDaoTao";
    }
}
