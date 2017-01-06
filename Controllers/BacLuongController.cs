using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class BacLuongController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(BacLuongModel obj)
        {
            return dataAccess.NonQuery(
                BacLuongModel.TableName + "_ProcInsert",
                obj.MaBacLuong, obj.TenBacLuong, obj.ThongTinMoTa,obj.HeSoLuong
                
            );
        }

        public bool Edit(BacLuongModel obj)
        {
            return dataAccess.NonQuery(
                BacLuongModel.TableName + "_ProcUpdate",
                obj.Id, obj.MaBacLuong, obj.TenBacLuong, obj.ThongTinMoTa, obj.HeSoLuong
            );
        }

        public bool Delete(BacLuongModel obj)
        {
            return dataAccess.NonQuery(
                BacLuongModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(BacLuongModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(BacLuongModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                BacLuongModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
