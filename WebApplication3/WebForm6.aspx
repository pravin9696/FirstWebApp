﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication3.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        	<br />
			<br />
			<br />
			<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
			<br />
			<br />
			<br />
			<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
			<br />
			<br />
			<br />
			<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
