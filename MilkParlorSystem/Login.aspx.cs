using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MilkParlorSystem
{
    public partial class Login : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.UserId = txtUserId.Text;
            objMilkParlorDTO.Password = txtPassword.Text;
            objMilkParlorDTO.UserType = ddlUserType.SelectedItem.Text;
            string result = objMilkParlorBLL.LoginVerify(objMilkParlorDTO);
            if (result.Split(',')[0] == "1")
            {
                if (result.Split(',')[1] == "1")
                {
                    Session["UserId"] = txtUserId.Text;
                    Session["UserType"] = ddlUserType.SelectedItem.Text;
                    switch (ddlUserType.SelectedItem.Text)
                    {
                        case "Admin": Response.Redirect("AdminHome.aspx");
                            break;
                        case "Incharger": Response.Redirect("InchargerHome.aspx");
                            break;
                        case "MilkParlor": Response.Redirect("MilkParlorHome.aspx");
                            break;
                    }
                }
                else
                {
                    lblMsg.Text = "Invalid User Id/Password,Kindly Check Approval Status";
                    lblMsg.ForeColor = System.Drawing.Color.White;
                }
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}