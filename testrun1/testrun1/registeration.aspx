
<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="registeration.aspx.cs" Inherits="testrun1.registeration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        Name&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="Please enter your name "></asp:RequiredFieldValidator>
        <br />
        <br />
        Contact no&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="Enter your number"></asp:RequiredFieldValidator>
        <br />
        <br />
        Age&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Email
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        Profession
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        Dob&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        Address&nbsp;
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        Native Place&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        Gender&nbsp;
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" 
            Text="Male" />
&nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Text="Female" 
            ValidationGroup="gender" />
        <br />
        <br />
        Marritial Status&nbsp;
        <asp:RadioButton ID="RadioButton3" runat="server" GroupName="marriage" 
            Text="Single" />
&nbsp;
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="marriage" 
            Text="Married" />
        <br />
        <br />
        Upload a Profile Photo<asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        &nbsp;<br />
&nbsp;Are you a Citizen of India?&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton5" runat="server" Text="Yes" />
&nbsp;<asp:RadioButton ID="RadioButton6" runat="server" 
            Text="No (I am not an Indian Citizen)" />
        <br />
        <br />
        <br />
        Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox9" runat="server" ontextchanged="TextBox9_TextChanged"></asp:TextBox>
        <br />
        assword&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ErrorMessage="Password Must Match" ControlToCompare="TextBox10" 
            ControlToValidate="TextBox9"></asp:CompareValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
        <br />
    
    </div>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    </asp:Content>