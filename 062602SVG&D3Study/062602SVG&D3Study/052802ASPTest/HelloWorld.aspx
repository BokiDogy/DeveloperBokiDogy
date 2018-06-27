<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HelloWorld.aspx.cs" Inherits="HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="Txttest" runat="server"></asp:TextBox> <asp:Button ID="btn_show" runat="server" Text="Button" Height="21px" OnClick="btn_show_Click" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Lblshow" runat="server" Text="Label" Font-Bold="True" Font-Names="MoolBoran" Font-Size="XX-Large" ForeColor="#000099"></asp:Label>
    </div>
    </form>
</body>
</html>
