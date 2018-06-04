<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="testrun1.search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
 <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
     
        Name
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>     
       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
      
    </div>
      <asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    AutoGenerateColumns="false" OnSelectedIndexChanged = "OnSelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-Width="150" />
            
       
        <asp:ButtonField Text="Select" CommandName="Select" ItemStyle-Width="150" />
    </Columns>
</asp:GridView>
     
</asp:Content>
