using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class TrinhDoVanHoaModel
    {
        public int Id { get; set; }
        public string TrinhDoTotNghiep { get; set; }
        public static string TableName = "TrinhDoVanHoa";
    }
}
