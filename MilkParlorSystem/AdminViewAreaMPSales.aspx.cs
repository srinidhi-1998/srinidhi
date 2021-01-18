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
    public partial class AdminViewAreaMPSales : System.Web.UI.Page
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

                Chart2.Series.Clear();
                Chart2.Series.Add("ProductName");
                Chart2.Series[0].XValueMember = "ProductName";
                Chart2.Series[0].YValueMembers = "Qty";
                Chart2.Series[0].ChartType = SeriesChartType.Pie;
                Chart2.Legends[0].Enabled = true;
                Chart2.DataSource = tab;
                Chart2.DataBind();


                foreach (Series charts in Chart2.Series)
                {
                    foreach (DataPoint point in charts.Points)
                    {
                        point.Label = string.Format("{0:0} - {1}", point.AxisLabel, point.YValues[0] + "");
                    }
                }
                Chart2.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            }
        }

        protected void ddlArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                objMilkParlorBLL = new BLL.MilkParlorBLL();
                objMilkParlorDTO = new DTO.MilkParlorDTO();
                DataTable tab = new DataTable();
                objMilkParlorDTO.AreaId = int.Parse(ddlArea.SelectedItem.Value);
                tab = objMilkParlorBLL.GetMilkParlor_AreaId(objMilkParlorDTO);
                ddlMilkParlor.DataSource = tab;
                ddlMilkParlor.DataTextField = "Name";
                ddlMilkParlor.DataValueField = "MilkParlorId";
                ddlMilkParlor.DataBind();
                ddlMilkParlor.Items.Insert(0, "--Select--");
            }
            catch
            {
 
            }
        }
    }
}