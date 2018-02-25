<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_Simple_Calculator.Default" %>

<!DOCTYPE html>
<script runat="server">

    protected void addButton_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <span class="auto-style1">Number 1</span>:&nbsp;&nbsp;
        <asp:TextBox ID="numberTextBox1" runat="server"></asp:TextBox>
        <br />
        <span class="auto-style1">Number 2:</span>&nbsp;&nbsp;
        <asp:TextBox ID="numberTextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="addButton" runat="server" Text="+" Width="50px" OnClick="plusButton_Click" />
        <asp:Button ID="subtractButton" runat="server" Text="-" Width="50px" OnClick="subtractButton_Click" />
        <asp:Button ID="multiplyButton" runat="server" Text="*" Width="50px" OnClick="multiplyButton_Click" />
        <asp:Button ID="divideButton" runat="server" Text="/" Width="50px" OnClick="divideButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" BackColor="#99FFCC" ForeColor="#3333CC" style="font-family: Arial, Helvetica, sans-serif"></asp:Label>
    
    </div>
    </form>
</body>
</html>
