<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="jobsearch.aspx.cs" Inherits="testrun1.jobsearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <p>
        &nbsp;</p>
&nbsp;&nbsp; KeyWord<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
    Text="Search" />
          
 
          <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
              Text="Click to add a Job" Height="25px" Width="150px" />
    <p>
          <asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    AutoGenerateColumns="false" OnSelectedIndexChanged = "OnSelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="ID" HeaderText="Id" ItemStyle-Width="150" />
        <asp:BoundField DataField="jobtitle" HeaderText="Job Title" ItemStyle-Width="150" />
        
            <asp:ButtonField Text="Select" CommandName="Select" ItemStyle-Width="150" />
    </Columns>
</asp:GridView>
 <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
            >
    <EmptyDataTemplate>    </EmptyDataTemplate>
    </asp:DetailsView>
    <asp:DetailsView AutoGenerateRows="False" DataKeyNames="id" 
            HeaderText="Author Details" ID="DetailsView2" runat="server" Width="275px">
          </asp:DetailsView>
          
 
    </p>
    <br />
</asp:Content>
