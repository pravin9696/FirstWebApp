<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student Registration.aspx.cs" Inherits="WebApplication3.student_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           user Name :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />            
        </div>
        <br />
        <div>
   Password :
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />            
</div>
        <div>&nbsp;</div>
        <br />
        <div>
            User Login Deleted  : <asp:DropDownList ID="DropDownlist1" runat="server">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem Selected="True">No</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
        <div>&nbsp;</div>
        <div>&nbsp;</div>
        <div>&nbsp;</div>
    </form>
</body>
</html>
