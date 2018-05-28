<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 927px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv_emps" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="547px" Width="1335px" OnSelectedIndexChanged="gv_emps_SelectedIndexChanged1" OnRowDeleting="gv_emps_RowDeleting">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </div>
        <br /><br /><br />
        <asp:TextBox ID="txt_serch" runat="server" Width="489px"></asp:TextBox>&nbsp&nbsp
        <asp:Button ID="btn_serch" runat="server" style="margin-bottom: 0px" Text="查询" OnClick="btn_serch_Click" /><br /><br />
        <asp:Label ID="lb_test" runat="server" Text="Label" Font-Bold="True" Font-Names="Aharoni" Font-Size="XX-Large" ForeColor="#0000CC"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="编号:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_dno" runat="server" style="margin-right: 57px; margin-top: 21px; margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="姓名:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_ename" runat="server" style="margin-right: 57px; margin-top: 21px; margin-bottom: 0px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="职位:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_job" runat="server" style="margin-right: 57px; margin-top: 21px; margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="Label8" runat="server" Text="工资:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_sal" runat="server" style="margin-right: 57px; margin-top: 21px; margin-bottom: 0px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="奖金:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_comm" runat="server" style="margin-right: 57px; margin-top: 21px; margin-bottom: 0px"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="部门:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddl_dept" runat="server" Height="19px" Width="150px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btn_add" runat="server" style="margin-bottom: 0px" Text="新增" OnClick="btn_add_Click" Width="106px" />
    </form>
</body>
</html>
