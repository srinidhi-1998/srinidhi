<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AddIncharger.aspx.cs" Inherits="MilkParlorSystem.AddIncharger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="grid-form1">
        <h3 id="forms-example" class="">
            Incharger Details</h3>
            <div class="form-group">
            <label>
                Select Area</label>
                <asp:DropDownList ID="ddlArea" runat="server" class="form-control">
                </asp:DropDownList>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select Area"
                ControlToValidate="ddlArea" ForeColor="#FF3300" InitialValue="--Select--" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label>
                Incharger Name</label>
            <asp:TextBox ID="txtInchargerName" class="form-control" runat="server" placeholder="Enter Incharger Name"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Incharger Name"
                ControlToValidate="txtInchargerName" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        </div>
         <div class="form-group">
            <label>
                Enter Email Id</label>
            <asp:TextBox ID="txtEmailId" class="form-control" runat="server" placeholder="Enter Email Id"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter Email Id"
                ControlToValidate="txtEmailId" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEmailId"
                    ErrorMessage="Email ID Incorrect" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ValidationGroup="A"></asp:RegularExpressionValidator>
        </div>
         <div class="form-group">
            <label>
                Enter Mobile No</label>
            <asp:TextBox ID="txtMobileNo" class="form-control" runat="server" placeholder="Enter Mobile No"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Mobile No"
                ControlToValidate="txtMobileNo" ForeColor="#FF3300" ValidationGroup="A"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter Mobile No"
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
