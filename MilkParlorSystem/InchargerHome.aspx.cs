using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MilkParlorSystem
{
    public partial class InchargerHome1 : System.Web.UI.Page
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
            objMilkParlorDTO.Password = txtNewPassword.Text;
            objMilkParlorDTO.UserType = Session["UserType"].ToString();
            string result = objMilkParlorBLL.ChangePassword(objMilkParlorDTO);
            if (result == "1")
            {
                txtNewPassword.Text = txtConfirmPassword.Text = "";
                lblMsg.Text = "Password Changed Successfully";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Font.Bold = true;

            }
            else if (result == "0")
            {
                txtNewPassword.Text = txtConfirmPassword.Text = "";
                lblMsg.Text = "Password Change Error";
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Font.Bold = true;

            }
        }
    }
}