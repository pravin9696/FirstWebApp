<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label" EnableViewState="False"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <br />
			<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
			<br />
			Select Language:<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" EnableViewState="False">
				<asp:ListItem>English</asp:ListItem>
				<asp:ListItem Selected="True">Marathi</asp:ListItem>
				<asp:ListItem>Hindi</asp:ListItem>
			</asp:RadioButtonList>
            <br />
			select city:<asp:RadioButtonList ID="RadioButtonList2" runat="server">
				<asp:ListItem Selected="True">pune</asp:ListItem>
				<asp:ListItem>Mumbai</asp:ListItem>
			</asp:RadioButtonList>
			-------------------------------<asp:HiddenField ID="HiddenField1" runat="server" />
			<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        	<br />
			<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="send to page 3" />
        	<br />
			<br />
			cookie<br />
			<br />
			<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
			<br />
			<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
