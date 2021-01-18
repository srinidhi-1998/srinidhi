<%@ Page Title="" Language="C#" MasterPageFile="~/InchargerHome.Master" AutoEventWireup="true" CodeBehind="AddMilkParlor.aspx.cs" Inherits="MilkParlorSystem.AddMilkParlor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="grid-form1">
        <h3 id="forms-example" class="">
            Milk Parlor Details</h3>
           
        <div class="form-group">
            <label>
                Milk Parlor Name</label>
            <asp:TextBox ID="txtName" class="form-control" runat="server" placeholder="Enter Name"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Name"
                ControlToValidate="txtName" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
         
         <div class="form-group">
            <label>
                Enter Mobile No</label>
            <asp:TextBox ID="txtMobileNo" class="form-control" runat="server" placeholder="Enter Mobile No"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Mobile No"
                ControlToValidate="txtMobileNo" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtMobileNo"
                                        ErrorMessage="Only 10 Digits" ForeColor="#FF3300" ValidationExpression="[0-9]{10}"
                                        ValidationGroup="A"></asp:RegularExpressionValidator>
        </div>
         <div class="form-group">
            <label>
                Enter Address</label>
            <asp:TextBox ID="txtAddress" class="form-control" runat="server" placeholder="Enter Address"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter Address"
                ControlToValidate="txtAddress" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label>
        <div class="">
            <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Submit" OnClick="btnSubmit_Click"
                ValidationGroup="A" />
           
        </div>
    </div>
</asp:Content>
