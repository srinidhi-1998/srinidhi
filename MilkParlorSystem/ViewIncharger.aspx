<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ViewIncharger.aspx.cs" Inherits="MilkParlorSystem.ViewIncharger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="grid-form1">
        <h3 id="forms-example" class="">
            Incharger Details</h3>
             <div class="form-group">
            <label>
                Select Area</label>
                <asp:DropDownList ID="ddlArea" runat="server" class="form-control" 
                     onselectedindexchanged="ddlArea_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select Area"
                ControlToValidate="ddlArea" ForeColor="#FF3300" InitialValue="--Select--" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-12">
                <asp:Table class="table table-striped table-bordered table-hover" ID="Table1" runat="server">
                </asp:Table>
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
