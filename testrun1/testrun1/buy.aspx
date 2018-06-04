<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="buy.aspx.cs" Inherits="testrun1.buy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>

    <br />
&nbsp;&nbsp; Search&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
   
    <ContentTemplate>
    <asp:DataList ID="DataList1" runat="server" 
        onselectedindexchanged="DataList1_SelectedIndexChanged" 
        RepeatDirection="Horizontal" Height="16px">
        <SeparatorStyle BorderColor="#660066" ForeColor="#0000CC" />
        <ItemTemplate>
  
  
  <b>ID:</b> <%#DataBinder.Eval(Container.DataItem, "ID") %>
  
  <b>Item:</b> <%#DataBinder.Eval(Container.DataItem, "Name")%>
  <b>Cost:</b> <%#DataBinder.Eval(Container.DataItem, "cost")%>
  <b>Email:</b> <%#DataBinder.Eval(Container.DataItem, "email")%>

  <table border="0" cellpadding="0" cellspacing="0" width = "120px">
            <tr>
                <td align = "center">
                    <asp:Image ID="Image1" ImageUrl='<%# Eval("image") %>' runat="server" Height="100"
                        Width="100" />
                </td>
            </tr></table>
            <asp:LinkButton ID="LinkButton1" CommandArgument="a" CommandName="Select" OnClick="bt" runat="server">Buy</asp:LinkButton>
</ItemTemplate> 
  </asp:DataList>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></ContentTemplate>
      </asp:UpdatePanel>
 
</asp:Content>
