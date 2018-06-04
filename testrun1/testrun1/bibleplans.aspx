<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="bibleplans.aspx.cs" Inherits="testrun1.bibleplans" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    AutoGenerateColumns="false" OnSelectedIndexChanged = "OnSelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="ID" HeaderText="Id" ItemStyle-Width="150" />
        <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150" />
        <asp:BoundField DataField="Description" HeaderText="Description" ItemStyle-Width="150" />
        <asp:BoundField DataField="Chapters" HeaderText="No. Chapters" ItemStyle-Width="150" />
        <asp:BoundField DataField="Creator" HeaderText="Publisher" ItemStyle-Width="150" />
        <asp:BoundField DataField="creationdate" HeaderText="Published date" ItemStyle-Width="150" />
        
            <asp:ButtonField Text="Select" CommandName="Select" ItemStyle-Width="150" />
    </Columns>
</asp:GridView>
    <br />
    <br />
</asp:Content>
