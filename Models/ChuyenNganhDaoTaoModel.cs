using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class ChuyenNganhDaoTaoModel
    {
        public int Id { get; set; }
        public string MaChuyenNganhDaoTao { get; set; }
        public string TenChuyenNganhDaoTao { get; set; }
        public string ThongTinMoTa { get; set; }
        public bool TrangThaiSuDung { get; set; }
        public static string TableName = "ChuyenNganhDaoTao";

        public bool KichHoat { get; set; }
    }
}
