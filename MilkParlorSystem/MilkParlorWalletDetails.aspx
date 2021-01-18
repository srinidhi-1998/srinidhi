<%@ Page Title="" Language="C#" MasterPageFile="~/MilkParlor.Master" AutoEventWireup="true" CodeBehind="MilkParlorWalletDetails.aspx.cs" Inherits="MilkParlorSystem.MilkParlorWalletDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="grid-form1">
        <h3 id="forms-example" class="">
            Wallet Details</h3>
        <br />
        <div class="row">
            <div class="col-sm-12">
                <asp:Table class="table table-striped table-bordered table-hover" ID="Table1" runat="server">
                </asp:Table>
                <asp:Label ID="lblMsg" runat="server" Font-Bold="True" class="pull-right"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
