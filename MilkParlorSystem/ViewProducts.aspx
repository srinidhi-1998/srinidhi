<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ViewProducts.aspx.cs" Inherits="MilkParlorSystem.ViewProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="grid-form1">
        <h3 id="forms-example" class="">
            Product Details</h3>
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
