using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class ChucVuModel
    {
        public int Id { get; set; }
        public string TenChucVu { get; set; }
        public string GhiChu { get; set; }
        public bool TrangThaiSuDung { get; set; }        
        public bool KichHoat { get; set; }
        public static string TableName = "ChucVu";
    }
}
