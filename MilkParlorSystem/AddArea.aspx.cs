using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MilkParlorSystem
{
    public partial class AddArea : System.Web.UI.Page
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
            objMilkParlorDTO.AreaName = txtAreaName.Text;
            string result = objMilkParlorBLL.CreateArea(objMilkParlorDTO);
            if (result == "1")
            {
                txtAreaName.Text = "";
                lblMsg.Text = "Area Created Successfully";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Font.Bold = true;

            }
            else if (result == "2")
            {
                txtAreaName.Text = "";
                lblMsg.Text = "Area Created Already!!!";
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Font.Bold = true;

            }
            else
            {
                txtAreaName.Text = "";
                lblMsg.Text = "Area Creation Error";
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Font.Bold = true;
            }

        }
    }
}