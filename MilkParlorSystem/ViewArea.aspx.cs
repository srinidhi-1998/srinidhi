using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MilkParlorSystem
{
    public partial class ViewArea : System.Web.UI.Page
    {
        MilkParlorSystem.BLL.MilkParlorBLL objMilkParlorBLL = null;
        MilkParlorSystem.DTO.MilkParlorDTO objMilkParlorDTO = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadArea();
        }

        private void LoadArea()
        {
            objMilkParlorBLL = new BLL.MilkParlorBLL();
            DataTable tab = new DataTable();
            tab = objMilkParlorBLL.GetAreaDetails();
            Table1.Controls.Clear();
            lblMsg.Text = "";
            if (tab.Rows.Count > 0)
            {
                TableRow hr = new TableRow();
                TableHeaderCell hc1 = new TableHeaderCell();


                hc1.Text = "Area Name";
                hr.Cells.Add(hc1);
                Table1.Rows.Add(hr);
                for (int i = 0; i < tab.Rows.Count; i++)
                {

                    TableRow row = new TableRow();

                    Label lblAreaName = new Label();
                    lblAreaName.Text = tab.Rows[i]["AreaName"].ToString();
                    TableCell AreaName = new TableCell();
                    AreaName.Controls.Add(lblAreaName);


                    row.Controls.Add(AreaName);
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