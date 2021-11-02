using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Employee
    {
        DataAccess dal = new DataAccess();
        
        private DataTable CustomTable(DataTable temp)
        {
            DataTable dt = temp.Clone();
            dt.Columns["Image"].DataType = typeof(bool);
            foreach (DataRow row in temp.Rows)
                dt.ImportRow(row);
            return dt;
        }

        public DataTable GetAllEmployee(ref string error)
        {
            DataTable dt = dal.ExecuteQueryData("sp_GetAllemployees", CommandType.StoredProcedure, ref error);
            if (dt == null)
                return null;
            return CustomTable(dt);
        }

        public DataTable GetStockManagers(ref string error)
        {
            DataTable dt = dal.ExecuteQueryData("sp_GetStockManagers", CommandType.StoredProcedure, ref error);
            if (dt == null)
                return null;
            return CustomTable(dt);
        }

        public DataTable GetStaffs(ref string error)
        {
            DataTable dt = dal.ExecuteQueryData("sp_GetStaffs", CommandType.StoredProcedure, ref error);
            if (dt == null)
                return null;
            return CustomTable(dt);
        }

        public DataTable SearchEmployee(string searchBy, string text, string role, ref string error)
        {
            searchBy = searchBy.ToLower();
            if (searchBy.Contains("phone"))
                searchBy = "phoneNumber";
            DataTable dt = dal.ExecuteQueryData("sp_SearchEmployee", CommandType.StoredProcedure, ref error,
                new SqlParameter("role", role),
                new SqlParameter(searchBy, text));
            if (dt == null)
                return null;
            return CustomTable(dt);
        }
    }
}
