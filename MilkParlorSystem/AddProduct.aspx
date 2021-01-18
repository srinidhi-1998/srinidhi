<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="MilkParlorSystem.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="grid-form1">
        <h3 id="forms-example" class="">
            Product Details</h3>
        <div class="form-group">
            <label>
                Product Name</label>
            <asp:TextBox ID="txtProductName" class="form-control" runat="server" placeholder="Enter Product Name"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Product Name"
                ControlToValidate="txtProductName" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
         <div class="form-group">
            <label>
                Product Description</label>
            <asp:TextBox ID="txtDescription" class="form-control" runat="server" placeholder="Enter Description"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Description"
                ControlToValidate="txtDescription" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
         <div class="form-group">
            <label>
                Product Price</label>
            <asp:TextBox ID="txtPrice" class="form-control" runat="server" placeholder="Enter Price"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Price"
                ControlToValidate="txtPrice" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label>
        <div class="">
            <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Submit" OnClick="btnSubmit_Click"
                ValidationGroup="A" />
           
        </div>
    </div>
</asp:Content>
