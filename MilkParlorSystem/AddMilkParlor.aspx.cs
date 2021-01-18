using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class AddMilkParlor : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.UserId = Session["UserId"].ToString();
            objMilkParlorDTO.Name = txtName.Text;
            objMilkParlorDTO.MobileNo = txtMobileNo.Text;
            objMilkParlorDTO.Address = txtAddress.Text;
            string result = objMilkParlorBLL.CreateMilkParlor(objMilkParlorDTO);
            if (result.Split(',')[0] == "1")
            {

                
                txtName.Text = txtMobileNo.Text = txtAddress.Text = "";
                lblMsg.Text = "Milk Parlor Created Successfully & MailParlor Id:" + result.Split(',')[1] + " & Password:" + result.Split(',')[2];
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Font.Bold = true;

            }

            else if (result.Split(',')[0] == "0")
            {
                
                txtName.Text = txtMobileNo.Text = txtAddress.Text = "";
                lblMsg.Text = "Milk Parlor Creation Error";
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Font.Bold = true;
            }
        }
    }
}