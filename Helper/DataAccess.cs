using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace VB2QLNS.Helper
{
    class DataAccess
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private SqlCommand cmd;

        public DataAccess()
        {
            conn = new SqlConnection(DataConfig.ConnectionString);
        }

        public void CheckOpeningDB()
        {
            if (conn.State.Equals(ConnectionState.Open))
            {
                conn.Close();
            }
        }

        public List<SqlParameter> GetParameterByStore(string store)
        {
            CheckOpeningDB();
            conn.Open();
            cmd = new SqlCommand(store, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(cmd);
            List<SqlParameter> lstSqlParamer = new List<SqlParameter>();
            foreach (SqlParameter p in cmd.Parameters)
            {
                lstSqlParamer.Add(p);
            }
            lstSqlParamer.RemoveAt(0);
            conn.Close();
            return lstSqlParamer;
        }

        public DataTable GetTableByName(string tableName)
        {
            CheckOpeningDB();
            DataTable dt = new DataTable();
            conn.Open();
            cmd = new SqlCommand(tableName + "_ProcSelectAll", conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable GetRecordById(string tableName, int Id)
        {
            CheckOpeningDB();
            DataTable dt = new DataTable();
            conn.Open();
            cmd = new SqlCommand(tableName + "_ProcSelectByID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("Id", Id));
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable ExecuteQuery(string query, params SqlParameter[] sqlParamers)
        {
            CheckOpeningDB();
            DataTable dt = new DataTable();
            conn.Open();
            if (query.Split(' ').Length > 1)
            {
                adapter = new SqlDataAdapter(query, conn);
            }
            else
            {
                cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (sqlParamers.Length != 0)
                {
                    foreach (SqlParameter paramer in sqlParamers)
                    {
                        cmd.Parameters.Add(new SqlParameter(paramer.ParameterName, paramer.Value));
                    }
                }
                adapter = new SqlDataAdapter(cmd);                
            }
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable Query(string query, params object[] objs)
        {
            List<SqlParameter> lstSqlParamer = new List<SqlParameter>();
            if (objs.Length != 0)
            {
                lstSqlParamer = GetParameterByStore(query);
                for (int i = 0; i < objs.Length; i++)
                {
                    lstSqlParamer[i].Value = objs[i];
                }
            }
            return ExecuteQuery(query, lstSqlParamer.ToArray());
        }

        public bool ExecuteNonQuery(string query, params SqlParameter[] sqlParamers)
        {
            CheckOpeningDB();
            conn.Open();
            try
            {
                cmd = new SqlCommand(query, conn);
                if (query.Split(' ').Length > 1)
                {
                    cmd.CommandType = CommandType.Text;
                }
                else
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (sqlParamers.Length != 0)
                    {
                        foreach (SqlParameter paramer in sqlParamers)
                        {
                            if (paramer.Value != null)
                            {
                                cmd.Parameters.Add(new SqlParameter(paramer.ParameterName, paramer.Value));
                            }
                            else
                            {
                                cmd.Parameters.Add(new SqlParameter(paramer.ParameterName, DBNull.Value));
                            }
                        }
                    }
                }
            }
            catch
            {
                conn.Close();
                return false;
            }
            finally
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return true;
        }

        public bool NonQuery(string query, params object[] objs)
        {
            List<SqlParameter> lstSqlParameter = new List<SqlParameter>();
            if (objs.Length != 0)
            {
                lstSqlParameter = GetParameterByStore(query);
                for (int i = 0; i < objs.Length; i++)
                {
                    lstSqlParameter[i].Value = objs[i];
                }
            }
            return ExecuteNonQuery(query, lstSqlParameter.ToArray());
        }
    }
}
