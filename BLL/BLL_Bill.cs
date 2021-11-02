using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Bill
    {
        DataAccess dal = new DataAccess();

        public DataTable GetAllBills(ref string error)
        {
            return dal.ExecuteQueryData("sp_GetAllBills", CommandType.StoredProcedure, ref error);
        }
    }
}
