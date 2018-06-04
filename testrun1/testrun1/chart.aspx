<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="chart.aspx.cs" Inherits="testrun1.chart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Chart ID="Chart1" runat="server" onload="Chart1_Load">
    <Series>
        <asp:Series Name="Series1">
        </asp:Series>
    </Series>
    <ChartAreas>
        <asp:ChartArea Name="ChartArea1">
        </asp:ChartArea>
    </ChartAreas>
</asp:Chart>
<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</asp:Content>
