﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CollectionNonGeneric.aspx.cs" Inherits="WebApplication3.CollectionNonGeneric" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        	<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
			<br />
			<br />
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
			<br />
			<br />
			<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="add" />

        </div>
    </form>
</body>
</html>
