<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MilkParlorSystem.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html lang="en">

<head>
	<title>Milk Parlor System</title>
	<!-- Meta-Tags -->
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta charset="utf-8">
	<meta name="keywords" content="Clear login Form a Responsive Web Template, Bootstrap Web Templates, Flat Web Templates, Android Compatible Web Template, Smartphone Compatible Web Template, Free Webdesigns for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design">
	<script>
	    addEventListener("load", function () {
	        setTimeout(hideURLbar, 0);
	    }, false);

	    function hideURLbar() {
	        window.scrollTo(0, 1);
	    }
	</script>
	<!-- //Meta-Tags -->
	<!-- Stylesheets -->
	<link href="css/font-awesome.css" rel="stylesheet">
	<link href="css/style_css.css" rel='stylesheet' type='text/css' />
	<!--// Stylesheets -->
	<!--fonts-->
	<!-- title -->
	<!-- body -->
	<link href="//fonts.googleapis.com/css?family=Poppins:100,100i,200,200i,300,300i,400,400i,500,500i,600,600i,700,700i,800,800i,900,900i&amp;subset=devanagari,latin-ext" rel="stylesheet">
	<!--//fonts-->
</head>

<body>
	<h1>login Form </h1>
	<div class="w3ls-login box box--big">
		<!-- form starts here -->
		<form id="form1" runat="server">
        <div class="agile-field-txt">
				<label>
					<i class="fa fa-user" aria-hidden="true"></i> User Type </label>
            <asp:DropDownList ID="ddlUserType" runat="server">
                <asp:ListItem>--Select--</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
                <asp:ListItem>Incharger</asp:ListItem>
                <asp:ListItem>MilkParlor</asp:ListItem>
            </asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select User Type"
                ControlToValidate="ddlUserType" ForeColor="#FF3300" ValidationGroup="A" InitialValue="--Select--" Font-Bold="true"></asp:RequiredFieldValidator>
			</div>
			<div class="agile-field-txt">
				<label>
					<i class="fa fa-user" aria-hidden="true"></i> User Id </label>
				
                <asp:TextBox ID="txtUserId" runat="server" placeholder="Enter User Id"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter User Id"
                ControlToValidate="txtUserId" ForeColor="#FF3300" ValidationGroup="A" Font-Bold="true"></asp:RequiredFieldValidator>
			</div>
			<div class="agile-field-txt">
				<label>
					<i class="fa fa-envelope" aria-hidden="true"></i> password </label>
				<asp:TextBox ID="txtPassword" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Password"
                ControlToValidate="txtPassword" ForeColor="#FF3300" ValidationGroup="A" Font-Bold="true"></asp:RequiredFieldValidator>
			</div>
			<!-- script for show password -->
			
			<!-- //script ends here -->
			<div class="w3ls-bot">
				
				<div class="form-end">
                    <asp:Button ID="btnSave" runat="server" Text="Login" onclick="btnSave_Click"  ValidationGroup="A" />
					 <asp:Button ID="btnHome" runat="server" Text="Home" onclick="btnHome_Click" />
                    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                </div>
				<div class="clearfix"></div>
			</div>
		</form>
	</div>
	<!-- //form ends here -->
	<!--copyright-->
	<div class="copy-wthree">
		<p>© 2018 Clear Login Form. All Rights Reserved | Design by
			<a href="http://w3layouts.com/" target="_blank"></a>
		</p>
	</div>
	<!--//copyright-->
</body>

</html>
