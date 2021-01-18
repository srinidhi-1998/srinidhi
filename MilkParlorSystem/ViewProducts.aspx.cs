using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class ViewProducts : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadProducts();
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
                TableHeaderCell hc4 = new TableHeaderCell();


                hc1.Text = "Product Name";
                hr.Cells.Add(hc1);
                hc2.Text = "Description";
                hr.Cells.Add(hc2);
                hc3.Text = "Price";
                hr.Cells.Add(hc3);
                hc4.Text = "Edit";
                hr.Cells.Add(hc4);
                Table1.Rows.Add(hr);
                for (int i = 0; i < tab.Rows.Count; i++)
                {

                    TableRow row = new TableRow();

                    Label lblProductName = new Label();
                    //lblTitle.Width = 100;
                    lblProductName.Text = tab.Rows[i]["ProductName"].ToString();
                    TableCell ProductName = new TableCell();
                    ProductName.Controls.Add(lblProductName);


                    Label lblDescription = new Label();
                    //lblSubTitle.Width = 100;
                    lblDescription.Text = tab.Rows[i]["Description"].ToString();
                    TableCell Description = new TableCell();
                    Description.Controls.Add(lblDescription);

                    Label lblPrice = new Label();
                    //lblDate.Width = 50;
                    lblPrice.Text = tab.Rows[i]["Price"].ToString();
                    TableCell Price = new TableCell();
                    Price.Controls.Add(lblPrice);


                    LinkButton Edit = new LinkButton();
                    Edit.Text = "Edit";
                    Edit.ID = "lnkEdit" + i.ToString();
                    Edit.CommandArgument = tab.Rows[i]["ProductId"].ToString();
                    Edit.Click += new EventHandler(Edit_Click);

                    TableCell EditCell = new TableCell();
                    EditCell.Controls.Add(Edit);


                    //row.Controls.Add(courseid);
                    row.Controls.Add(ProductName);
                    row.Controls.Add(Description);
                    row.Controls.Add(Price);
                    row.Controls.Add(EditCell);
                    Table1.Controls.Add(row);

                }
            }
            else
            {
                lblMsg.Text = "No Record Found";
            }
        }

        void Edit_Click(object sender, EventArgs e)
        {
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            LinkButton lnk = (LinkButton)sender;
            objMilkParlorDTO.ProductId = int.Parse(lnk.CommandArgument.ToString());
            Response.Redirect("AddProduct.aspx?ProductId=" + objMilkParlorDTO.ProductId);
        }
    }
}