<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_EpicSpiesChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style1 {
			font-size: medium;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Image ID="EpicSpiesLogoImage" runat="server" Height="190px" ImageUrl="~/Images/epic-spies-logo.jpg" />
        </div>
    	<p class="auto-style1">
			<strong>Spy New Assignment Form</strong></p>
		<p class="auto-style1">
			Spy Code Name:
			<asp:TextBox ID="spyCodeNameTextBox" runat="server"></asp:TextBox>
		</p>
		<p class="auto-style1">
			New Assignment Name:
			<asp:TextBox ID="newAssignmentNameTextBox" runat="server"></asp:TextBox>
		</p>
		<p class="auto-style1">
			End of Previous Assignment<asp:Calendar ID="endDtPreviousCalendar" runat="server" VisibleDate="2018-08-06" SelectedDate="08/06/2018 16:29:32"></asp:Calendar>
		</p>
		<p>
			Start Date of New Assignment:
		</p>
			<asp:Calendar ID="startDtNewCalendar" runat="server"></asp:Calendar>
		<p>
			Projected End Date of New Assignment:
		<asp:Calendar ID="endDtNewCalendar" runat="server"></asp:Calendar>
		</p>
		<asp:Button ID="AssignSpyButton" runat="server" Text="Assign Spy" OnClick="AssignSpyButton_Click" />
		<br />
		<br />
		<asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
