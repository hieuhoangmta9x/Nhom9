using System;
using System.Collections.Generic;
using System.Text;

namespace VB2QLNS.Models
{
    class NhanSuModel
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public string TenKhac { get; set; }
        public string AnhDaiDien { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string SoCMND { get; set; }
        public DateTime NgayCapCMND { get; set; }
        public string NoiCapCMND { get; set; }
        public string NoiSinh { get; set; }
        public string QueQuan { get; set; }
        public string HoKhauThuongTru { get; set; }
        public string NoiSongHienTai { get; set; }
        public string SoDienThoaiDiDong { get; set; }
        public string SoDienThoaiBan { get; set; }
        public string EmailCaNhan { get; set; }
        public string EmailCongTy { get; set; }

        public int TinhTrangHonNhanId { get; set; }
        public int DanTocId { get; set; }
        public int TonGiaoId { get; set; }
        public int TinhThanhId { get; set; }
        public int QuocGiaId { get; set; }
        public int ChucVuId { get; set; }
        public int ChucDanhId { get; set; }
        public int PhongBanId { get; set; }
        public int HinhThucDaoTaoId { get; set; }
        public int ChuyenNganhDaoTaoId { get; set; }
        public int TrinhDoNgoaiNguId { get; set; }
        public int TrinhDoTinHocId { get; set; }
        public int TruongDaoTaoId { get; set; }
        public int TrinhDoVanHoaId { get; set; }

        public static string TableName = "NhanSu";       
    }    

    class NhanSuPrefixProc
    {
        public static string FindAll = "_FindAll";
        public static string FindAllByPhongBan = "_FindAllByPhongBan";
    }
}
