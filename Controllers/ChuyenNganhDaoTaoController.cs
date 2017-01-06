using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class ChuyenNganhDaoTaoController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(ChuyenNganhDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                ChuyenNganhDaoTaoModel.TableName + "_ProcInsert",
                obj.MaChuyenNganhDaoTao, obj.TenChuyenNganhDaoTao, obj.ThongTinMoTa, obj.TrangThaiSuDung

            );
        }

        public bool Edit(ChuyenNganhDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                ChuyenNganhDaoTaoModel.TableName + "_ProcUpdate",
                obj.Id, obj.MaChuyenNganhDaoTao, obj.TenChuyenNganhDaoTao, obj.ThongTinMoTa, obj.TrangThaiSuDung
            );
        }

        public bool Delete(ChuyenNganhDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                ChuyenNganhDaoTaoModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(ChuyenNganhDaoTaoModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(ChuyenNganhDaoTaoModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                ChuyenNganhDaoTaoModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
