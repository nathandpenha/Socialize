<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="camp.aspx.cs" Inherits="testrun1.camp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
        Name<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="Enter a name"></asp:RequiredFieldValidator>
    </p>
    <p>
    </p>
    <asp:Button ID="Button1" runat="server" Text="Pay" />
    <p>
    </p>
    <p>
    </p>
</asp:Content>
