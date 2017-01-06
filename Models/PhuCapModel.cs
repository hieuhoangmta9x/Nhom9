using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class PhuCapModel
    {
        public int Id { get; set; }
        public string PhuCap { get; set; }
        public string GiaTri { get; set; }
        public static string TableName = "PhuCap";
    }
}
