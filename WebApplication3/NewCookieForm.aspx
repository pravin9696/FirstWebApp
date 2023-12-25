<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewCookieForm.aspx.cs" Inherits="WebApplication3.NewCookieForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 100%;
		}
		.auto-style2 {
			width: 278px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        	<br />
			<table class="auto-style1">
				<tr>
					<td class="auto-style2">
						<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Cookie" />
&nbsp; </td>
					<td>
						<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Read Cookie" />
					</td>
				</tr>
				<tr>
					<td class="auto-style2">
						<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Read multiple Cookies" />
					</td>
					<td>
						<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete Cookie" />
						<br />
						<br />
						<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Delete all cookies" />
					</td>
				</tr>
				<tr>
					<td class="auto-style2">
						<asp:CheckBoxList ID="CheckBoxList1" runat="server">
							<asp:ListItem Value="100">pendrive</asp:ListItem>
							<asp:ListItem Value="10">CD</asp:ListItem>
							<asp:ListItem Value="20">DVD</asp:ListItem>
						</asp:CheckBoxList>
						<br />
						<br />
						<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Add to Kart" />
					</td>
					<td>
						<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
						<br />
						<br />
						<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="show Cart Items" />
						<br />
						<br />
						<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
						<br />
						<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Generate Bill" />
					</td>
				</tr>
			</table>
        </div>
    </form>
</body>
</html>
