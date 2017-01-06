using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class TonGiaoModel
    {
        public int Id { get; set; }
        public string TenTonGiao { get; set; }
        public static string TableName = "TonGiao";
    }
}
