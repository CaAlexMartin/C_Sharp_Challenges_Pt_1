<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConditionalRadioButtonChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Please select your note taking preference:<br />
        <br />
        <asp:RadioButton ID="pencilRadioButton" runat="server" GroupName="noteTaker" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Pencil" />
        <br />
        <asp:RadioButton ID="penRadioButton" runat="server" GroupName="noteTaker" Text="Pen" />
        <br />
        <asp:RadioButton ID="phoneRadioButton" runat="server" GroupName="noteTaker" Text="Phone" />
        <br />
        <asp:RadioButton ID="tabletRadioButton" runat="server" GroupName="noteTaker" OnCheckedChanged="RadioButton4_CheckedChanged" Text="Tablet" />
        <br />
        <br />
        <asp:Image ID="notesImage" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
