using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class ICView_OrderDetails : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }
        private void LoadOrder()
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.UserId = Session["UserId"].ToString();
            DataTable tab = new DataTable();
            tab = objMilkParlorBLL.GetOrderDetails_IC(objMilkParlorDTO);
            Table1.Controls.Clear();
            lblMsg.Text = "";
            if (tab.Rows.Count > 0)
            {
                TableRow hr = new TableRow();
                TableHeaderCell hc1 = new TableHeaderCell();
                TableHeaderCell hc2 = new TableHeaderCell();
                TableHeaderCell hc3 = new TableHeaderCell();
                TableHeaderCell hc4 = new TableHeaderCell();
                TableHeaderCell hc5 = new TableHeaderCell();


                hc1.Text = "Milk Parlor Name";
                hr.Cells.Add(hc1);
                hc2.Text = "Date Order";
                hr.Cells.Add(hc2);
                hc3.Text = "Product Name";
                hr.Cells.Add(hc3);
                hc4.Text = "Qty";
                hr.Cells.Add(hc4);
                hc5.Text = "";
                hr.Cells.Add(hc5);
                Table1.Rows.Add(hr);
                for (int i = 0; i < tab.Rows.Count; i++)
                {

                    TableRow row = new TableRow();

                    Label lblName = new Label();
                    lblName.Text = tab.Rows[i]["Name"].ToString();
                    TableCell Name = new TableCell();
                    Name.Controls.Add(lblName);


                    Label lblOrderDate = new Label();
                    lblOrderDate.Text = tab.Rows[i]["OrderDate"].ToString();
                    TableCell OrderDate = new TableCell();
                    OrderDate.Controls.Add(lblOrderDate);

                    Label lblProductName = new Label();
                    lblProductName.Text = tab.Rows[i]["ProductName"].ToString();
                    TableCell ProductName = new TableCell();
                    ProductName.Controls.Add(lblProductName);

                    Label lblQty = new Label();
                    lblQty.Text = tab.Rows[i]["Qty"].ToString();
                    TableCell Qty = new TableCell();
                    Qty.Controls.Add(lblQty);


                    LinkButton Approve = new LinkButton();
                    Approve.Text = "Approve";
                    Approve.ID = "lnkApprove" + i.ToString();
                    Approve.CommandArgument = tab.Rows[i]["OrderId"].ToString();
                    Approve.Click += new EventHandler(Approve_Click);

                    TableCell ApproveCell = new TableCell();
                    ApproveCell.Controls.Add(Approve);


                    //row.Controls.Add(courseid);
                    row.Controls.Add(Name);
                    row.Controls.Add(OrderDate);
                    row.Controls.Add(ProductName);
                    row.Controls.Add(Qty);
                    row.Controls.Add(ApproveCell);
                    Table1.Controls.Add(row);

                }
            }
            else
            {
                lblMsg.Text = "No Record Found";
            }
        }

        void Approve_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            LinkButton lnk = (LinkButton)sender;
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.OrderId = int.Parse(lnk.CommandArgument.ToString());
            string res = objMilkParlorBLL.OrderDetails_Approve(objMilkParlorDTO);
            if (res == "1")
            {
                LoadOrder();
            }
        }

       
    }
}