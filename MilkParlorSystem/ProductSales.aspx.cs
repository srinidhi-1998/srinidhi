using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class ProductSales : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        static int Cost = 0;
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
            LoadProducts();
            LoadProductStock();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.ProductId = int.Parse(ddlProduct.SelectedItem.Value);
            objMilkParlorDTO.MilkParlorId = int.Parse(Session["UserId"].ToString());
            objMilkParlorDTO.Name = txtCustomer.Text;
            objMilkParlorDTO.Qty = int.Parse(txtQty.Text);
            string result = objMilkParlorBLL.ProductSales(objMilkParlorDTO);
            if (result == "1")
            {
                txtCustomer.Text = txtCost.Text = txtQty.Text = "";
                ddlProduct.SelectedIndex = 0;
                LoadProductStock();
                lblMsg.Text = "Product Sales & Stock Updated Successfully";
                lblMsg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                txtCustomer.Text = txtCost.Text = txtQty.Text = "";
                ddlProduct.SelectedIndex = 0;
                lblMsg.Text = "Product Sales & Stock Updation Error";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }

        }
        private void LoadProductStock()
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.MilkParlorId = int.Parse(Session["UserId"].ToString());
            DataTable tab = new DataTable();
            tab = objMilkParlorBLL.GetMilkParlorStock_Id(objMilkParlorDTO);
            Table2.Controls.Clear();
            lblMsg.Text = "";
            if (tab.Rows.Count > 0)
            {
                TableRow hr = new TableRow();
                TableHeaderCell hc1 = new TableHeaderCell();
                TableHeaderCell hc2 = new TableHeaderCell();


                hc1.Text = "Product Name";
                hr.Cells.Add(hc1);
                hc2.Text = "Qty";
                hr.Cells.Add(hc2);
                Table2.Rows.Add(hr);
                for (int i = 0; i < tab.Rows.Count; i++)
                {

                    TableRow row = new TableRow();

                    Label lblName = new Label();
                    lblName.Text = tab.Rows[i]["ProductName"].ToString();
                    TableCell Name = new TableCell();
                    Name.Controls.Add(lblName);


                    Label lblQty = new Label();
                    lblQty.Text = tab.Rows[i]["Qty"].ToString();
                    TableCell Qty = new TableCell();
                    Qty.Controls.Add(lblQty);


                    row.Controls.Add(Name);
                    row.Controls.Add(Qty);
                    Table2.Controls.Add(row);

                }
            }
            else
            {
                //lblMsg.Text = "No Record Found";
            }
        }
        private void LoadProducts()
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            DataTable tab = new DataTable();
            tab = objMilkParlorBLL.GetProductDetails();
            Table1.Controls.Clear();
            lblMsg.Text = "";
            if (tab.Rows.Count > 0)
            {
                TableRow hr = new TableRow();
                TableHeaderCell hc1 = new TableHeaderCell();
                TableHeaderCell hc2 = new TableHeaderCell();
                TableHeaderCell hc3 = new TableHeaderCell();


                hc1.Text = "Product Name";
                hr.Cells.Add(hc1);
                hc2.Text = "Description";
                hr.Cells.Add(hc2);
                hc3.Text = "Price";
                hr.Cells.Add(hc3);
                Table1.Rows.Add(hr);
                for (int i = 0; i < tab.Rows.Count; i++)
                {

                    TableRow row = new TableRow();

                    Label lblProductName = new Label();
                    lblProductName.Text = tab.Rows[i]["ProductName"].ToString();
                    TableCell ProductName = new TableCell();
                    ProductName.Controls.Add(lblProductName);


                    Label lblDescription = new Label();
                    lblDescription.Text = tab.Rows[i]["Description"].ToString();
                    TableCell Description = new TableCell();
                    Description.Controls.Add(lblDescription);

                    Label lblPrice = new Label();
                    lblPrice.Text = tab.Rows[i]["Price"].ToString();
                    TableCell Price = new TableCell();
                    Price.Controls.Add(lblPrice);

                    row.Controls.Add(ProductName);
                    row.Controls.Add(Description);
                    row.Controls.Add(Price);
                    Table1.Controls.Add(row);

                }
            }
            else
            {
                lblMsg.Text = "No Record Found";
            }
        }
        protected void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (ddlProduct.SelectedItem.Text != "--Select--")
            {
                objMilkParlorBLL = new BLL.MilkParlorBLL();
                objMilkParlorDTO = new DTO.MilkParlorDTO();
                objMilkParlorDTO.ProductId = int.Parse(ddlProduct.SelectedItem.Value);
                DataTable tab = new DataTable();
                tab = objMilkParlorBLL.GetProduct_Id(objMilkParlorDTO);
                Cost = int.Parse(txtQty.Text) * int.Parse(tab.Rows[0]["Price"].ToString());
                txtCost.Text = Cost.ToString();
            }
            else
            {
 
            }
        }
    }
}