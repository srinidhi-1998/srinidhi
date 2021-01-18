<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddArea.aspx.cs" Inherits="MilkParlorSystem.AddArea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="grid-form1">
        <h3 id="forms-example" class="">
            Area Details</h3>
        <div class="form-group">
            <label>
                Area Name</label>
            <asp:TextBox ID="txtAreaName" class="form-control" runat="server" placeholder="Enter Area Name"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Area Name"
                ControlToValidate="txtAreaName" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
        
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label>
        <div class="">
            <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Submit" OnClick="btnSubmit_Click"
                ValidationGroup="A" />
           
        </div>
    </div>
</asp:Content>
