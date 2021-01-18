using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class AddIncharger : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objMilkParlorBLL = new BLL.MilkParlorBLL();
                DataTable tab = new DataTable();
                tab = objMilkParlorBLL.GetAreaDetails();
                ddlArea.DataSource = tab;
                ddlArea.DataTextField = "AreaName";
                ddlArea.DataValueField = "AreaId";
                ddlArea.DataBind();
                ddlArea.Items.Insert(0, "--Select--");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.AreaId = int.Parse(ddlArea.SelectedItem.Value);
            objMilkParlorDTO.Name = txtInchargerName.Text;
            objMilkParlorDTO.EmailId = txtEmailId.Text;
            objMilkParlorDTO.MobileNo = txtMobileNo.Text;
            objMilkParlorDTO.Address = txtAddress.Text;
            string result = objMilkParlorBLL.CreateIncharger(objMilkParlorDTO);
            if (result.Split(',')[0] == "1")
            {
                
                ddlArea.SelectedIndex = 0;
                txtInchargerName.Text = txtEmailId.Text = txtMobileNo.Text = txtAddress.Text = "";
                lblMsg.Text = "Incharger Created Successfully & Incharger Id:" + result.Split(',')[1] + " & Password:" + result.Split(',')[2];
                lblMsg.ForeColor = System.Drawing.Color.Green;
                lblMsg.Font.Bold = true;

            }
            
            else if(result.Split(',')[0] == "0")
            {
                ddlArea.SelectedIndex = 0;
                txtInchargerName.Text = txtEmailId.Text = txtMobileNo.Text = txtAddress.Text = "";
                lblMsg.Text = "Incharger Creation Error";
                lblMsg.ForeColor = System.Drawing.Color.Red;
                lblMsg.Font.Bold = true;
            }
        }
    }
}