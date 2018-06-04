<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="testrun1.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 762px;
            height: 306px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div><div>
    <p style="margin-left: 40px">
        <img alt="" class="style1" 
            src="images/10259781_980741885331111_4742022010604529624_n.jpg" /><br />
    </p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
            &nbsp;</p>
        <p style="margin-left: 40px">
        <asp:Image ID="Image1" runat="server" Height="155px" Width="158px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <p style="margin-left: 40px">
        &nbsp;</p>
    <p style="margin-left: 40px">
        Name :&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
        Text="Edit Details" Height="23px" Width="79px" />
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Conatct :
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Age :
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email :
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Profession :
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Date Of Birth :
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Address :
        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Gender :
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Maritial Status :<asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
        </p>
    <p>
        &nbsp;</p>
        <p>
            Jobs Uploaded</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                onselectedindexchanged="GridView1_SelectedIndexChanged">
            
             <Columns>
        <asp:BoundField DataField="ID" HeaderText="Id" ItemStyle-Width="150" />
        <asp:BoundField DataField="jobtitle" HeaderText="Job Title" ItemStyle-Width="150" />
        
            <asp:ButtonField Text="Select" CommandName="Select" ItemStyle-Width="150" />
    </Columns>
            
            </asp:GridView>
            Items Posted For Sale<asp:GridView ID="GridView2" runat="server" 
                AutoGenerateColumns="False" 
                onselectedindexchanged="GridView2_SelectedIndexChanged">

             <Columns>
        <asp:BoundField DataField="ID" HeaderText="Id" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                 </asp:BoundField>
        <asp:BoundField DataField="Name" HeaderText="Item Name" ItemStyle-Width="150" >
        
<ItemStyle Width="150px"></ItemStyle>
                 </asp:BoundField>
        
            <asp:ButtonField Text="Select" CommandName="Select" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
                 </asp:ButtonField>
    </Columns>
            </asp:GridView>
    </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <p>
    
    </div>
    </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
</asp:Content>
