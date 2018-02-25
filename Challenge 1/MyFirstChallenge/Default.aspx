<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        How old are you?&nbsp;
        <asp:TextBox ID="ageBoxTextBox" runat="server"></asp:TextBox>
&nbsp;<br />
        How much money do you have in your pocket?&nbsp;
        <asp:TextBox ID="moneyBoxTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="fortuneButton" runat="server" Height="46px" OnClick="fortuneButton_Click" Text="Click here to see your fortune." Width="566px" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
