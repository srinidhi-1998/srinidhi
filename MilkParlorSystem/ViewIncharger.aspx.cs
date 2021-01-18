using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class ViewIncharger : System.Web.UI.Page
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

        protected void ddlArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadIncharger();
            }
            catch
            {
 
            }
        }

        private void LoadIncharger()
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.AreaId = int.Parse(ddlArea.SelectedItem.Value);
            DataTable tab = new DataTable();
            tab = objMilkParlorBLL.GetIncharger_AreaId(objMilkParlorDTO);
            Table1.Controls.Clear();
            lblMsg.Text = "";
            if (tab.Rows.Count > 0)
            {
                TableRow hr = new TableRow();
                TableHeaderCell hc1 = new TableHeaderCell();
                TableHeaderCell hc2 = new TableHeaderCell();
                TableHeaderCell hc3 = new TableHeaderCell();
                TableHeaderCell hc4 = new TableHeaderCell();


                hc1.Text = "Name";
                hr.Cells.Add(hc1);
                hc2.Text = "Email Id";
                hr.Cells.Add(hc2);
                hc3.Text = "Mobile No";
                hr.Cells.Add(hc3);
                hc4.Text = "Address";
                hr.Cells.Add(hc4);
                Table1.Rows.Add(hr);
                for (int i = 0; i < tab.Rows.Count; i++)
                {

                    TableRow row = new TableRow();

                    Label lblName = new Label();
                    lblName.Text = tab.Rows[i]["Name"].ToString();
                    TableCell Name = new TableCell();
                    Name.Controls.Add(lblName);


                    Label lblEmailId = new Label();
                    lblEmailId.Text = tab.Rows[i]["EmailId"].ToString();
                    TableCell EmailId = new TableCell();
                    EmailId.Controls.Add(lblEmailId);

                    Label lblMobileNo = new Label();
                    lblMobileNo.Text = tab.Rows[i]["MobileNo"].ToString();
                    TableCell MobileNo = new TableCell();
                    MobileNo.Controls.Add(lblMobileNo);

                    Label lblAddress = new Label();
                    lblAddress.Text = tab.Rows[i]["Address"].ToString();
                    TableCell Address = new TableCell();
                    Address.Controls.Add(lblAddress);

                    row.Controls.Add(Name);
                    row.Controls.Add(EmailId);
                    row.Controls.Add(MobileNo);
                    row.Controls.Add(Address);
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