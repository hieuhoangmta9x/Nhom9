using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class TonGiaoController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(TonGiaoModel obj)
        {
            return dataAccess.NonQuery(
                TonGiaoModel.TableName + "_ProcInsert",
                obj.TenTonGiao
            );
        }

        public bool Edit(TonGiaoModel obj)
        {
            return dataAccess.NonQuery(
                TonGiaoModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenTonGiao
            );
        }

        public bool Delete(TonGiaoModel obj)
        {
            return dataAccess.NonQuery(
                TonGiaoModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(TonGiaoModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(TonGiaoModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                TonGiaoModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
