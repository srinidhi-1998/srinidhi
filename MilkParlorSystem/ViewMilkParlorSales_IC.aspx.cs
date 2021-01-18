using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.DataVisualization.Charting;

namespace MilkParlorSystem
{
    public partial class ViewMilkParlorSales_IC : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objMilkParlorBLL = new BLL.MilkParlorBLL();
                DataTable tab = new DataTable();
                objMilkParlorDTO = new DTO.MilkParlorDTO();
                objMilkParlorDTO.InchargerId = int.Parse(Session["UserId"].ToString());
                tab = objMilkParlorBLL.GetMilkParlor_IC_Id(objMilkParlorDTO);
                ddlMilkParlor.DataSource = tab;
                ddlMilkParlor.DataTextField = "Name";
                ddlMilkParlor.DataValueField = "MilkParlorId";
                ddlMilkParlor.DataBind();
                ddlMilkParlor.Items.Insert(0, "--Select--");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            objMilkParlorDTO = new DTO.MilkParlorDTO();
            objMilkParlorDTO.MilkParlorId = int.Parse(ddlMilkParlor.SelectedItem.Value);
            objMilkParlorDTO.StartDate = txtStartDate.Text;
            objMilkParlorDTO.EndDate = txtEndDate.Text;
            DataTable tab = new DataTable();
            tab = objMilkParlorBLL.GetMKSales_IC(objMilkParlorDTO);
            if (tab.Rows.Count > 0)
            {
                Chart1.Series.Clear();
                Chart1.Series.Add("ProductName");
                Chart1.Series[0].XValueMember = "ProductName";
                Chart1.Series[0].YValueMembers = "Qty";
                Chart1.Series[0].ChartType = SeriesChartType.Column;
                Chart1.Legends[0].Enabled = true;
                Chart1.DataSource = tab;
                Chart1.DataBind();


                foreach (Series charts in Chart1.Series)
                {
                    foreach (DataPoint point in charts.Points)
                    {
                        point.Label = string.Format("{0:0} - {1}", point.AxisLabel, point.YValues[0] + "");
                    }
                }
                //Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            }
        }
    }
}