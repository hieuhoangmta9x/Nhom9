using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class PhuCapController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(PhuCapModel obj)
        {
            return dataAccess.NonQuery(
                PhuCapModel.TableName + "_ProcInsert",
                obj.PhuCap, obj.GiaTri
            );
        }

        public bool Edit(PhuCapModel obj)
        {
            return dataAccess.NonQuery(
                PhuCapModel.TableName + "_ProcUpdate",
                obj.Id, obj.PhuCap, obj.GiaTri
            );
        }

        public bool Delete(PhuCapModel obj)
        {
            return dataAccess.NonQuery(
                PhuCapModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(PhuCapModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(PhuCapModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                PhuCapModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
