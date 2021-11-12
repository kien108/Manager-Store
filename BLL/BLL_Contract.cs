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
    public class BLL_Contract
    {
        DataAccess dal = new DataAccess();
        public DataTable GetAllGoodsReceipt(ref string error)
        {
            return dal.ExecuteQueryData("sp_GetAllContracts", CommandType.StoredProcedure, ref error);
        }

        public DataTable GetAllProviders(ref string error)
        {
            return dal.ExecuteQueryData("sp_GetAllProviders", CommandType.StoredProcedure, ref error);
        }

        public DataTable SearchInContract(string paramName, object paramValue, ref string error)
        {
            return dal.ExecuteQueryData("sp_SearchContracts", CommandType.StoredProcedure, 
                ref error, new SqlParameter(paramName, paramValue));
        }

        public DataTable SearchProvider(string paramName, object paramValue, ref string error)
        {
            return dal.ExecuteQueryData("sp_SearchProvider", CommandType.StoredProcedure,
                   ref error, new SqlParameter(paramName, paramValue));
        }

        public DataTable DetailGoodsInContract(int cid, ref string error)
        {
            return dal.ExecuteQueryData("sp_DetailGoodsInContract", CommandType.StoredProcedure,
                   ref error, new SqlParameter("cid", cid));
        }

        public string UpdateInfomationContract(int cid, string gname, string unit, double gprice, string gphoto,
            string pname, string paddress, string pphonenumber, int eid, string cdate, int cquantity, double cprice)
        {
            string error = null, message = null;
            bool updated = dal.ExecuteNonQuery("sp_UpdateContract", CommandType.StoredProcedure, ref error, ref message,
                new SqlParameter("cid", cid),
                new SqlParameter("gname", gname),
                new SqlParameter("unit", unit),
                new SqlParameter("gprice", gprice),
                new SqlParameter("gphoto", gphoto),
                new SqlParameter("pname", pname),
                new SqlParameter("paddress", paddress),
                new SqlParameter("pphonenumber", pphonenumber),
                new SqlParameter("eid", eid),
                new SqlParameter("cdate", cdate),
                new SqlParameter("cquantity", cquantity),
                new SqlParameter("cprice", cprice));
            if (error != null)
                return "Update failed!\n" + error;
            if (!string.IsNullOrEmpty(message.Trim()))
                return "Update failed!\n" + message;
            if (!updated)
                return "No data is updated!";
            return "Update successful!";
        }

        public string UpdateInformationProvider(int id, string name, string address, string phoneNumber, bool providing)
        {
            string error = null, message = null;
            bool updated = dal.ExecuteNonQuery("sp_UpdateProvider", CommandType.StoredProcedure, ref error, ref message,
                new SqlParameter("id", id),
                new SqlParameter("name", name),
                new SqlParameter("address", address),
                new SqlParameter("phoneNumber", phoneNumber),
                new SqlParameter("state", providing));
            if (error != null)
                return "Update failed!\n" + error;
            if (!updated)
                return "No data is updated!";
            return "Update successful!";
        }

        public string DeleteContract(int cid)
        {
            string error = null, message = null;
            bool deleted = dal.ExecuteNonQuery("sp_DeleteContract", CommandType.StoredProcedure, ref error, ref message,
                new SqlParameter("cid", cid));
            if (error != null)
                return "Delete failed!\n" + error;
            return "Delete successful!";
        }

        public string DeleteGoodsInContract(int cid, string gname)
        {
            string error = null, message = null;
            bool deleted = dal.ExecuteNonQuery("sp_DeleteGoodsInContract", CommandType.StoredProcedure, ref error, ref message,
                new SqlParameter("cid", cid),
                new SqlParameter("gname", gname));
            if (error != null)
                return "Delete failed!\n" + error;
            return "Delete successful!";

        }

        public int GetNewContractID()
        {
            string error = null;
            return (int)dal.ExecuteScalar("select dbo.ft_CreateContractId()", CommandType.Text, ref error);
        }

        public string InsertContract(int cid, string gname, string unit, double gprice, string gphoto, string pname, 
            string paddress, string pphoneNumber, int eid, string date, int cquantity, double cprice)
        {
            string error = null, message = null;
            bool inserted = dal.ExecuteNonQuery("sp_InsertContract", CommandType.StoredProcedure, ref error, ref message,
                new SqlParameter("cid", cid),
                new SqlParameter("gname", gname),
                new SqlParameter("unit", unit),
                new SqlParameter("gprice", gprice),
                new SqlParameter("gphoto", gphoto),
                new SqlParameter("pname", pname),
                new SqlParameter("paddress", paddress),
                new SqlParameter("pphoneNumber", pphoneNumber),
                new SqlParameter("eid", eid),
                new SqlParameter("date", date),
                new SqlParameter("cquantity", cquantity),
                new SqlParameter("cprice", cprice));
            if (error != null)
                return "Insert failed!\n" + error;
            if (!string.IsNullOrEmpty(message.Trim()))
                return "v failed!\n" + message;
            if (!inserted)
                return "No data is insert!";
            return "Insert successful!";
        }
    }
}
