<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="libraryaddbook.aspx.cs" Inherits="testrun1.libraryaddbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Book Name<asp:TextBox ID="TextBox1" runat="server" 
    ontextchanged="TextBox1_TextChanged"></asp:TextBox>
<br />
Description
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
&nbsp;&nbsp;
<br />
Image<asp:FileUpload ID="FileUpload1" runat="server" />
<asp:Button ID="Submit" runat="server" onclick="Button1_Click" Text="Button" />
<br />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>
</asp:Content>
