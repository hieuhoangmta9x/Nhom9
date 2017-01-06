using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VB2QLNS.Helper;
using VB2QLNS.Models;

namespace VB2QLNS.Controllers
{
    class QuaTrinhDaoTaoController
    {
        public DataAccess dataAccess = new DataAccess();

        public bool Add(QuaTrinhDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhDaoTaoModel.TableName + "_ProcInsert",
                obj.NhanSuId, obj.TuNgay, obj.DenNgay, obj.Loai, obj.HinhThuc, obj.ChuyenNganh, obj.ChungChi, obj.TenTruongDaoTao, obj.NuocDaoTao

            );
        }

        public bool Edit(QuaTrinhDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhDaoTaoModel.TableName + "_ProcUpdate",
                obj.Id, obj.NhanSuId, obj.TuNgay, obj.DenNgay, obj.Loai, obj.HinhThuc, obj.ChuyenNganh, obj.ChungChi, obj.TenTruongDaoTao, obj.NuocDaoTao
            );
        }

        public bool Delete(QuaTrinhDaoTaoModel obj)
        {
            return dataAccess.NonQuery(
                QuaTrinhDaoTaoModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(QuaTrinhDaoTaoModel.TableName);
        }

        public DataTable FindAll(string prefixProc)
        {
            return dataAccess.Query(QuaTrinhHopDongModel.TableName + prefixProc);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(QuaTrinhDaoTaoModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                QuaTrinhDaoTaoModel.TableName + "_ProcSearch",
                content
            );
        }
    }
}
