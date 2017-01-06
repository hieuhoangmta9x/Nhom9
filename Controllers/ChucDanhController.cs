using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class ChucDanhController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(ChucDanhModel obj)
        {
            return dataAccess.NonQuery(
                ChucDanhModel.TableName + "_ProcInsert",
                obj.TenChucDanh, obj.TenVietTat, obj.ThongTinMoTa, obj.KichHoat

            );
        }

        public bool Edit(ChucDanhModel obj)
        {
            return dataAccess.NonQuery(
                ChucDanhModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenChucDanh, obj.TenVietTat, obj.ThongTinMoTa, obj.KichHoat
            );
        }

        public bool Delete(ChucDanhModel obj)
        {
            return dataAccess.NonQuery(
                ChucDanhModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(ChucDanhModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(ChucDanhModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                ChucDanhModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
