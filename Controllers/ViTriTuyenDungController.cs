using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class ViTriTuyenDungController
    {
        private DataAccess dataAccess = new DataAccess();
        public bool Add(ViTriTuyenDungModel obj)
        {
            return dataAccess.NonQuery(
                ViTriTuyenDungModel.TableName + "_ProcInsert",
                obj.TenViTriTuyenDung,
                obj.TrangThaiSuDung
            );
        }

        public bool Edit(ViTriTuyenDungModel obj)
        {
            return dataAccess.NonQuery(
                ViTriTuyenDungModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenViTriTuyenDung,
                obj.TrangThaiSuDung
            );
        }

        public bool Delete(ViTriTuyenDungModel obj)
        {
            return dataAccess.NonQuery(
                ViTriTuyenDungModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(ViTriTuyenDungModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(ViTriTuyenDungModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                ViTriTuyenDungModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
