
<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="lg.aspx.cs" Inherits="testrun1.lg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    
    
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
   <ContentTemplate>
        <div class="et_pb_text et_pb_module et_pb_bg_layout_light et_pb_text_align_left  et_pb_text_0">
            <div class="page" title="Page 2">
                <div class="layoutArea">
                    <div class="column">
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                        <p>
                            More than community,&nbsp;a Life Group is the ever caring extended family. Living 
                            Word Church community meet regularly as Life Groups across Mumbai for times of 
                            prayers, worship, or simply sharing, caring and encouraging each another, just 
                            like God who gave His love unconditionally. For more information get in touch 
                            with Lynn Fernandes on a Sunday or Call us on the number above</p>
                    </div>
                </div>
            </div>
        </div>
        <!-- .et_pb_text -->
        <hr 
    class="et_pb_module et_pb_space et_pb_divider_0 et-hide-mobile" />
        <div class="et_pb_text et_pb_module et_pb_bg_layout_light et_pb_text_align_left  et_pb_text_1">
            <div class="page" title="Page 2">
                <div class="layoutArea">
                    <div class="column">
                        <h3>
                            <strong>Living Word Life Groups</strong></h3>
                        <ul>
                            <li>Byculla</li>
                            <li>Chembur</li>
                            <li>Dadar</li>
                            <li>Mahim</li>
                            <li>Bandra West</li>
                            <li>Andheri West</li>
                            <li>Andheri East</li>
                            <li>Goregaon West</li>
                            <li>Khar West</li>
                            <li>Kalina</li>
                            <li>Mira Road</li>
                            <li>Borivili</li>
                            <li>Virar</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <p>



            &nbsp;</p>
        <p>
            Area
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#E7E7FF" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3" 
            GridLines="Horizontal" AutoGenerateColumns="False">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
          <Columns>
         <asp:BoundField DataField="area" HeaderText="Area" ItemStyle-Width="150" />
        <asp:BoundField DataField="contact" HeaderText="Contact" ItemStyle-Width="150" />

        <asp:BoundField DataField="timings" HeaderText="Timings" ItemStyle-Width="150" />
        <asp:BoundField DataField="address" HeaderText="Address" ItemStyle-Width="150" />
        </Columns>
    </asp:GridView>
        <asp:Image ID="Image1" runat="server" 
            ImageUrl="~/images/11066795_862737413798226_4616237802414442855_n.jpg" />
        <br />
   </ContentTemplate>
    </asp:UpdatePanel>
   
   
    <asp:Label ID="Label1" runat="server" Text="Area"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Contact"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Timing"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox4" runat="server" Height="63px" TextMode="MultiLine" 
        Width="410px"></asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Submit" />
    <br />
    <br />
    <br />
       <div id="dvImage" runat="server"  style="border-style: none; border-color: inherit; border-width: 3px; float:right; width:262px;  height:482px; margin:20px 10px 20px 10px;background-image:url('images/praying.jpg')">
                 </div>
           
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript">
       var images = ["Screen-Shot-2015-12-08-at-5.04.53-PM.png"];
    $(function () {
        var i = 0;
        $("#dvImage").css("background-image", "url(images/" + images[i] + ")");
        setInterval(function () {
            i++;
            if (i == images.length) {
                i = 0;
            }
            $("#dvImage").fadeOut("slow", function () {
                $(this).css("background-image", "url(images/" + images[i] + ")");
                $(this).fadeIn(1000);
            });
        }, 10000);
    });
</script>




 </asp:Content>