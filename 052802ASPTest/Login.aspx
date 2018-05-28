<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txt_empno" runat="server" TextMode="Number"></asp:TextBox>
    
    </div>
        <p>
            <asp:TextBox ID="txt_sal" runat="server" style="margin-bottom: 0px" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btn_login" runat="server" Text="登录" Width="68px" OnClick="btn_login_Click" />
            <asp:Button ID="btn_reset" runat="server" Text="重置" Width="74px" />
        </p>
        <asp:Label ID="lbl_result" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="XX-Large" ForeColor="#0000CC"></asp:Label>
        <%
            string s = txt_empno.Text;
             %>
        <% =s %>
    </form>
</body>
</html>
