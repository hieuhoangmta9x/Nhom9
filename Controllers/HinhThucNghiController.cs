using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class HinhThucNghiController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(HinhThucNghiModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucNghiModel.TableName + "_ProcInsert",
                obj.TenHinhThucNghi
            );
        }

        public bool Edit(HinhThucNghiModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucNghiModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenHinhThucNghi
            );
        }

        public bool Delete(HinhThucNghiModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucNghiModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(HinhThucNghiModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(HinhThucNghiModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                HinhThucNghiModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
