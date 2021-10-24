using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BLL_Goods
    {
        DataAccess dal = new DataAccess();

        public DataTable GetGoodTable(ref string error)
        {
            DataTable temp = dal.ExecuteQueryData("sp_GetAllGoodsWithProfit", CommandType.StoredProcedure, ref error);
            if (temp == null)
                return null;
            DataTable dt = temp.Clone();
            dt.Columns["Price"].DataType = typeof(string);
            dt.Columns["Profit"].DataType = typeof(string);
            foreach (DataRow row in temp.Rows)
                dt.ImportRow(row);
            return dt;
        }

        public DataTable GetStokingGoodTable(ref string error)
        {
            DataTable temp = dal.ExecuteQueryData("sp_GetStockingGoods", CommandType.StoredProcedure, ref error);
            if (temp == null)
                return null;
            DataTable dt = temp.Clone();
            dt.Columns["Price"].DataType = typeof(string);
            dt.Columns["Profit"].DataType = typeof(string);
            foreach (DataRow row in temp.Rows)
                dt.ImportRow(row);
            return dt;
        }

        public DataTable GetSoldOutGoodTable(ref string error)
        {
            DataTable temp = dal.ExecuteQueryData("sp_GetSoldOutGoods", CommandType.StoredProcedure, ref error);
            if (temp == null)
                return null;
            DataTable dt = temp.Clone();
            dt.Columns["Price"].DataType = typeof(string);
            dt.Columns["Profit"].DataType = typeof(string);
            foreach (DataRow row in temp.Rows)
                dt.ImportRow(row);
            return dt;
        }

        public DataTable GetStopSellingGoodTable(ref string error)
        {
            DataTable temp = dal.ExecuteQueryData("sp_GetStopSellingGoods", CommandType.StoredProcedure, ref error);
            if (temp == null)
                return null;
            DataTable dt = temp.Clone();
            dt.Columns["Price"].DataType = typeof(string);
            dt.Columns["Profit"].DataType = typeof(string);
            foreach (DataRow row in temp.Rows)
                dt.ImportRow(row);
            return dt;
        }

        public DataTable SearchGoods(int id, string state, ref string error)
        {
            DataTable temp = dal.ExecuteQueryData("sp_SearchGoods", CommandType.StoredProcedure, ref error,
                new SqlParameter("id", id), new SqlParameter("state", state));
            if (temp == null)
                return null;
            DataTable dt = temp.Clone();
            dt.Columns["Price"].DataType = typeof(string);
            dt.Columns["Profit"].DataType = typeof(string);
            foreach (DataRow row in temp.Rows)
                dt.ImportRow(row);
            return dt;
        }

        public DataTable SearchGoods(string name, string state, ref string error)
        {
            DataTable temp = dal.ExecuteQueryData("sp_SearchGoods", CommandType.StoredProcedure, ref error,
                new SqlParameter("name", name), new SqlParameter("state", state));
            if (temp == null)
                return null;
            DataTable dt = temp.Clone();
            dt.Columns["Price"].DataType = typeof(string);
            dt.Columns["Profit"].DataType = typeof(string);
            foreach (DataRow row in temp.Rows)
                dt.ImportRow(row);
            return dt;
        }
    }
}
