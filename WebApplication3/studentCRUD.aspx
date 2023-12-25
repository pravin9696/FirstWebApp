<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentCRUD.aspx.cs" Inherits="WebApplication3.studentCRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 100%;
		}
		.auto-style2 {
			width: 365px;
		}
		.auto-style3 {
			width: 365px;
			height: 49px;
		}
		.auto-style4 {
			height: 49px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        	<table class="auto-style1">
				<tr>
					<td class="auto-style2">Roll</td>
					<td>
						<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td class="auto-style2">Name of Student</td>
					<td>
						<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td class="auto-style2">Age</td>
					<td>
						<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td class="auto-style2">Mobile</td>
					<td>
						<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td class="auto-style3">
						<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="insert with SP" />
					</td>
					<td class="auto-style4"></td>
				</tr>
				<tr>
					<td class="auto-style2">
						<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search" />
&nbsp;
						<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search using SP" />
					</td>
					<td>&nbsp;</td>
				</tr>
			</table>

        </div>
    </form>
</body>
</html>
