using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class HinhThucDaoTaoController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(HinhThucDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucDaoTaoModel.TableName + "_ProcInsert",
                obj.TenHinhThucDaoTao
            );
        }

        public bool Edit(HinhThucDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucDaoTaoModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenHinhThucDaoTao
            );
        }

        public bool Delete(HinhThucDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucDaoTaoModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(HinhThucDaoTaoModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(HinhThucDaoTaoModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                HinhThucDaoTaoModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
