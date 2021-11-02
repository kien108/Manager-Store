using DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
            DataTable temp = dal.ExecuteQueryData("sp_GetAllProviders", CommandType.StoredProcedure, ref error);
            if (temp == null)
                return null;
            DataTable dt = temp.Clone();
            dt.Columns["Providing"].DataType = typeof(bool);
            foreach (DataRow row in temp.Rows)
                dt.ImportRow(row);
            return dt;
        }
    }
}
