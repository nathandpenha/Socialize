<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="prayer_request.aspx.cs" Inherits="testrun1.prayer_request" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Prayer Topic<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<br />
<br />
Description<br />
<asp:TextBox ID="TextBox2" runat="server" Height="211px" TextMode="MultiLine" 
    Width="448px"></asp:TextBox>
<br />
<br />
<asp:CheckBox ID="CheckBox1" runat="server" Text="Annonymous" />
<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
<br />
<br />
</asp:Content>
