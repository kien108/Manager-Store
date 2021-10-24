using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccess
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private string computerName = Environment.MachineName.ToString();
        private string databaseName = "GroceryStore";
        private string security = "True";
        private string connectionString;
        private string message = "";
        
        public DataAccess()
        {
            connectionString = String.Format("Data Source={0};Initial Catalog={1};Integrated Security={2}", computerName, databaseName, security);
            conn = new SqlConnection(connectionString);
            cmd = conn.CreateCommand();
            conn.InfoMessage += new SqlInfoMessageEventHandler((object obj, SqlInfoMessageEventArgs e) => { message = e.Message; });
        }

        private void Connect()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public DataTable ExecuteQueryData(string sql, CommandType type, ref string error, params SqlParameter[] parameters)
        {
            Connect();
            cmd.CommandText = sql;
            cmd.CommandType = type;
            foreach (var param in parameters)
                cmd.Parameters.Add(param);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try { da.Fill(dt); }
            catch (Exception)
            {
                error = "Can't fill data into data table!";
                dt = null;
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                da.Dispose();
                conn.Close();
            }
            return dt;
        }

        public bool ExecuteNonQuery(string sql, CommandType type, ref string error, ref string message, params SqlParameter[] parameters)
        {
            Connect();
            cmd.CommandText = sql;
            cmd.CommandType = type;
            this.message = "";
            foreach (var param in parameters)
                cmd.Parameters.Add(param);
            bool check;
            try { check = cmd.ExecuteNonQuery() > 0; }
            catch (Exception e)
            {
                error = e.Message;
                check = false;
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                conn.Close();
                message = this.message;
            }
            return check;
        }

        public object ExecuteScalar(string sql, CommandType type, ref string error, params SqlParameter[] parameters)
        {
            Connect();
            cmd.CommandText = sql;
            cmd.CommandType = type;
            foreach (var param in parameters)
                cmd.Parameters.Add(param);
            object result;
            try { result = cmd.ExecuteScalar(); }
            catch (Exception e)
            {
                error = e.Message;
                result = null;
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                conn.Close();
            }
            return result;
        }
    }
}
