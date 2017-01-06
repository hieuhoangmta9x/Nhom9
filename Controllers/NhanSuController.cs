using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class NhanSuController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(NhanSuModel obj)
        {
            return dataAccess.NonQuery(
                NhanSuModel.TableName + "_ProcInsert",
                obj.TinhTrangHonNhanId,
                obj.DanTocId,
                obj.TonGiaoId,
                obj.TinhThanhId,
                obj.QuocGiaId,
                obj.ChucVuId,
                obj.ChucDanhId,
                obj.PhongBanId,
                obj.HinhThucDaoTaoId,
                obj.ChuyenNganhDaoTaoId,
                obj.TrinhDoNgoaiNguId,
                obj.TrinhDoTinHocId,
                obj.TruongDaoTaoId,
                obj.TrinhDoVanHoaId,
                obj.HoTen,
                obj.TenKhac,
                obj.AnhDaiDien,
                obj.NgaySinh,
                obj.GioiTinh,
                obj.SoCMND,
                obj.NgayCapCMND,
                obj.NoiCapCMND,
                obj.NoiSinh,
                obj.QueQuan,
                obj.HoKhauThuongTru,
                obj.NoiSongHienTai,
                obj.SoDienThoaiDiDong,
                obj.SoDienThoaiBan,
                obj.EmailCaNhan,
                obj.EmailCongTy

            );
        }

        public bool Edit(NhanSuModel obj)
        {
            return dataAccess.NonQuery(
                NhanSuModel.TableName + "_ProcUpdate",
                obj.Id,
                obj.TinhTrangHonNhanId,
                obj.DanTocId,
                obj.TonGiaoId,
                obj.TinhThanhId,
                obj.QuocGiaId,
                obj.ChucVuId,
                obj.ChucDanhId,
                obj.PhongBanId,
                obj.HinhThucDaoTaoId,
                obj.ChuyenNganhDaoTaoId,
                obj.TrinhDoNgoaiNguId,
                obj.TrinhDoTinHocId,
                obj.TruongDaoTaoId,
                obj.TrinhDoVanHoaId,
                obj.HoTen,
                obj.TenKhac,
                obj.AnhDaiDien,
                obj.NgaySinh,
                obj.GioiTinh,
                obj.SoCMND,
                obj.NgayCapCMND,
                obj.NoiCapCMND,
                obj.NoiSinh,
                obj.QueQuan,
                obj.HoKhauThuongTru,
                obj.NoiSongHienTai,
                obj.SoDienThoaiDiDong,
                obj.SoDienThoaiBan,
                obj.EmailCaNhan,
                obj.EmailCongTy
            );
        }

        public bool Delete(NhanSuModel obj)
        {
            return dataAccess.NonQuery(
                NhanSuModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(NhanSuModel.TableName);
        }

        public DataTable FindAll(string prefixProc)
        {
            return dataAccess.Query(NhanSuModel.TableName + prefixProc);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(NhanSuModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                NhanSuModel.TableName + "_ProcSearch",
                content
            );
        }

        public DataTable FindAllByPhongBan(string phongBanIds)
        {
            return dataAccess.Query(NhanSuModel.TableName + "_FindAllByPhongBan", phongBanIds);
        }

        public DataTable FindAllByPhongBanAndText(string phongBanIds, string search)
        {
            return dataAccess.Query(NhanSuModel.TableName + "_FindAllByPhongBanAndText", phongBanIds, search);
        }

        public DataTable AdvanceSearch(string phongBanIds, string searchContent, int tinhTrangHonNhanId, int tinhThanhId, int quocGiaId, int chucVuId, int chucDanhId, int hinhThucDaoTaoId, int chuyenNganhDaoTaoId, int trinhDoNgoaiNguId, int trinhDoTinHocId, int trinhDoVanHoaId, int fromAge, int toAge)
        {
            return dataAccess.Query(NhanSuModel.TableName + "_AdvanceSearch",
                phongBanIds,
                searchContent,
                tinhTrangHonNhanId,
                tinhThanhId,
                quocGiaId,
                chucVuId,
                chucDanhId,
                hinhThucDaoTaoId,
                chuyenNganhDaoTaoId,
                trinhDoNgoaiNguId,
                trinhDoTinHocId,
                trinhDoVanHoaId,
                fromAge,
                toAge
            );
        }
    }
}
