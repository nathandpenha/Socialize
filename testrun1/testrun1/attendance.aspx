<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="attendance.aspx.cs" Inherits="testrun1.attendance" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        Month&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Jan</asp:ListItem>
            <asp:ListItem>Feb</asp:ListItem>
            <asp:ListItem>March</asp:ListItem>
            <asp:ListItem>April</asp:ListItem>
            <asp:ListItem>May</asp:ListItem>
            <asp:ListItem>Jun</asp:ListItem>
            <asp:ListItem>July</asp:ListItem>
            <asp:ListItem>Aug</asp:ListItem>
            <asp:ListItem>Sep</asp:ListItem>
            <asp:ListItem>Oct</asp:ListItem>
            <asp:ListItem>Nov</asp:ListItem>
            <asp:ListItem>Dec</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp; Week&nbsp;&nbsp;<asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;Meeting<asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
        </asp:DropDownList>
&nbsp; Adults<asp:TextBox ID="TextBox1" runat="server" 
            ontextchanged="TextBox1_TextChanged" Width="60px"></asp:TextBox>
&nbsp;Children<asp:TextBox ID="TextBox2" runat="server" 
            ontextchanged="TextBox2_TextChanged" Width="72px"></asp:TextBox>
&nbsp;Guest<asp:TextBox ID="TextBox3" runat="server" 
            ontextchanged="TextBox3_TextChanged" Width="72px"></asp:TextBox>
&nbsp;Total<asp:TextBox ID="TextBox4" runat="server" Width="73px" 
            ontextchanged="TextBox4_TextChanged"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Insert" onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Chart ID="Chart1" runat="server" onload="Chart1_Load">
            <series>
                <asp:Series Name="Series1">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Export to excel" />
        <br />
        <br />
        <br />
        <br />
    
    </div>
   </body>
</html>
