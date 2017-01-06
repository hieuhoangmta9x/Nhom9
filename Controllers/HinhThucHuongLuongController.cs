using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class HinhThucHuongLuongController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(HinhThucHuongLuongModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucHuongLuongModel.TableName + "_ProcInsert",
                obj.TenHinhThucHuongLuong

            );
        }

        public bool Edit(HinhThucHuongLuongModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucHuongLuongModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenHinhThucHuongLuong
            );
        }

        public bool Delete(HinhThucHuongLuongModel obj)
        {
            return dataAccess.NonQuery(
                HinhThucHuongLuongModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(HinhThucHuongLuongModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(HinhThucHuongLuongModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                HinhThucHuongLuongModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
