using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class TrinhTrangHonNhanController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(TinhTrangHonNhanModel obj)
        {
            return dataAccess.NonQuery(
                TinhTrangHonNhanModel.TableName + "_ProcInsert",
                obj.TinhTrangHonNhan
            );
        }

        public bool Edit(TinhTrangHonNhanModel obj)
        {
            return dataAccess.NonQuery(
                TinhTrangHonNhanModel.TableName + "_ProcUpdate",
                obj.Id, obj.TinhTrangHonNhan
            );
        }

        public bool Delete(TinhTrangHonNhanModel obj)
        {
            return dataAccess.NonQuery(
                TinhTrangHonNhanModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(TinhTrangHonNhanModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(TinhTrangHonNhanModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                TinhTrangHonNhanModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
