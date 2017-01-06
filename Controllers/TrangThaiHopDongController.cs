using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class TrangThaiHopDongController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(TrangThaiHopDongModel obj)
        {
            return dataAccess.NonQuery(
                TrangThaiHopDongModel.TableName + "_ProcInsert",
                obj.TenTrangThaiHD
            );
        }

        public bool Edit(TrangThaiHopDongModel obj)
        {
            return dataAccess.NonQuery(
                TrangThaiHopDongModel.TableName + "_ProcUpdate",
                obj.Id, obj.TenTrangThaiHD
            );
        }

        public bool Delete(TrangThaiHopDongModel obj)
        {
            return dataAccess.NonQuery(
                TrangThaiHopDongModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(TrangThaiHopDongModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(TrangThaiHopDongModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                TrangThaiHopDongModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
