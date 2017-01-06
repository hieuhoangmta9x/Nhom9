using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class TruongDaoTaoController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(TruongDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                TruongDaoTaoModel.TableName + "_ProcInsert",
                obj.TenTruongDaoTao
            );
        }

        public bool Edit(TruongDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                TruongDaoTaoModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenTruongDaoTao
            );
        }

        public bool Delete(TruongDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                TruongDaoTaoModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(TruongDaoTaoModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(TruongDaoTaoModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                TruongDaoTaoModel.TableName + "_ProcSearch",
                content
            );
        }

        internal bool Edit(DanTocModel obj)
        {
            throw new NotImplementedException();
        }

        internal bool Add(DanTocModel obj)
        {
            throw new NotImplementedException();
        }

        internal void Delete(DanTocModel danTocModel)
        {
            throw new NotImplementedException();
        }
    }
}
