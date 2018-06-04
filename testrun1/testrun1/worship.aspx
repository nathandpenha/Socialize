
<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="worship.aspx.cs" Inherits="testrun1.worship" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            text-align: center;
            color: #0000FF;
        }
    #body .intro,#body em,#body .bio,#body .source{font-style:italic}#body .intro,#body em,#body .bio,#body .source,#body .citation{font-family:"Gotham SSm A","Gotham SSm B",sans-serif;font-weight:400;font-style:italic}
        .style2
        {
            font-size: 100%;
            vertical-align: baseline;
            border-style: none;
            border-color: inherit;
            border-width: 0;
            margin: 0;
            padding: 0;
            background:;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
    
         <h1 class="style1">
             &nbsp;</h1>
         <h1 class="style1">
             &nbsp;</h1>
         <h1 class="style1">
             Worship</h1>
         <p class="style1">
             &nbsp;</p>
         <p class="style1">
             &nbsp;</p>
         <p class="text">
             True worship, in other words, is defined by the priority we place on
             <em class="style2" style="outline: 0;">who</em> God is in our lives and
             <em class="style2" style="outline: 0;">where</em> God is on our list of 
             priorities. True worship is a matter of the heart expressed through a lifestyle 
             of holiness. Thus, if your lifestyle does not express the beauty of holiness 
             through an extravagant or exaggerated love for God, and you do not live in 
             extreme or excessive submission to God, then I invite you to make worship a 
             non-negotiable priority in your life.</p>
         <p class="text">
             We worship God because he is God. Period. Our extravagant love and extreme 
             submission to the Holy One flows out of the reality that God loved us
             <em class="style2" style="outline: 0;">first</em>. It is highly appropriate to 
             thank God for all the things he has done for us. However, true worship is 
             shallow if it is solely an acknowledgement of God&#39;s wealth.
             <a href="https://www.biblegateway.com/passage/?search=Psalm+96%3A5-96%3A6" 
                 target="_blank" title="view Scripture passage at BibleGateway.com">Psalm 
             96:5-6</a> says, &quot;For all the gods of the nations are idols, but the LORD made 
             the heavens. Splendor and majesty are before him; strength and glory are in his 
             sanctuary.&quot; In other words, our worship must be toward the one who is worthy 
             simply because of his identity as the Omnipotent, Omniscient, and Omnipresent 
             One, and not just because God is wealthy and able to meet our needs and answer 
             our prayers. We must focus our practice of worship on the worthiness of God and 
             not his wealthiness.</p>
         <h4 class="subhead">
             The Person We Worship</h4>
         <p class="text">
             Think about this: Would you continue to worship God if, from this day forward, 
             God&#39;s miraculous signs and wonders were not so profoundly evident in your life? 
             Would God still be worthy of your worship? Or is your worship completely 
             dependent upon the abundance of God&#39;s blessings upon your life? Do you only 
             worship God for what he can do for you?</p>
         <h4 class="subhead">
             The Promise of Worship</h4>
         <p class="text">
             Because of our God&#39;s unimaginable generosity toward us, God, in all of his 
             glory, chooses to respond to us through our worship. This is the promise—that 
             when we worship God with extravagant love and extreme submission, God will come 
             and commune with us. The promise is not that we will feel great or that our 
             heavy load will be lifted, but that God will come. And when God comes in his own 
             time as a response to our worship,
             <a href="https://www.biblegateway.com/passage/?search=Psalm+96%3A13" 
                 target="_blank" title="view Scripture passage at BibleGateway.com">Psalm 
             96:13</a> declares, &quot;Let all creation rejoice before the LORD, for he comes, he 
             comes to judge the earth. He will judge the world in righteousness and the 
             peoples in his faithfulness.&quot;</p>
         <br />
         <br />
         <br />
    
    </div>
<p>
    <asp:Label ID="Label3" runat="server" Text="Worship Leader Name"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server"></asp:Label>
</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Date"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Enabled="False" Visible="False"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Select Date" />
        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" Height="220px" 
            BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" 
            Font-Size="10pt" ForeColor="Black" NextPrevFormat="FullMonth" 
            TitleFormat="Month" Width="400px" 
           >
            <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" 
                ForeColor="#333333" Height="10pt" />
            <DayStyle Width="14%" />
            <NextPrevStyle Font-Size="8pt" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
            <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" 
                Font-Size="8pt" ForeColor="#333333" Width="1%" />
            <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" 
                ForeColor="White" Height="14pt" />
            <TodayDayStyle BackColor="#CCCC99" />
        </asp:Calendar>
</p>
     <p>
         <asp:Label ID="Label5" runat="server" Text="Select Members"></asp:Label>
</p>
     <p>
        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" 
             onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
        </asp:DropDownList>
&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" 
             onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
        </asp:DropDownList>
     &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server" 
             onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
        </asp:DropDownList>
     &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList4" runat="server" 
             onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
        </asp:DropDownList>
     &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList5" runat="server" 
             onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
        </asp:DropDownList>
     &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList6" runat="server" 
             onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
        </asp:DropDownList>
     &nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList7" runat="server" 
             onselectedindexchanged="DropDownList1_SelectedIndexChanged1">
        </asp:DropDownList>
</p>
     <p>
         <asp:Label ID="Label6" runat="server" Text="Members and Instruments"></asp:Label>
</p>
     <p>
         <asp:TextBox ID="TextBox4" runat="server" Height="104px" 
             TextMode="MultiLine" Width="266px"></asp:TextBox>
</p>
     <p>
         &nbsp;</p>
     <p>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" onclick="Button1_Click1" 
            Text="Submit" />
         &nbsp;
         <asp:Label ID="Label7" runat="server" 
             Text="*Note An email willl be sent to the following users selected"></asp:Label>
</p>
     <p>
        <br />
</p>
     <asp:Calendar ID="Calendar2" runat="server" BackColor="White" 
         BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" 
         DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" 
         ForeColor="#003399" Height="16px" Width="220px">
         <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
         <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
         <OtherMonthDayStyle ForeColor="#999999" />
         <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
         <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
         <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" 
             Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
         <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
         <WeekendDayStyle BackColor="#CCCCFF" />
     </asp:Calendar>
     <br />
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">

     <Columns>
        <asp:BoundField DataField="ID" HeaderText="Id" ItemStyle-Width="150" />
        <asp:BoundField DataField="leader" HeaderText="Lead By" ItemStyle-Width="150" />
         <asp:BoundField DataField="date" HeaderText="Date" ItemStyle-Width="150" />
       
     
    </Columns>

     </asp:GridView>
     <br />
    <p>
        &nbsp;</p>
    <asp:Label ID="Label1" runat="server"></asp:Label>
    
</asp:Content>
