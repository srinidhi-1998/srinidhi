using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class AddProduct : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        static int ProductId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ProductId"] != null)
                {
                    ProductId =int.Parse(Request.QueryString["ProductId"]);
                    LoadProduct();
                }
            }
        }
        public void LoadProduct()
        {
            try
            {
                btnSubmit.Text = "Update";
                objMilkParlorBLL = new BLL.MilkParlorBLL();
                objMilkParlorDTO = new DTO.MilkParlorDTO();
                objMilkParlorDTO.ProductId = ProductId;
                DataTable tab = new DataTable();
                tab = objMilkParlorBLL.GetProduct_Id(objMilkParlorDTO);
                txtProductName.Text = tab.Rows[0]["ProductName"].ToString();
                txtDescription.Text = tab.Rows[0]["Description"].ToString();
                txtPrice.Text = tab.Rows[0]["Price"].ToString();
            }
            catch (Exception ex)
            {

            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();

            objMilkParlorDTO.ProductName = txtProductName.Text;
            objMilkParlorDTO.Description = txtDescription.Text;
            objMilkParlorDTO.Price = int.Parse(txtPrice.Text);
            if (btnSubmit.Text == "Update")
            {
                objMilkParlorDTO.ProductId = ProductId;
                string result = objMilkParlorBLL.UpdateProduct(objMilkParlorDTO);
                if (result == "1")
                {
                    txtProductName.Text = txtDescription.Text = txtPrice.Text = "";
                    lblMsg.Text = "Product Updated Successfully";
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                    lblMsg.Font.Bold = true;
                    btnSubmit.Text = "Submit";
                }
                
                else
                {
                    txtProductName.Text = txtDescription.Text = txtPrice.Text = "";
                    lblMsg.Text = "Product Updation Error";
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Font.Bold = true;
                }
            }
            else
            {
                string result = objMilkParlorBLL.CreateProduct(objMilkParlorDTO);
                if (result == "1")
                {
                    txtProductName.Text = txtDescription.Text = txtPrice.Text = "";
                    lblMsg.Text = "Product Created Successfully";
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                    lblMsg.Font.Bold = true;

                }
                else if (result == "2")
                {
                    txtProductName.Text = txtDescription.Text = txtPrice.Text = "";
                    lblMsg.Text = "Product Created Already!!!";
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Font.Bold = true;

                }
                else
                {
                    txtProductName.Text = txtDescription.Text = txtPrice.Text = "";
                    lblMsg.Text = "Product Creation Error";
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Font.Bold = true;
                }
            }
        }
    }
}