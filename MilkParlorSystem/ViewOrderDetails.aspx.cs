using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class ViewOrderDetails : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProducts();
            }
            catch
            {
 
            }

        }
        private void LoadProducts()
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.UserId = Session["UserId"].ToString();
            objMilkParlorDTO.Status = ddlStatus.SelectedItem.Text;
            DataTable tab = new DataTable();
            tab = objMilkParlorBLL.GetMilkProduct_Order_Id(objMilkParlorDTO);
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
                hc2.Text = "Qty";
                hr.Cells.Add(hc2);
                hc3.Text = "Order Date";
                hr.Cells.Add(hc3);
                Table1.Rows.Add(hr);
                for (int i = 0; i < tab.Rows.Count; i++)
                {

                    TableRow row = new TableRow();

                    Label lblProductName = new Label();
                    lblProductName.Text = tab.Rows[i]["ProductName"].ToString();
                    TableCell ProductName = new TableCell();
                    ProductName.Controls.Add(lblProductName);


                    Label lblQty = new Label();
                    lblQty.Text = tab.Rows[i]["Qty"].ToString();
                    TableCell Qty = new TableCell();
                    Qty.Controls.Add(lblQty);

                    Label lblOrderDate = new Label();
                    lblOrderDate.Text = tab.Rows[i]["OrderDate"].ToString();
                    TableCell OrderDate = new TableCell();
                    OrderDate.Controls.Add(lblOrderDate);

                    row.Controls.Add(ProductName);
                    row.Controls.Add(Qty);
                    row.Controls.Add(OrderDate);
                    Table1.Controls.Add(row);

                }
            }
            else
            {
                lblMsg.Text = "No Record Found";
            }
        }
    }
}