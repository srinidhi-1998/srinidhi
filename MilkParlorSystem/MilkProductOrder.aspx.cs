using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class MilkProductOrder : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objMilkParlorBLL = new BLL.MilkParlorBLL();
                DataTable tab = new DataTable();
                tab = objMilkParlorBLL.GetProductDetails();
                ddlProduct.DataSource = tab;
                ddlProduct.DataTextField = "ProductName";
                ddlProduct.DataValueField = "ProductId";
                ddlProduct.DataBind();
                ddlProduct.Items.Insert(0, "--Select--");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.UserId = Session["UserId"].ToString();
            objMilkParlorDTO.Qty = int.Parse(txtQty.Text);
            objMilkParlorDTO.ProductId = int.Parse(ddlProduct.SelectedItem.Value);
            string result = objMilkParlorBLL.MilkProduct_Order(objMilkParlorDTO);
            if (result == "1")
            {
                txtQty.Text = "";
                ddlProduct.SelectedIndex = 0;
                lblMsg.Text = "Product Order Placed Successfully";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Font.Bold = true;

            }
            else if (result == "0")
            {

                txtQty.Text = "";
                ddlProduct.SelectedIndex = 0;
                lblMsg.Text = "Product Order Placed Error";
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Font.Bold = true;
            }
        }
    }
}