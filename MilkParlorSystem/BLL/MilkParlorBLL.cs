using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace MilkParlorSystem.BLL
{
    public class MilkParlorBLL
    {
        MilkParlorSystem.DAL.MilkParlorDAL objMilkParlorDAL = null;
        public string LoginVerify(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.LoginVerify(objMilkParlorDTO);
        }
        public string CreateArea(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.CreateArea(objMilkParlorDTO);
        }
        public string CreateProduct(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.CreateProduct(objMilkParlorDTO);
        }
        public DataTable GetProductDetails()
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetProductDetails();
        }
        public DataTable GetProduct_Id(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetProduct_Id(objMilkParlorDTO);
        }
        public string UpdateProduct(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.UpdateProduct(objMilkParlorDTO);
        }
        public DataTable GetAreaDetails()
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetAreaDetails();
        }
        public string CreateIncharger(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.CreateIncharger(objMilkParlorDTO);
        }
        public string CreateMilkParlor(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.CreateMilkParlor(objMilkParlorDTO);
        }
        public string DepositeAmt_MP(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.DepositeAmt_MP(objMilkParlorDTO);
        }
        public DataTable GetWallet_MP(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetWallet_MP(objMilkParlorDTO);
        }
        public string MilkProduct_Order(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.MilkProduct_Order(objMilkParlorDTO);
        }
        public DataTable GetOrderDetails_IC(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetOrderDetails_IC(objMilkParlorDTO);
        }
        public string OrderDetails_Approve(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.OrderDetails_Approve(objMilkParlorDTO);
        }
        public DataTable GetIncharger_AreaId(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetIncharger_AreaId(objMilkParlorDTO);
        }
        public string ChangePassword(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.ChangePassword(objMilkParlorDTO);
        }
        public DataTable GetMilkProduct_Order_Id(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetMilkProduct_Order_Id(objMilkParlorDTO);
        }
        public string ProductSales(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.ProductSales(objMilkParlorDTO);
        }
        public DataTable GetMilkParlorStock_Id(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetMilkParlorStock_Id(objMilkParlorDTO);
        }
        public DataTable GetMilkParlor_Sales_Id(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetMilkParlor_Sales_Id(objMilkParlorDTO);
        }
        public DataTable GetMilkParlor_IC_Id(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetMilkParlor_IC_Id(objMilkParlorDTO);
        }
        
        public DataTable GetMKSales_IC(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetMKSales_IC(objMilkParlorDTO);
        }
        public DataTable GetMilkParlor_AreaId(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetMilkParlor_AreaId(objMilkParlorDTO);
        }
        public DataTable GetMP_Sales_ProductId(MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO)
        {
            objMilkParlorDAL = new DAL.MilkParlorDAL();
            return objMilkParlorDAL.GetMP_Sales_ProductId(objMilkParlorDTO);
        }
    }
}