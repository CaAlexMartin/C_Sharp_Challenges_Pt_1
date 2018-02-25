<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeDaysBetweenDates.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        How many days have elapsed?<br />
        <br />
        Choose one date<asp:Calendar ID="dateCalendar1" runat="server"></asp:Calendar>
        <br />
        <br />
        Choose a second date<asp:Calendar ID="dateCalendar2" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="goButton" runat="server" OnClick="goButton_Click" Text="Go" />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" />
        <asp:RadioButton ID="RadioButton2" runat="server" />
        <asp:RadioButton ID="RadioButton3" runat="server" />
        <asp:RadioButton ID="RadioButton4" runat="server" />
    
    </div>
    </form>
</body>
</html>
