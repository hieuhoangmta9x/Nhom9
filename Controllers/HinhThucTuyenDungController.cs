using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class HinhThucTuyenDungController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(HinhThucTuyenDungModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucTuyenDungModel.TableName + "_ProcInsert",
                obj.TenHinhThucTuyenDung
            );
        }

        public bool Edit(HinhThucTuyenDungModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucTuyenDungModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenHinhThucTuyenDung
            );
        }

        public bool Delete(HinhThucTuyenDungModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucTuyenDungModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(HinhThucTuyenDungModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(HinhThucTuyenDungModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                HinhThucTuyenDungModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
