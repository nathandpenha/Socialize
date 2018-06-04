<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="addbibleplan.aspx.cs" Inherits="testrun1.addbibleplan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Description<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Number of chapters<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Create" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
