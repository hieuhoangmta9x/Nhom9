using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class LoaiHopDongModel
    {
        public int Id { get; set; }
        public string TenLoaiHopDong { get; set; }
        public static string TableName = "LoaiHopDong";
    }
}
