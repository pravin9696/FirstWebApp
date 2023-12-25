<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewSession.aspx.cs" Inherits="WebApplication3.NewSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Session Count"></asp:Label>
        &nbsp;
			<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
			<br />
			<br />
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delelte session" />
			<br />
			<br />
			<br />
			<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="create session" />
			<br />
			<br />
			session count :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
			<br />
			<br />
			application count :&nbsp;&nbsp;
			<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
			<br />
			<br />
			<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
			<br />
			<br />
			<asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
			</asp:Login>
			<br />
			<br />
        </div>
    </form>
</body>
</html>
