using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class ViTriTuyenDungModel
    {
        public int Id { get; set; }
        public string TenViTriTuyenDung { get; set; }
        public bool TrangThaiSuDung { get; set; }
        public static string TableName = "ViTriTuyenDung";

    }
}
