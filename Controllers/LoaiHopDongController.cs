using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class LoaiHopDongController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(LoaiHopDongModel obj)
        {
            return dataAccess.NonQuery(
                LoaiHopDongModel.TableName + "_ProcInsert",
                obj.TenLoaiHopDong
            );
        }

        public bool Edit(LoaiHopDongModel obj)
        {
            return dataAccess.NonQuery(
                LoaiHopDongModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenLoaiHopDong
            );
        }

        public bool Delete(LoaiHopDongModel obj)
        {
            return dataAccess.NonQuery(
                LoaiHopDongModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(LoaiHopDongModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(LoaiHopDongModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                LoaiHopDongModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
