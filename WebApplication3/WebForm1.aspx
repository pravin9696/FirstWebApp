<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        	<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
				<Columns>
					<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
					<asp:BoundField DataField="roll" HeaderText="roll" SortExpression="roll" />
					<asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
					<asp:BoundField DataField="total_marks" HeaderText="total_marks" SortExpression="total_marks" />
					<asp:BoundField DataField="per" HeaderText="per" SortExpression="per" />
				</Columns>
			</asp:GridView>
			<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:GTHPracticeConnectionString2 %>" DeleteCommand="DELETE FROM [tblStudentTrigger] WHERE [roll] = @original_roll AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([total_marks] = @original_total_marks) OR ([total_marks] IS NULL AND @original_total_marks IS NULL)) AND (([per] = @original_per) OR ([per] IS NULL AND @original_per IS NULL))" InsertCommand="INSERT INTO [tblStudentTrigger] ([roll], [name], [total_marks], [per]) VALUES (@roll, @name, @total_marks, @per)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [tblStudentTrigger]" UpdateCommand="UPDATE [tblStudentTrigger] SET [name] = @name, [total_marks] = @total_marks, [per] = @per WHERE [roll] = @original_roll AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([total_marks] = @original_total_marks) OR ([total_marks] IS NULL AND @original_total_marks IS NULL)) AND (([per] = @original_per) OR ([per] IS NULL AND @original_per IS NULL))">
				<DeleteParameters>
					<asp:Parameter Name="original_roll" Type="Int32" />
					<asp:Parameter Name="original_name" Type="String" />
					<asp:Parameter Name="original_total_marks" Type="Int32" />
					<asp:Parameter Name="original_per" Type="Decimal" />
				</DeleteParameters>
				<InsertParameters>
					<asp:Parameter Name="roll" Type="Int32" />
					<asp:Parameter Name="name" Type="String" />
					<asp:Parameter Name="total_marks" Type="Int32" />
					<asp:Parameter Name="per" Type="Decimal" />
				</InsertParameters>
				<UpdateParameters>
					<asp:Parameter Name="name" Type="String" />
					<asp:Parameter Name="total_marks" Type="Int32" />
					<asp:Parameter Name="per" Type="Decimal" />
					<asp:Parameter Name="original_roll" Type="Int32" />
					<asp:Parameter Name="original_name" Type="String" />
					<asp:Parameter Name="original_total_marks" Type="Int32" />
					<asp:Parameter Name="original_per" Type="Decimal" />
				</UpdateParameters>
			</asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
