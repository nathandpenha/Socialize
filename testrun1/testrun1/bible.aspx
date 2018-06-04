<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="bible.aspx.cs" Inherits="testrun1.bible" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    Book<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" ViewStateMode="Enabled">
       
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
&nbsp; Chapter<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true"
        onselectedindexchanged="DropDownList2_SelectedIndexChanged">
    </asp:DropDownList>
&nbsp; Verse&nbsp;
    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" 
        onselectedindexchanged="DropDownList3_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <br />
    <br />
    Full Chapter<br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
