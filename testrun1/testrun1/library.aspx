<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="library.aspx.cs" Inherits="testrun1.library" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
        Text="Search" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Manage Library" />
&nbsp;
    <asp:GridView ID="GridView1" runat="server" 
        onselectedindexchanged="GridView1_SelectedIndexChanged1" 
        AutoGenerateColumns="False" >
        <Columns>
        <asp:BoundField DataField="bookid" HeaderText="Book Name" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
        
        
        <asp:BoundField DataField="bookname" HeaderText="Book Name" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
        <asp:BoundField DataField="description" HeaderText="Description" 
                ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
        <asp:BoundField DataField="available" HeaderText="Available" ItemStyle-Width="150" >
        
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
        
            <asp:ButtonField Text="Select" CommandName="Select" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:ButtonField>
    </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
</asp:Content>
