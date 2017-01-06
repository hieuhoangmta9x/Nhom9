using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class HinhThucDaoTaoModel
    {
        public int Id { get; set; }
        public string TenHinhThucDaoTao { get; set; }
        public static string TableName = "HinhThucDaoTao";
    }
}
