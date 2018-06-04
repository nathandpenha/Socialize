<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="plan.aspx.cs" Inherits="testrun1.plan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
  <b>Chapter:</b> <%#DataBinder.Eval(Container.DataItem, "chapter")%><br />
  <b>From:</b> <%#DataBinder.Eval(Container.DataItem, "bookfrom")%>
  <b>:</b> <%#DataBinder.Eval(Container.DataItem, "chapterfrom")%>
  <b>:</b> <%#DataBinder.Eval(Container.DataItem, "versefrom")%>
  <b>to:</b> <%#DataBinder.Eval(Container.DataItem, "bookto")%>
      <b>:</b> <%#DataBinder.Eval(Container.DataItem, "chapterto")%>
  <b>:</b> <%#DataBinder.Eval(Container.DataItem, "verseto")%><br /><br />
    <b>Verse:</b> <%#DataBinder.Eval(Container.DataItem, "verse")%><br /><br />
      <b>Devotion:</b> <%#DataBinder.Eval(Container.DataItem, "devotion")%><br /><br /><br /><br /><br /><br />


           </ItemTemplate> 
  </asp:DataList>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
</asp:Content>
