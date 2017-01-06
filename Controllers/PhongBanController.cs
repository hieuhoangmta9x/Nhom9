using System;
using System.Collections.Generic;
using System.Text;
using VB2QLNS.Models;
using VB2QLNS.Helper;
using System.Data;

namespace VB2QLNS.Controllers
{
    class PhongBanController
    {
        private DataAccess dataAccess = new DataAccess();

        public bool Add(PhongBanModel obj)
        {
            return dataAccess.NonQuery(
                PhongBanModel.TableName + "_ProcInsert",
                obj.ParentId, obj.TenPhongBan, obj.SoDienThoai, obj.DiaChi, obj.Email

            );
        }

        public bool Edit(PhongBanModel obj)
        {
            return dataAccess.NonQuery(
                PhongBanModel.TableName + "_ProcUpdate",
                obj.Id, obj.ParentId, obj.TenPhongBan, obj.SoDienThoai, obj.DiaChi, obj.Email
            );
        }

        public bool Delete(PhongBanModel obj)
        {
            return dataAccess.NonQuery(
                PhongBanModel.TableName + "_ProcDelete",
                obj.Id
            );
        }

        public DataTable FindAll()
        {
            return dataAccess.GetTableByName(PhongBanModel.TableName);
        }

        public DataTable FindById(int id)
        {
            return dataAccess.GetRecordById(PhongBanModel.TableName, id);
        }

        public DataTable Search(string content)
        {
            return dataAccess.Query(
                PhongBanModel.TableName + "_ProcSearch",
                content
            );
        }

        public List<PhongBanModel> ListAllChild()
        {
            List<PhongBanModel> list = new List<PhongBanModel>();
            Dictionary<string, PhongBanModel> dic = this.FindChildForm(this.FindAll(), 1);
            foreach (string key in dic.Keys)
            {
                list.Add(dic[key]);
            }
            return list;
        }

        public Dictionary<string, PhongBanModel> FindChildForm(DataTable dt, int parentId, string space = "", Dictionary<string, PhongBanModel> data = null, int index = 1)
        {
            if (data == null)
            {
                data = new Dictionary<string, PhongBanModel>();
            }

            foreach (DataRow row in dt.Rows)
            {
                if (int.Parse(row["Id"].ToString()) == index && !data.ContainsKey(row["Id"].ToString()))
                {
                    PhongBanModel modelPhongBan = new PhongBanModel();
                    modelPhongBan.Id = int.Parse(row["Id"].ToString());
                    modelPhongBan.ParentId = row["ParentId"] == DBNull.Value ? 0 : int.Parse(row["ParentId"].ToString());
                    modelPhongBan.TenPhongBan = " > " + row["TenPhongBan"].ToString();
                    modelPhongBan.DiaChi = row["DiaChi"].ToString();
                    modelPhongBan.SoDienThoai = row["SoDienThoai"].ToString();
                    modelPhongBan.Email = row["Email"].ToString();

                    data.Add(row["id"].ToString(), modelPhongBan);
                }
            }

            foreach (DataRow row in dt.Rows)
            {
                if (row["ParentId"] == DBNull.Value)
                {
                    continue;
                }
                if (parentId == int.Parse(row["ParentId"].ToString()))
                {
                    PhongBanModel modelPhongBan = new PhongBanModel();
                    modelPhongBan.Id = int.Parse(row["Id"].ToString());
                    modelPhongBan.ParentId = row["ParentId"] == DBNull.Value ? 0 : int.Parse(row["ParentId"].ToString());
                    modelPhongBan.TenPhongBan = space + "------> " + row["TenPhongBan"].ToString();
                    modelPhongBan.DiaChi = row["DiaChi"].ToString();
                    modelPhongBan.SoDienThoai = row["SoDienThoai"].ToString();
                    modelPhongBan.Email = row["Email"].ToString();

                    data.Add(row["Id"].ToString(), modelPhongBan);
                    data = FindChildForm(dt, int.Parse(row["Id"].ToString()), space + "------", data, index);
                }
            }

            return data;
        }

        public string GetChildIds(int parentId)
        {
            List<int> sortIds = new List<int>();
            List<PhongBanModel> dt = ListAllChild();
            Stack<PhongBanModel> stack = new Stack<PhongBanModel>();
            stack.Push(dt.Find(x => x.Id == parentId));
            while (stack.Count > 0)
            {
                PhongBanModel temp = stack.Pop();
                sortIds.Add(temp.Id);
                List<PhongBanModel> lstChild = dt.FindAll(x => x.ParentId == temp.Id);
                if (lstChild.Count > 0)
                {
                    foreach (PhongBanModel pb in lstChild)
                        stack.Push(pb);
                }
            }

            string idSlice = "";// parentId.ToString(); (i == 0 ? "," : "") + 
            for (int i = 0; i < sortIds.Count; i++)
            {
                idSlice += sortIds[i] + (i == sortIds.Count - 1 ? "" : ",");
            }

            return idSlice;
        }
    }
}
