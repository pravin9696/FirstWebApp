<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewStudReg.aspx.cs" Inherits="WebApplication3.NewStudReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			width: 100%;
		}
		.auto-style2 {
			width: 267px;
		}
		.auto-style3 {
			width: 169px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        	<table class="auto-style1">
				<tr>
					<td class="auto-style2">Roll Number</td>
					<td class="auto-style3">
						<asp:TextBox ID="txtRoll" runat="server"></asp:TextBox>
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style2">Name</td>
					<td class="auto-style3">
						<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style2">Total Marks</td>
					<td class="auto-style3">
						<asp:TextBox ID="txtTotalMarks" runat="server"></asp:TextBox>
					</td>
					<td>&nbsp;</td>
				</tr>
				<tr>
					<td class="auto-style2">
						<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
						<br />
						<br />
						<asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="insert sp" />
						<br />
						<br />
						<asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="insert sp new" />
					</td>
					<td class="auto-style3">
						<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="update with where clause" />
						<br />
						<br />
						<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="update without where" />
					</td>
					<td>
						<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="delete" />
						<br />
						<br />
						<asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Search UsingSP" />
						<br />
						<br />
						<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="select All stud SP" />
					</td>
				</tr>
				<tr>
					<td class="auto-style2">
						<asp:Button ID="Button8" runat="server" Text="Button" />
					</td>
					<td class="auto-style3">
						<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
						</asp:DropDownList>
						<br />
						<br />
						<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
					</td>
					<td>
						<asp:GridView ID="GridView1" runat="server">
						</asp:GridView>
					</td>
				</tr>
			</table>

        </div>
    </form>
</body>
</html>
