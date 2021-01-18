<%@ Page Title="" Language="C#" MasterPageFile="~/InchargerHome.Master" AutoEventWireup="true" CodeBehind="InchargerHome.aspx.cs" Inherits="MilkParlorSystem.InchargerHome1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="grid-form1">
        <h3 id="forms-example" class="">
            Change Password</h3>
        <div class="form-group">
            <label>
                Enter New Password</label>
            
            <asp:TextBox ID="txtNewPassword" class="form-control" runat="server" placeholder="New Password"
                TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter New Password"
                ControlToValidate="txtNewPassword" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>
               Enter Confirm Password</label>
            <asp:TextBox ID="txtConfirmPassword" class="form-control" runat="server" placeholder="Confirm Password"
                TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Confirm Password"
                ControlToValidate="txtConfirmPassword" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Not Match"
                ControlToCompare="txtNewPassword" ControlToValidate="txtConfirmPassword" ForeColor="#FF3300"
                ValidationGroup="A"></asp:CompareValidator>
        </div>
        <asp:Label ID="lblMsg" runat="server" Font-Bold="True"></asp:Label>
        <div class="">
            <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Submit" OnClick="btnSubmit_Click"
                ValidationGroup="A" />
        </div>
    </div>
</asp:Content>
