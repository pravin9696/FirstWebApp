<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" BackColor="#00FF99" ForeColor="#FF3399" OnClick="Button1_Click" />
        	<br />
			<br />
			<asp:Label ID="Label2" runat="server" EnableViewState="False" Text="Label"></asp:Label>
			<br />
			<asp:HiddenField ID="HiddenField1" runat="server" />
			<br />
			<br />
			<asp:Button ID="Button2" runat="server" Text="Button" />
&nbsp;&nbsp;&nbsp;
			<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Create ViewState" />
			<br />
			first name
			<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; last name&nbsp;
			<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
			<br />
			<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="use Querystring" />
			<br />
			<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="login" />
        </div>
    </form>
</body>
</html>
