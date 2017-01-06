using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class QuaTrinhHopDongController
    {
        public DataAccess dataAccess = new DataAccess();

        public bool Add(QuaTrinhHopDongModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhHopDongModel.TableName + "_ProcInsert",
                obj.NhanSuId, obj.LoaiHopDongId, obj.ChucVuId, obj.PhongBanId, obj.TuNgay, obj.DenNgay, obj.GhiChu

            );
        }

        public bool Edit(QuaTrinhHopDongModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhHopDongModel.TableName + "_ProcUpdate",
                obj.Id, obj.NhanSuId, obj.LoaiHopDongId, obj.ChucVuId, obj.PhongBanId, obj.TuNgay, obj.DenNgay, obj.GhiChu
            );
        }

        public bool Delete(QuaTrinhHopDongModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhHopDongModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(QuaTrinhHopDongModel.TableName);
        }

        public DataTable FindAll(string prefixProc)
        {
            return dataAccess.Query(QuaTrinhHopDongModel.TableName + prefixProc);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(QuaTrinhHopDongModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                QuaTrinhHopDongModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
