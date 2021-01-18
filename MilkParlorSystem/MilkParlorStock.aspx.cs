using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class MilkParlorStock : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadProductStock();
        }
        private void LoadProductStock()
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.MilkParlorId = int.Parse(Session["UserId"].ToString());
            DataTable tab = new DataTable();
            tab = objMilkParlorBLL.GetMilkParlorStock_Id(objMilkParlorDTO);
            Table1.Controls.Clear();
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
                Table1.Rows.Add(hr);
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