<%@ Page Title="" Language="C#" MasterPageFile="~/MilkParlor.Master" AutoEventWireup="true" CodeBehind="ViewOrderDetails.aspx.cs" Inherits="MilkParlorSystem.ViewOrderDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="grid-form1">
        <h3 id="forms-example" class="">
            Milk Product Order Details</h3>
        <br />
        <div class="form-group">
            <label>
               Select Status</label>
            <asp:DropDownList ID="ddlStatus" class="form-control" runat="server" 
                AutoPostBack="True" onselectedindexchanged="ddlStatus_SelectedIndexChanged">
                <asp:ListItem>--Select--</asp:ListItem>
                <asp:ListItem>Approve</asp:ListItem>
                <asp:ListItem>Pending</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <asp:Table class="table table-striped table-bordered table-hover" ID="Table1" runat="server">
                </asp:Table>
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
