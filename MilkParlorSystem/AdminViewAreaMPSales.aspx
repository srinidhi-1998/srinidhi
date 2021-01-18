<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminViewAreaMPSales.aspx.cs" Inherits="MilkParlorSystem.AdminViewAreaMPSales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="grid-form1">
        <h3 id="forms-example" class="">
            Milk Product Sales Details</h3>
        <br />
        <div class="row">
            <div class="col-sm-12">
              <div class="form-group">
            <label>
                Select Area</label>
                 <asp:DropDownList ID="ddlArea" class="form-control" runat="server" 
                      AutoPostBack="True" onselectedindexchanged="ddlArea_SelectedIndexChanged">
                 </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Select Area"
                ControlToValidate="ddlArea" InitialValue="--Select--" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
            
        </div>
             <div class="form-group">
            <label>
                Select Milk Parlor</label>
                 <asp:DropDownList ID="ddlMilkParlor" class="form-control" runat="server">
                 </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select Milk Parlor"
                ControlToValidate="ddlMilkParlor" InitialValue="--Select--" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
            
        </div>
                <div class="form-group">
            <label>
                Select Start Date</label>
            <asp:TextBox ID="txtStartDate" class="form-control datepicker" runat="server" placeholder="Select Start Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Select Start Date"
                ControlToValidate="txtStartDate" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
            
        </div>
         <div class="form-group">
            <label>
                Select End Date</label>
            <asp:TextBox ID="txtEndDate" class="form-control datepicker" runat="server" placeholder="Select End Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Select End Date"
                ControlToValidate="txtEndDate" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
            
        </div>
         <div class="">
            <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Submit" OnClick="btnSubmit_Click"
                ValidationGroup="A" />
           
        </div>
                <asp:Chart ID="Chart1" runat="server">
                 <Legends>
                        <asp:Legend Alignment="Center" Docking="Top" IsTextAutoFit="False" Name="Default"
                            LegendStyle="Row" />
                    </Legends>
                    <Series>
                        <asp:Series Name="Series1">
                        </asp:Series>
                    </Series>
                    <ChartAreas>
                        <asp:ChartArea Name="ChartArea1">
                        </asp:ChartArea>
                    </ChartAreas>
                </asp:Chart>
                <asp:Chart ID="Chart2" runat="server">
                                        <Legends>
                                            <asp:Legend Alignment="Center" Docking="Bottom" IsTextAutoFit="False" Name="Default"
                                                LegendStyle="Row" />
                                        </Legends>
                                        <Series>
                                            <asp:Series Name="Series1" ChartType="Pie">
                                            </asp:Series>
                                        </Series>
                                        <ChartAreas>
                                            <asp:ChartArea Name="ChartArea1">
                                            </asp:ChartArea>
                                        </ChartAreas>
                                    </asp:Chart>
            </div>
        </div>
    </div>
</asp:Content>
