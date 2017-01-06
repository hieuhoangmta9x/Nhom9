using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class QuaTrinhKhenThuongController
    {
        public DataAccess dataAccess = new DataAccess();

        public bool Add(QuaTrinhKhenThuongModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhKhenThuongModel.TableName + "_ProcInsert",
                obj.NhanSuId, obj.TuNgay, obj.DenNgay, obj.HinhThuc, obj.LyDo, obj.GiaTri

            );
        }

        public bool Edit(QuaTrinhKhenThuongModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhKhenThuongModel.TableName + "_ProcUpdate",
                obj.Id, obj.NhanSuId, obj.TuNgay, obj.DenNgay, obj.HinhThuc, obj.LyDo, obj.GiaTri
            );
        }

        public bool Delete(QuaTrinhKhenThuongModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhKhenThuongModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(QuaTrinhKhenThuongModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(QuaTrinhKhenThuongModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                QuaTrinhKhenThuongModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
