<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication3.Home" %>

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
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Email" ToolTip="Enter Email id"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <div>
                <asp:Button ID="Button3" runat="server" Text="Button" />/div>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <div>&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="https://www.google.com">LinkButton</asp:LinkButton></div>
            <div>&nbsp;
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                    <asp:ListItem Selected="True">male</asp:ListItem>
                    <asp:ListItem>female</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click1" />
            <div>&nbsp;<asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" /></div>
            <div>&nbsp;</div>
            </form>
</body>
</html>
