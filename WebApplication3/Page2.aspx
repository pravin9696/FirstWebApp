<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="WebApplication3.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <div>&nbsp;<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
        <div>&nbsp;<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></div>
        <div>&nbsp;
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="city" DataValueField="id" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged"></asp:CheckBoxList><asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:GTHPracticeConnectionString %>" SelectCommand="SELECT [id], [city] FROM [emp_city]"></asp:SqlDataSource>
        </div>
        <div>&nbsp;</div>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <div>&nbsp;</div>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="male" GroupName="gender" />
        <br />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender" />
        <br />
        Courses
        <br />
        <asp:RadioButton ID="RadioButton3" runat="server" Text="BCA" GroupName="course"/><br />
        <asp:RadioButton ID="RadioButton4" runat="server" Text="Engg" GroupName="course"/><br />

        <asp:RadioButton ID="RadioButton5" runat="server" Text="MCA" GroupName="course"/>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        <table border="1">
            <tr>
                <td>&nbsp;1</td>
                <td>&nbsp;2</td>
            </tr>
            <tr>
                <td>&nbsp;3</td>
                <td>&nbsp;4</td>
            </tr>
        </table>
        <br />

        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>pune</asp:ListItem>
            <asp:ListItem>mumbai</asp:ListItem>
        </asp:RadioButtonList>

    </form>
</body>
</html>
