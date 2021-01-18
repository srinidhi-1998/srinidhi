<%@ Page Title="" Language="C#" MasterPageFile="~/MilkParlor.Master" AutoEventWireup="true" CodeBehind="ProductSales.aspx.cs" Inherits="MilkParlorSystem.ProductSales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="grid-form1">
        <h3 id="forms-example" class="">
            Product Sales</h3>
            <div class="row">
           <div class="col-lg-6 col-md-6 col-sm-6">
        <div class="form-group">
            <label>
               Select Product Name</label>
            <asp:DropDownList ID="ddlProduct" class="form-control" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Select Product Name"
                ControlToValidate="ddlProduct" ForeColor="#FF3300" ValidationGroup="A" InitialValue="--Select--"></asp:RequiredFieldValidator>
        </div>
         <div class="form-group">
            <label>
                Enter Customer Name</label>
            <asp:TextBox ID="txtCustomer" class="form-control" runat="server" placeholder="Enter Customer Name"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Customer Name"
                ControlToValidate="txtCustomer" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
         <div class="form-group">
            <label>
                Product Qty</label>
            <asp:TextBox ID="txtQty" class="form-control" runat="server" 
                 placeholder="Enter Product Qty" AutoPostBack="True" 
                 ontextchanged="txtQty_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Product Qty"
                ControlToValidate="txtQty" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
         <div class="form-group">
            <label>
                Total Cost</label>
            <asp:TextBox ID="txtCost" class="form-control" runat="server" ReadOnly="true"></asp:TextBox>
            
        </div>
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label>
        <div class="">
            <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Submit" OnClick="btnSubmit_Click"
                ValidationGroup="A" />
           
        </div>
        </div>
         <div class="col-lg-6 col-md-6 col-sm-6">
          <h3 class="">
            Product Details</h3>
         <asp:Table class="table table-striped table-bordered table-hover" ID="Table1" runat="server">
                </asp:Table>
                <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
         <h3 class="">
            Product Stock Details</h3>
                 <asp:Table class="table table-striped table-bordered table-hover" ID="Table2" runat="server">
                </asp:Table>
         </div>
         </div>
    </div>
</asp:Content>
