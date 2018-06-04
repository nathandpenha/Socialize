<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="volunteer.aspx.cs" Inherits="testrun1.volunteer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style1">
    
        <h1>
            <strong>Join a Team!</strong></h1>
        <p style="text-align: left">
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: left">
            Contact Number<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: left">
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Serving team" />
&nbsp;
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Worship Team" />
&nbsp;
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Decor Team" />
&nbsp;
            <asp:CheckBox ID="CheckBox4" runat="server" Text="Welcome team" />
&nbsp;
            <asp:CheckBox ID="CheckBox5" runat="server" Text="Hooked On Jesus" />
        </p>
        <p style="text-align: left">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Volunteer" />
        </p>
    
    </div>
  </asp:Content>