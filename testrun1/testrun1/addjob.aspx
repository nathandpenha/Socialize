<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="addjob.aspx.cs" Inherits="testrun1.addjob" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        JobTitle<asp:TextBox ID="TextBox1" runat="server" 
            style="margin-bottom: 0px" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Please Enter The Job Title" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
    </p>
    <p>
&nbsp;Comapny Name
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        Type<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Full-Time</asp:ListItem>
            <asp:ListItem>Part-Time</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Description<asp:TextBox ID="TextBox2" runat="server" Height="39px" 
            TextMode="MultiLine" Width="174px"></asp:TextBox>
    </p>
    <p>
        Industry<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Location<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        Timings<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </p>
    <p>
        Salary /anum<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
</asp:Content>
