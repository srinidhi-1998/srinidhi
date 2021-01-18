using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace MilkParlorSystem.DAL
{
    public class MilkParlorDAL
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter adp = null;

        public MilkParlorDAL()
        {
            con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());
            con.Open();
        }

        public string LoginVerify(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_LoginVerification";
            cmd.Parameters.Add("@UserId", objMilkParlorDTO.UserId);
            cmd.Parameters.Add("@Password", objMilkParlorDTO.Password);
            cmd.Parameters.Add("@UserType", objMilkParlorDTO.UserType);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString() + "," + sqlreader.GetValue(1).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public string CreateArea(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CreateArea";
            cmd.Parameters.Add("@AreaName", objMilkParlorDTO.AreaName);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public string CreateProduct(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CreateProduct";
            cmd.Parameters.Add("@ProductName", objMilkParlorDTO.ProductName);
            cmd.Parameters.Add("@Description", objMilkParlorDTO.Description);
            cmd.Parameters.Add("@Price", objMilkParlorDTO.Price);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public DataTable GetProductDetails()
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetProduct";
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public DataTable GetProduct_Id(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ProductId", objMilkParlorDTO.ProductId);
            cmd.CommandText = "SP_GetProduct_Id";
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public string UpdateProduct(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UpdateProduct";
            cmd.Parameters.Add("@ProductId", objMilkParlorDTO.ProductId);
            cmd.Parameters.Add("@ProductName", objMilkParlorDTO.ProductName);
            cmd.Parameters.Add("@Description", objMilkParlorDTO.Description);
            cmd.Parameters.Add("@Price", objMilkParlorDTO.Price);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public DataTable GetAreaDetails()
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetArea";
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public string CreateIncharger(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CreateIncharger";
            cmd.Parameters.Add("@AreaId", objMilkParlorDTO.AreaId);
            cmd.Parameters.Add("@Name", objMilkParlorDTO.Name);
            cmd.Parameters.Add("@EmailId", objMilkParlorDTO.EmailId);
            cmd.Parameters.Add("@MobileNo", objMilkParlorDTO.MobileNo);
            cmd.Parameters.Add("@Address", objMilkParlorDTO.Address);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString() + "," + sqlreader.GetValue(1).ToString() + "," + sqlreader.GetValue(2).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public string CreateMilkParlor(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CreateMilkParlor";
            cmd.Parameters.Add("@UserId", objMilkParlorDTO.UserId);
            cmd.Parameters.Add("@Name", objMilkParlorDTO.Name);
            cmd.Parameters.Add("@MobileNo", objMilkParlorDTO.MobileNo);
            cmd.Parameters.Add("@Address", objMilkParlorDTO.Address);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString() + "," + sqlreader.GetValue(1).ToString() + "," + sqlreader.GetValue(2).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public string DepositeAmt_MP(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_DepositeWallet";
            cmd.Parameters.Add("@MilkParlorId", objMilkParlorDTO.UserId);
            cmd.Parameters.Add("@Amount", objMilkParlorDTO.Amount);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public DataTable GetWallet_MP(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetWallet_MP";
            cmd.Parameters.Add("@MilkParlorId", objMilkParlorDTO.UserId);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public string MilkProduct_Order(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_MilkParlor_Order";
            cmd.Parameters.Add("@MilkParlorId", objMilkParlorDTO.UserId);
            cmd.Parameters.Add("@ProductId", objMilkParlorDTO.ProductId);
            cmd.Parameters.Add("@Qty", objMilkParlorDTO.Qty);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public DataTable GetOrderDetails_IC(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetOrderDetails_IC";
            cmd.Parameters.Add("@InchargerId", objMilkParlorDTO.UserId);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public string OrderDetails_Approve(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_OrderDetails_Approve";
            cmd.Parameters.Add("@OrderId", objMilkParlorDTO.OrderId);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public DataTable GetIncharger_AreaId(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetIncharger_AreaId";
            cmd.Parameters.Add("@AreaId", objMilkParlorDTO.AreaId);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public string ChangePassword(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ChangePassword";
            cmd.Parameters.Add("@UserId", objMilkParlorDTO.UserId);
            cmd.Parameters.Add("@NewPassword", objMilkParlorDTO.Password);
            cmd.Parameters.Add("@UserType", objMilkParlorDTO.UserType);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public DataTable GetMilkProduct_Order_Id(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetProduct_Order_Id";
            cmd.Parameters.Add("@UserId", objMilkParlorDTO.UserId);
            cmd.Parameters.Add("@Status", objMilkParlorDTO.Status);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public string ProductSales(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ProductSales";
            cmd.Parameters.Add("@ProductId", objMilkParlorDTO.ProductId);
            cmd.Parameters.Add("@MilkParlorId", objMilkParlorDTO.MilkParlorId);
            cmd.Parameters.Add("@CustomerName", objMilkParlorDTO.Name);
            cmd.Parameters.Add("@Qty", objMilkParlorDTO.Qty);
            SqlDataReader sqlreader = cmd.ExecuteReader();
            string result = "";
            if (sqlreader.Read())
            {
                result = sqlreader.GetValue(0).ToString();
            }
            sqlreader.Close();
            con.Close();
            return result;
        }
        public DataTable GetMilkParlorStock_Id(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetMilkParlorStock_Id";
            cmd.Parameters.Add("@MilkParlorId", objMilkParlorDTO.MilkParlorId);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public DataTable GetMilkParlor_Sales_Id(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetMilkParlor_Sales_Id";
            cmd.Parameters.Add("@MilkParlorId", objMilkParlorDTO.MilkParlorId);
            cmd.Parameters.Add("@StartDate", objMilkParlorDTO.StartDate);
            cmd.Parameters.Add("@EndDate", objMilkParlorDTO.EndDate);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public DataTable GetMilkParlor_IC_Id(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetMilkParlor_IC_Id";
            cmd.Parameters.Add("@InchargerId", objMilkParlorDTO.InchargerId);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public DataTable GetMKSales_IC(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetMKSales_IC";
            cmd.Parameters.Add("@MilkParlorId", objMilkParlorDTO.MilkParlorId);
            cmd.Parameters.Add("@StartDate", objMilkParlorDTO.StartDate);
            cmd.Parameters.Add("@EndDate", objMilkParlorDTO.EndDate);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public DataTable GetMilkParlor_AreaId(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetMilkParlor_AreaId";
            cmd.Parameters.Add("@AreaId", objMilkParlorDTO.AreaId);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
        public DataTable GetMP_Sales_ProductId(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {

            DataTable tab = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetMP_Sales_ProductId";
            cmd.Parameters.Add("@ProductId", objMilkParlorDTO.ProductId);
            cmd.Parameters.Add("@StartDate", objMilkParlorDTO.StartDate);
            cmd.Parameters.Add("@EndDate", objMilkParlorDTO.EndDate);
            adp = new SqlDataAdapter(cmd);
            adp.Fill(tab);
            con.Close();
            return tab;
        }
    }
}