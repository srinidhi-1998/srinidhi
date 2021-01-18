using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class MilkParlorWalletDetails : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadWallet();
        }
        private void LoadWallet()
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.UserId = Session["UserId"].ToString();
            DataTable tab = new DataTable();
            tab = objMilkParlorBLL.GetWallet_MP(objMilkParlorDTO);
            Table1.Controls.Clear();
            lblMsg.Text = "";
            if (tab.Rows.Count > 0)
            {
                TableRow hr = new TableRow();
                TableHeaderCell hc1 = new TableHeaderCell();
                TableHeaderCell hc2 = new TableHeaderCell();

                lblMsg.Text = "Total Balance Amount Rs." + tab.Rows[0]["Balance"].ToString() + "/-";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                hc1.Text = "Deposite Date";
                hr.Cells.Add(hc1);
                hc2.Text = "Amount";
                hr.Cells.Add(hc2);
                Table1.Rows.Add(hr);
                for (int i = 0; i < tab.Rows.Count; i++)
                {

                    TableRow row = new TableRow();

                    Label lblDepositeDate = new Label();
                    //lblTitle.Width = 100;
                    lblDepositeDate.Text = tab.Rows[i]["DepositeDate"].ToString();
                    TableCell DepositeDate = new TableCell();
                    DepositeDate.Controls.Add(lblDepositeDate);


                    Label lblAmount = new Label();
                    //lblSubTitle.Width = 100;
                    lblAmount.Text = tab.Rows[i]["Amount"].ToString();
                    TableCell Amount = new TableCell();
                    Amount.Controls.Add(lblAmount);

                    
                    row.Controls.Add(DepositeDate);
                    row.Controls.Add(Amount);
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