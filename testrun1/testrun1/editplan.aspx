<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="editplan.aspx.cs" Inherits="testrun1.editplan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Plan Name<asp:DropDownList ID="DropDownList1" runat="server" >
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Chapter<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    Verse
    <asp:DropDownList ID="DropDownList2" runat="server" 
        onselectedindexchanged="DropDownList2_SelectedIndexChanged" Width="122px" 
        AutoPostBack="true">
        <asp:ListItem>Bible</asp:ListItem>
        
<asp:ListItem>Genesis</asp:ListItem>
<asp:ListItem>Exodus</asp:ListItem>
<asp:ListItem>Leviticus</asp:ListItem>
<asp:ListItem>Numbers</asp:ListItem>
<asp:ListItem>Deuteronomy</asp:ListItem>
<asp:ListItem>Joshua</asp:ListItem>
<asp:ListItem>Judges</asp:ListItem>
<asp:ListItem>Ruth</asp:ListItem>
<asp:ListItem>1 Samuel</asp:ListItem>
<asp:ListItem>2 Samuel</asp:ListItem>
<asp:ListItem>1 Kings</asp:ListItem>
<asp:ListItem>2 Kings</asp:ListItem>
<asp:ListItem>1 Chronicles</asp:ListItem>
<asp:ListItem>2 Chronicles</asp:ListItem>
<asp:ListItem>Ezra</asp:ListItem>
<asp:ListItem>Nehemiah</asp:ListItem>
<asp:ListItem>Esther</asp:ListItem>
<asp:ListItem>Job</asp:ListItem>
<asp:ListItem>Psalms</asp:ListItem>
<asp:ListItem>Proverbs</asp:ListItem>
<asp:ListItem>Ecclesiastes</asp:ListItem>
<asp:ListItem>Song of Songs</asp:ListItem>
<asp:ListItem>Isaiah</asp:ListItem>
<asp:ListItem>Jeremiah</asp:ListItem>
<asp:ListItem>Lamentations</asp:ListItem>
<asp:ListItem>Ezekiel</asp:ListItem>
<asp:ListItem>Daniel</asp:ListItem>
<asp:ListItem>Hosea</asp:ListItem>
<asp:ListItem>Joel</asp:ListItem>
<asp:ListItem>Amos</asp:ListItem>
<asp:ListItem>Obadiah</asp:ListItem>
<asp:ListItem>Jonah</asp:ListItem>
<asp:ListItem>Micah</asp:ListItem>
<asp:ListItem>Nahum</asp:ListItem>
<asp:ListItem>Habakkuk</asp:ListItem>
<asp:ListItem>Zephaniah</asp:ListItem>
<asp:ListItem>Haggai</asp:ListItem>
<asp:ListItem>Zechariah</asp:ListItem>
<asp:ListItem>Malachi</asp:ListItem>
<asp:ListItem>Matthew</asp:ListItem>
<asp:ListItem>Mark</asp:ListItem>
<asp:ListItem>Luke</asp:ListItem>
<asp:ListItem>John</asp:ListItem>
<asp:ListItem>Acts</asp:ListItem>
<asp:ListItem>Romans</asp:ListItem>
<asp:ListItem>1 Corinthians</asp:ListItem>
<asp:ListItem>2 Corinthians</asp:ListItem>
<asp:ListItem>Galatians</asp:ListItem>
<asp:ListItem>Ephesians</asp:ListItem>
<asp:ListItem>Philippians</asp:ListItem>
<asp:ListItem>Colossians</asp:ListItem>
<asp:ListItem>1 Thessalonians</asp:ListItem>
<asp:ListItem>2 Thessalonians</asp:ListItem>
<asp:ListItem>1 Timothy</asp:ListItem>
<asp:ListItem>2 Timothy</asp:ListItem>
<asp:ListItem>Titus</asp:ListItem>
<asp:ListItem>Philemon</asp:ListItem>
<asp:ListItem>Hebrews</asp:ListItem>
<asp:ListItem>James</asp:ListItem>
<asp:ListItem>1 Peter</asp:ListItem>
<asp:ListItem>2 Peter</asp:ListItem>
<asp:ListItem>1 John</asp:ListItem>
<asp:ListItem>2 John</asp:ListItem>
<asp:ListItem>3 John</asp:ListItem>
<asp:ListItem>Jude</asp:ListItem>
<asp:ListItem>Revelation</asp:ListItem>
    </asp:DropDownList>
&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" 
        onselectedindexchanged="DropDownList3_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList4" runat="server" 
        onselectedindexchanged="DropDownList4_SelectedIndexChanged" AutoPostBack="true">
    </asp:DropDownList>
&nbsp;to&nbsp;
    <asp:DropDownList ID="DropDownList5" runat="server" 
        onselectedindexchanged="DropDownList5_SelectedIndexChanged" AutoPostBack="true">
       
        <asp:ListItem>Bible</asp:ListItem>
        
<asp:ListItem>Genesis</asp:ListItem>
<asp:ListItem>Exodus</asp:ListItem>
<asp:ListItem>Leviticus</asp:ListItem>
<asp:ListItem>Numbers</asp:ListItem>
<asp:ListItem>Deuteronomy</asp:ListItem>
<asp:ListItem>Joshua</asp:ListItem>
<asp:ListItem>Judges</asp:ListItem>
<asp:ListItem>Ruth</asp:ListItem>
<asp:ListItem>1 Samuel</asp:ListItem>
<asp:ListItem>2 Samuel</asp:ListItem>
<asp:ListItem>1 Kings</asp:ListItem>
<asp:ListItem>2 Kings</asp:ListItem>
<asp:ListItem>1 Chronicles</asp:ListItem>
<asp:ListItem>2 Chronicles</asp:ListItem>
<asp:ListItem>Ezra</asp:ListItem>
<asp:ListItem>Nehemiah</asp:ListItem>
<asp:ListItem>Esther</asp:ListItem>
<asp:ListItem>Job</asp:ListItem>
<asp:ListItem>Psalms</asp:ListItem>
<asp:ListItem>Proverbs</asp:ListItem>
<asp:ListItem>Ecclesiastes</asp:ListItem>
<asp:ListItem>Song of Songs</asp:ListItem>
<asp:ListItem>Isaiah</asp:ListItem>
<asp:ListItem>Jeremiah</asp:ListItem>
<asp:ListItem>Lamentations</asp:ListItem>
<asp:ListItem>Ezekiel</asp:ListItem>
<asp:ListItem>Daniel</asp:ListItem>
<asp:ListItem>Hosea</asp:ListItem>
<asp:ListItem>Joel</asp:ListItem>
<asp:ListItem>Amos</asp:ListItem>
<asp:ListItem>Obadiah</asp:ListItem>
<asp:ListItem>Jonah</asp:ListItem>
<asp:ListItem>Micah</asp:ListItem>
<asp:ListItem>Nahum</asp:ListItem>
<asp:ListItem>Habakkuk</asp:ListItem>
<asp:ListItem>Zephaniah</asp:ListItem>
<asp:ListItem>Haggai</asp:ListItem>
<asp:ListItem>Zechariah</asp:ListItem>
<asp:ListItem>Malachi</asp:ListItem>
<asp:ListItem>Matthew</asp:ListItem>
<asp:ListItem>Mark</asp:ListItem>
<asp:ListItem>Luke</asp:ListItem>
<asp:ListItem>John</asp:ListItem>
<asp:ListItem>Acts</asp:ListItem>
<asp:ListItem>Romans</asp:ListItem>
<asp:ListItem>1 Corinthians</asp:ListItem>
<asp:ListItem>2 Corinthians</asp:ListItem>
<asp:ListItem>Galatians</asp:ListItem>
<asp:ListItem>Ephesians</asp:ListItem>
<asp:ListItem>Philippians</asp:ListItem>
<asp:ListItem>Colossians</asp:ListItem>
<asp:ListItem>1 Thessalonians</asp:ListItem>
<asp:ListItem>2 Thessalonians</asp:ListItem>
<asp:ListItem>1 Timothy</asp:ListItem>
<asp:ListItem>2 Timothy</asp:ListItem>
<asp:ListItem>Titus</asp:ListItem>
<asp:ListItem>Philemon</asp:ListItem>
<asp:ListItem>Hebrews</asp:ListItem>
<asp:ListItem>James</asp:ListItem>
<asp:ListItem>1 Peter</asp:ListItem>
<asp:ListItem>2 Peter</asp:ListItem>
<asp:ListItem>1 John</asp:ListItem>
<asp:ListItem>2 John</asp:ListItem>
<asp:ListItem>3 John</asp:ListItem>
<asp:ListItem>Jude</asp:ListItem>
<asp:ListItem>Revelation</asp:ListItem>
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList6" runat="server" 
        onselectedindexchanged="DropDownList6_SelectedIndexChanged" AutoPostBack="true">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList7" runat="server" AutoPostBack="true">
    </asp:DropDownList>
    <br />
    Devotion<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Height="189px" TextMode="MultiLine" 
        Width="451px"></asp:TextBox>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
    </p>
</asp:Content>
