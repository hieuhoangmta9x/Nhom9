using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class QuocGiaController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(QuocGiaModel obj)
        {
            return dataAccess.NonQuery(
                QuocGiaModel.TableName + "_ProcInsert",
                obj.TenQuocGia
            );
        }

        public bool Edit(QuocGiaModel obj)
        {
            return dataAccess.NonQuery(
                QuocGiaModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenQuocGia
            );
        }

        public bool Delete(QuocGiaModel obj)
        {
            return dataAccess.NonQuery(
                QuocGiaModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(QuocGiaModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(QuocGiaModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                QuocGiaModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
