<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="job.aspx.cs" Inherits="testrun1.job" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Job ID: &nbsp;&nbsp; &nbsp;
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <p>
        Job:&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
&nbsp;Company Name:&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </p>
    <br />
    Type:&nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <br />
    Description:&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <br />
    Industry
    :&nbsp;
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    <br />
    Location:&nbsp;
    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    <br />
    Timings:&nbsp;&nbsp;
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    <br />
&nbsp;Salary
    :&nbsp;
    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label10" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
    Text="Show Interest" />
</asp:Content>
