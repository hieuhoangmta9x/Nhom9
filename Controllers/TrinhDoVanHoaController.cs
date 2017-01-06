using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class TrinhDoVanHoaController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(TrinhDoVanHoaModel obj)
        {
            return dataAccess.NonQuery(
                TrinhDoVanHoaModel.TableName + "_ProcInsert",
                obj.TrinhDoTotNghiep
            );
        }

        public bool Edit(TrinhDoVanHoaModel obj)
        {
            return dataAccess.NonQuery(
                TrinhDoVanHoaModel.TableName + "_ProcUpdate",
                obj.Id, obj.TrinhDoTotNghiep
            );
        }

        public bool Delete(TrinhDoVanHoaModel obj)
        {
            return dataAccess.NonQuery(
                TrinhDoVanHoaModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(TrinhDoVanHoaModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(TrinhDoVanHoaModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                TrinhDoVanHoaModel.TableName + "_ProcSearch",
                content
            );
        }

        internal bool Add(DanTocModel obj)
        {
            throw new NotImplementedException();
        }

        internal bool Edit(DanTocModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
