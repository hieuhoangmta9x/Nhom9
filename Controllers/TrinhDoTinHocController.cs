using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class TrinhDoTinHocController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(TrinhDoTinHocModel obj)
        {
            return dataAccess.NonQuery(
                TrinhDoTinHocModel.TableName + "_ProcInsert",
                obj.TrinhDoTinHoc
            );
        }

        public bool Edit(TrinhDoTinHocModel obj)
        {
            return dataAccess.NonQuery(
                TrinhDoTinHocModel.TableName + "_ProcUpdate",
                obj.Id, obj.TrinhDoTinHoc
            );
        }

        public bool Delete(TrinhDoTinHocModel obj)
        {
            return dataAccess.NonQuery(
                TrinhDoTinHocModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(TrinhDoTinHocModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(TrinhDoTinHocModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                TrinhDoTinHocModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
