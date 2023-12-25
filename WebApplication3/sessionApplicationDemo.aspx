<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sessionApplicationDemo.aspx.cs" Inherits="WebApplication3.sessionApplicationDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Session Value"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
			<br />
			Application Value&nbsp;
			<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
&nbsp;<br />
			Insert Data
			<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
			<br />
			<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
			<br />
			<br />
			<br />
			Application Count :&nbsp;
			<asp:Label ID="lblApplication" runat="server" Text="lable"></asp:Label>
			<br />
			Session Count&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;
			<asp:Label ID="lblSession" runat="server" Text="Label"></asp:Label>
			<br />
			<br />
			<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
			<br />
			<br />
			<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete Session" />
        </div>
    </form>
</body>
</html>
