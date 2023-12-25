<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieForm.aspx.cs" Inherits="WebApplication3.CookieForm" %>

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
            <asp:Button ID="Button1" runat="server" Text="setCookie" OnClick="Button1_Click" />
			<br />
			<br />
			<br />
            <asp:Button ID="Button2" runat="server" Text="ReadCookie" OnClick="Button2_Click" />
        	<br />
			<br />
			<br />
			<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete Cookies" />
			<br />
			<br />
			<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Add Multiple  cookies" />
			<br />
			<br />
			<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Read Multiple  cookies" />
			<br />
			<br />
			<asp:Button ID="Button5" runat="server" Text="Delete Multiple  cookies" />
        </div>
    </form>
</body>
</html>
