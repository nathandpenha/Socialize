<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="live.aspx.cs" Inherits="testrun1.live" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
       <br />
       <br />
       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
       <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
       <br />
       <br />
       <br />
    
       <iframe id="frame1" width="560" runat="server"
                height="315" 
                frameborder="0" 
                allowfullscreen="true"></iframe>
 
    
   
    
    
       </asp:Content>
