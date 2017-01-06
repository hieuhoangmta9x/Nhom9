using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class DanTocController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(DanTocModel obj)
        {
            return dataAccess.NonQuery(
                DanTocModel.TableName + "_ProcInsert",
                obj.TenDanToc
            );
        }

        public bool Edit(DanTocModel obj)
        {
            return dataAccess.NonQuery(
                DanTocModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenDanToc
            );
        }

        public bool Delete(DanTocModel obj)
        {
            return dataAccess.NonQuery(
                DanTocModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(DanTocModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(DanTocModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                DanTocModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
