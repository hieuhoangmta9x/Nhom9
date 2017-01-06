using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class QuaTrinhKyLuatController
    {
        public DataAccess dataAccess = new DataAccess();

        public bool Add(QuaTrinhKyLuatModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhKyLuatModel.TableName + "_ProcInsert",
                obj.NhanSuId, obj.TuNgay, obj.DenNgay, obj.HinhThuc, obj.LyDo, obj.GiaTri

            );
        }

        public bool Edit(QuaTrinhKyLuatModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhKyLuatModel.TableName + "_ProcUpdate",
                obj.Id, obj.NhanSuId, obj.TuNgay, obj.DenNgay, obj.HinhThuc, obj.LyDo, obj.GiaTri
            );
        }

        public bool Delete(QuaTrinhKyLuatModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhKyLuatModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(QuaTrinhKyLuatModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(QuaTrinhKyLuatModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                QuaTrinhKyLuatModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
