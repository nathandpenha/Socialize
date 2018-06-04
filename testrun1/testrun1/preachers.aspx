<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="preachers.aspx.cs" Inherits="testrun1.preachers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<p>
    Name<asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
    <p>
        Topic<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;</p>
    <p>
        Date<asp:TextBox ID="TextBox3" runat="server" Enabled="False" Visible="False"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Select Date" />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
    BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" 
    Font-Size="9pt" ForeColor="Black" Height="169px" NextPrevFormat="ShortMonth" 
    onselectionchanged="Calendar1_SelectionChanged" Width="298px" Visible="False">
    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" 
        Height="8pt" />
    <DayStyle BackColor="#CCCCCC" />
    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" 
        Font-Size="12pt" ForeColor="White" Height="12pt" />
    <TodayDayStyle BackColor="#999999" ForeColor="White" />
</asp:Calendar>
        <br /><asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
            Text="Submit" />
</p>
<p>
    <asp:Calendar ID="Calendar2" runat="server" ondayrender="Calendar2_DayRender" 
        onselectionchanged="Calendar2_SelectionChanged"></asp:Calendar>
</p>
    <p>
        &nbsp;</p>
    <asp:GridView ID="GridView1" runat="server" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" CellPadding="4" 
        ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
    &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
