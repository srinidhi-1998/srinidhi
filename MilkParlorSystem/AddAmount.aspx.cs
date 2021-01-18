using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MilkParlorSystem
{
    public partial class AddAmount : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.UserId = Session["UserId"].ToString();
            objMilkParlorDTO.Amount = int.Parse(txtAmt.Text);
            string result = objMilkParlorBLL.DepositeAmt_MP(objMilkParlorDTO);
            if (result == "1")
            {
                txtAmt.Text = "";
                lblMsg.Text = "Amount Deposite Wallet Successfully";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Font.Bold = true;

            }
            else if (result == "0")
            {

                txtAmt.Text = "";
                lblMsg.Text = "Amount Deposite Wallet Error";
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Font.Bold = true;
            }
        }
    }
}