using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class TrangThaiHopDongModel
    {
        public int Id { get; set; }
        public string TenTrangThaiHD { get; set; }
        public static string TableName = "TrangThaiHopDong";
    }
}
