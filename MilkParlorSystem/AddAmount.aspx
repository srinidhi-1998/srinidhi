<%@ Page Title="" Language="C#" MasterPageFile="~/MilkParlor.Master" AutoEventWireup="true" CodeBehind="AddAmount.aspx.cs" Inherits="MilkParlorSystem.AddAmount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="grid-form1">
        <h3 id="forms-example" class="">
            Wallet Details</h3>
        <div class="form-group">
            <label>
                Enter Amount</label>
            <asp:TextBox ID="txtAmt" class="form-control" runat="server" placeholder="Enter Amount"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Amount"
                ControlToValidate="txtAmt" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
        
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label>
        <div class="">
            <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Submit" OnClick="btnSubmit_Click"
                ValidationGroup="A" />
           
        </div>
    </div>
</asp:Content>
