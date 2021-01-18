<%@ Page Title="" Language="C#" MasterPageFile="~/MilkParlor.Master" AutoEventWireup="true" CodeBehind="MilkProductOrder.aspx.cs" Inherits="MilkParlorSystem.MilkProductOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="grid-form1">
        <h3 id="forms-example" class="">
            Milk Product Order Details</h3>
            <div class="form-group">
            <label>
                Select Product</label>
                <asp:DropDownList ID="ddlProduct" runat="server" class="form-control">
                </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select Area"
                ControlToValidate="ddlProduct" ForeColor="#FF3300" InitialValue="--Select--" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
       
         <div class="form-group">
            <label>
                Enter Qty</label>
            <asp:TextBox ID="txtQty" class="form-control" runat="server" placeholder="Enter Qty"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Qty"
                ControlToValidate="txtQty" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter Qty"
                ControlToValidate="txtQty" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtQty"
                                        ErrorMessage="Only Digits" ForeColor="#FF3300" ValidationExpression="^[0-9]*$" 
                                        ValidationGroup="A"></asp:RegularExpressionValidator>
        </div>
         
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label>
        <div class="">
            <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Submit" OnClick="btnSubmit_Click"
                ValidationGroup="A" />
           
        </div>
    </div>
</asp:Content>
