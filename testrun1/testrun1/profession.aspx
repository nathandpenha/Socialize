
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profession.aspx.cs" Inherits="testrun1.profession" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 269px">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="search" />
        <br />
                <asp:GridView ID="GridView1" runat="server" onselectedindexchanged="GridView1_SelectedIndexChanged1" 
                   >
                    <Columns>
                        <asp:TemplateField></asp:TemplateField>
                    </Columns>
                   
                </asp:GridView>
                 
    
    </div>
    
    
    </form>
    <p>
        Tution Services Available</p>
    <p>
        Cattering Services</p>
</body>
</html>
