using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class ChucVuController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(ChucVuModel obj)
        {
            return dataAccess.NonQuery(
                ChucVuModel.TableName + "_ProcInsert",
                obj.TenChucVu, obj.GhiChu, obj.TrangThaiSuDung

            );
        }

        public bool Edit(ChucVuModel obj)
        {
            return dataAccess.NonQuery(
                ChucVuModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenChucVu, obj.GhiChu, obj.TrangThaiSuDung
            );
        }

        public bool Delete(ChucVuModel obj)
        {
            return dataAccess.NonQuery(
                ChucVuModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(ChucVuModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(ChucVuModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                ChucVuModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
