using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class TrinhDoNgoaiNguController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(TrinhDoNgoaiNguModel obj)
        {
            return dataAccess.NonQuery(
                TrinhDoNgoaiNguModel.TableName + "_ProcInsert",
                obj.TrinhDoNgoaiNgu
            );
        }

        public bool Edit(TrinhDoNgoaiNguModel obj)
        {
            return dataAccess.NonQuery(
                TrinhDoNgoaiNguModel.TableName + "_ProcUpdate",
                obj.Id, obj.TrinhDoNgoaiNgu
            );
        }

        public bool Delete(TrinhDoNgoaiNguModel obj)
        {
            return dataAccess.NonQuery(
                TrinhDoNgoaiNguModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(TrinhDoNgoaiNguModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(TrinhDoNgoaiNguModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                TrinhDoNgoaiNguModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
