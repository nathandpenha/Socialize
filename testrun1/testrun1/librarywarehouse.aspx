<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="librarywarehouse.aspx.cs" Inherits="testrun1.librarywarehouse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Book Id&nbsp;&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList4" runat="server" 
    onselectedindexchanged="DropDownList4_SelectedIndexChanged">
</asp:DropDownList>
<br />
<br />
<asp:Label ID="Label1" runat="server" Text="Book Name"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Available"></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server">
        <asp:ListItem>Yes</asp:ListItem>
        <asp:ListItem>No</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <asp:DropDownList ID="DropDownList3" runat="server">
        <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <br />
    <asp:Button ID="Bt1" runat="server" Text="Submit" Width="85px" 
    onclick="Bt1_Click" />
    <br />
<br />
<br />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>
<br />
<br />
<br />
    <br />
</asp:Content>
