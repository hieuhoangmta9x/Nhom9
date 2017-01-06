using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class HinhThucTuyenDungModel
    {
        public int Id { get; set; }
        public string TenHinhThucTuyenDung { get; set; }
        public static string TableName = "HinhThucTuyenDung";
    }
}
