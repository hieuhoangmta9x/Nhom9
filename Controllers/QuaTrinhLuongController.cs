using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class QuaTrinhLuongController
    {
        public DataAccess dataAccess = new DataAccess();

        public bool Add(QuaTrinhLuongModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhLuongModel.TableName + "_ProcInsert",
                obj.NhanSuId, obj.HinhThucHuongLuongId, obj.BacLuongId, obj.TuNgay, obj.DenNgay, obj.TienLuong
            );
        }

        public bool Edit(QuaTrinhLuongModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhLuongModel.TableName + "_ProcUpdate",
                obj.Id, obj.NhanSuId, obj.HinhThucHuongLuongId, obj.BacLuongId, obj.TuNgay, obj.DenNgay, obj.TienLuong
            );
        }

        public bool Delete(QuaTrinhLuongModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhLuongModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(QuaTrinhLuongModel.TableName);
        }

        public DataTable FindAll(string prefixProc)
        {
            return dataAccess.Query(QuaTrinhHopDongModel.TableName + prefixProc);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(QuaTrinhLuongModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                QuaTrinhLuongModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
