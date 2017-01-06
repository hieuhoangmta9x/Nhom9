using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class TinhThanhController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(TinhThanhModel obj)
        {
            return dataAccess.NonQuery(
                TinhThanhModel.TableName + "_ProcInsert",
                obj.TenTinhThanh
            );
        }

        public bool Edit(TinhThanhModel obj)
        {
            return dataAccess.NonQuery(
                TinhThanhModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenTinhThanh
            );
        }

        public bool Delete(TinhThanhModel obj)
        {
            return dataAccess.NonQuery(
                TinhThanhModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(TinhThanhModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(TinhThanhModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                TinhThanhModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
