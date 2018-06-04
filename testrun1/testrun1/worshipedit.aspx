<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="worshipedit.aspx.cs" Inherits="testrun1.worshipedit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:Calendar ID="Calendar2" runat="server"  
        onselectionchanged="Calendar2_SelectionChanged"></asp:Calendar>
</p>
     <asp:GridView ID="GridView1" runat="server">
     </asp:GridView>
    <p>
        &nbsp;</p>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </asp:Content>
