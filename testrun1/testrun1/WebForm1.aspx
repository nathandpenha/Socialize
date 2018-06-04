<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="testrun1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .style1
    {
        color: #000000;
        font-size: xx-large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
    
    <br /><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style1">Login</span><br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        style="margin-bottom: 9px" Text="Login" />
        <br />
        <br />
        <br />
        <br />
    <p style="box-sizing: border-box; margin: 0px; padding: 0px 0px 1em; border: 0px; outline: 0px; background: rgb(255, 255, 255); font-size: 14px; vertical-align: baseline; color: rgb(102, 102, 102); font-family: Merriweather, Georgia, &quot;Times New Roman&quot;, serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 500; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        We are an English speaking Church in Mumbai.</p>
    <p style="box-sizing: border-box; margin: 0px; padding: 0px 0px 1em; border: 0px; outline: 0px; background: rgb(255, 255, 255); font-size: 14px; vertical-align: baseline; color: rgb(102, 102, 102); font-family: Merriweather, Georgia, &quot;Times New Roman&quot;, serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 500; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        We would describe ourselves as Contemporary, Bible believing, Spirit Filled 
        (Charismatic) and a Born again church in Mumbai city.&nbsp; We meet every<span 
            class="Apple-converted-space">&nbsp;</span><u 
            style="box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; outline: 0px; background: transparent; font-size: 14px; vertical-align: baseline;">Sunday</u><span 
            class="Apple-converted-space">&nbsp;</span>in Bandra-<span 
            class="Apple-converted-space">&nbsp;</span><u 
            style="box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; outline: 0px; background: transparent; font-size: 14px; vertical-align: baseline;">visit 
        us</u>.</p>
    <p style="box-sizing: border-box; margin: 0px; padding: 0px 0px 1em; border: 0px; outline: 0px; background: rgb(255, 255, 255); font-size: 14px; vertical-align: baseline; color: rgb(102, 102, 102); font-family: Merriweather, Georgia, &quot;Times New Roman&quot;, serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 500; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        At Living Word you will find people of different ages, nationalities, 
        backgrounds with different stories. We are one big family who are united by&nbsp;a 
        common love for Jesus, one another and our city!</p>
    <p style="box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; outline: 0px; background: rgb(255, 255, 255); font-size: 14px; vertical-align: baseline; color: rgb(102, 102, 102); font-family: Merriweather, Georgia, &quot;Times New Roman&quot;, serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 500; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;">
        &nbsp;&nbsp;&nbsp;&nbsp;
        We don’t believe in a formal or ritualistic practice of religion, but enjoy a 
        real relationship with God and aim to outwork this in a relevant way in everyday 
        life</p>
    <br />
    <br />
    <br />
    <div class="et_pb_text et_pb_module et_pb_bg_layout_light et_pb_text_align_left  et_pb_text_0" 
        style="box-sizing: border-box; margin: 0px 0px 29.6719px; padding: 0px; border: 0px; outline: 0px; background: rgb(255, 255, 255); font-size: 14px; vertical-align: baseline; word-wrap: break-word; text-align: left; color: rgb(102, 102, 102); font-family: Merriweather, Georgia, &quot;Times New Roman&quot;, serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 500; letter-spacing: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;">
        <h1 style="box-sizing: border-box; margin: 0px; padding: 0px 0px 10px; border: 0px; outline: 0px; background: transparent; font-size: 26px; vertical-align: baseline; color: rgb(51, 51, 51); font-weight: 500; line-height: 1em; font-family: Montserrat, Helvetica, Arial, Lucida, sans-serif;">
            <strong style="box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; outline: 0px; background: transparent; font-size: 26px; vertical-align: baseline; font-weight: bold;">
            LOCATION</strong></h1>
        <p style="box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; outline: 0px; background: transparent; font-size: 14px; vertical-align: baseline; text-align: left;">
            ADAPT Hall,&nbsp;Bandra Reclamation, Near Hotel Rang Sharda,&nbsp;Bandra west, Mumbai.</p>
    </div>
    <div class="et_pb_text et_pb_module et_pb_bg_layout_light et_pb_text_align_left  et_pb_text_1" 
        style="box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; outline: 0px; background: rgb(255, 255, 255); font-size: 14px; vertical-align: baseline; word-wrap: break-word; text-align: left; color: rgb(102, 102, 102); font-family: Merriweather, Georgia, &quot;Times New Roman&quot;, serif; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 500; letter-spacing: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;">
        <h1 style="box-sizing: border-box; margin: 0px; padding: 0px 0px 10px; border: 0px; outline: 0px; background: transparent; font-size: 26px; vertical-align: baseline; color: rgb(51, 51, 51); font-weight: 500; line-height: 1em; font-family: Montserrat, Helvetica, Arial, Lucida, sans-serif; text-align: left;">
            <strong style="box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; outline: 0px; background: transparent; font-size: 26px; vertical-align: baseline; font-weight: bold;">
            DIRECTIONS</strong></h1>
        <p style="box-sizing: border-box; margin: 0px; padding: 0px 0px 1em; border: 0px; outline: 0px; background: transparent; font-size: 14px; vertical-align: baseline; text-align: left;">
            If you are coming by local train, get off at Bandra Station. Go to the west side 
            (Exit at platform 1), get into an auto rickshaw and tell them to take you to 
            Bandra Reclamation, Hotel Rang Sharda.If you are coming by your own vehicle, 
            don’t worry you will get ample parking space.</p>
        <p style="box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; outline: 0px; background: transparent; font-size: 14px; vertical-align: baseline; text-align: left;">
            Do call Vibhav&nbsp;on 09820367330 before you come if you need directions or have any 
            queries. For more details you can mail us on&nbsp;<a 
                href="mailto:info@livingword.in" 
                style="box-sizing: border-box; margin: 0px; padding: 0px; border: 0px; outline: 0px; background: transparent; font-size: 14px; vertical-align: baseline; color: rgb(54, 187, 164); text-decoration: none;">info@livingword.in</a></p>
    </div>     <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD1-dupnjud4p9G137a9IzlTBTBPQJ3iLU&callback=initMap"></script>
<script type="text/javascript">
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (p) {
            var LatLng = new google.maps.LatLng(p.coords.latitude, p.coords.longitude);
            var mapOptions = {
                center: LatLng,
                zoom: 13,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var LatLngdes = new google.maps.LatLng(19.051593, 72.832068);
            var mapdes = {
                center: LatLngdes,
                zoom: 13,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };
            var map = new google.maps.Map(document.getElementById("dvMap"), mapOptions);

            var marker = new google.maps.Marker({
                position: LatLng,
                map: map,
                title: "<div style = 'height:60px;width:200px'><b>Your location:</b><br />Latitude: " + p.coords.latitude + "<br />Longitude: " + p.coords.longitude
            });
            var mardes = new google.maps.Marker({
                position: LatLngdes,
                map: map,
                title: "<div style = 'height:60px;width:200px'><b>Your location:</b><br />Latitude: " + p.coords.latitude + "<br />Longitude: " + p.coords.longitude
            });

            google.maps.event.addListener(marker, "click", function (e) {
                var infoWindow = new google.maps.InfoWindow();
                infoWindow.setContent(marker.title);
                infoWindow.open(map, marker);
            });
        });
    } else {
        alert('Geo Location feature is not supported in this browser.');
    }
    
</script><div id="dvMap" style="width: 1079px; height: 305px">

    </div>
 
 
 
 
        <br />
        <br />
        <br />
    <br />
      <div id="carousel-example-generic" class="carousel slide carousel-fade" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target='#carousel-example-generic' data-slide-to='0' class='active'>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/img/12.jpg"
                    Width="100px" Height="50px" /></li>
            <li data-target='#carousel-example-generic' data-slide-to='1'>
                <asp:Image ID="Image2" runat="server" ImageUrl="~/images/camp.jpg" Width="100px" Height="50px" /></li>
            </li>
            <li data-target='#carousel-example-generic' data-slide-to='2'>
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/advancing.jpg" Width="100px" Height="50px" /></li></li>
        </ol>
        <!-- Wrapper for slides -->
        <div class="carousel-inner">
            <div class="item active one">
                <!-- <img src="#" alt="" /> -->
                <div class="main-text hidden-xs">
                    <div class="col-md-12 text-center">
                        <h1>
                            Let your <b class="yellow">smile</b> change the <b class="yellow">world</b><br />
                            <span class="span">Not the world change your smile.</span></h1>
                        <div class="">
                            <asp:HyperLink NavigateUrl="webform1.aspx" ID="HyperLink1" runat="server" CssClass="btn btn-clear btn-sm btn-min-block">Login</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-clear btn-sm btn-min-block                           ">Registration</asp:HyperLink>
                           </div>
                    </div>
                </div>
            </div>
            <div class="item two">
                <div class="main-text hidden-xs">
                    <div class="col-md-12 text-center">
                        <h1>
                            A <b class="yellow">Goal</b> without <b class="yellow">a plan</b><br />
                            <span class="span">is just a wish</span></h1>
                        <div class="">
                            <asp:HyperLink ID="HyperLink3" runat="server" CssClass="btn btn-clear btn-sm btn-min-block">learn More</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink4" runat="server" CssClass="btn btn-clear btn-sm btn-min-block                           ">Download</asp:HyperLink>
                            </div>
                    </div>
                </div>
            </div>
            <div class="item three">
                <div class="main-text hidden-xs">
                    <div class="col-md-12 text-center">
                        <h1>
                            You cannot<b class="yellow"> believe</b> in <b class="yellow">God</b><br />
                            <span class="span">until you believe in yourself.</span></h1>
                        <div class="">
                            <asp:HyperLink ID="HyperLink5" runat="server" CssClass="btn btn-clear btn-sm btn-min-block">Android</asp:HyperLink>
                            <asp:HyperLink ID="HyperLink6" runat="server" CssClass="btn btn-clear btn-sm btn-min-block                           ">Apple</asp:HyperLink></div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Controls -->
        <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span></a><a class="right carousel-control"
                href="#carousel-example-generic" role="button" data-slide="next"><span class="glyphicon glyphicon-chevron-right">
                </span></a>
    </div>
    <!-- Carousel -->
    <!-- Service Section -->
    <section id="services" class="padding50">
        <div class="container">
            <div class="row">
        \<div class="clearfix">
        </div>
    </section>
    <!-- ./ End Service Section -->
    <!-- Page Content -->
    <div class="padding100" id="blog">
        <div class="container">
            <!-- Page Heading -->
            <div class="row">
                <div class="col-lg-12">
                    <h2 class="background double animated wow fadeInUp" data-wow-delay="0.2s">
                        <span><strong>B</strong>log</span></h2>                    
                </div>
            </div>
            <!-- /.row -->
            <!-- Project One -->
            <div class="row">
                <div class="col-md-7">
                    <a href="#">
                        <img class="img-responsive animated wow fadeInLeft" data-wow-delay="0.2s" src="images/parying.jpg"
                            alt="">                       
                    </a>
                </div>
                <div class="col-md-5 animated wow fadeInRight" data-wow-delay="0.4s">
                    <h3>
                    <a class="btn btn-success" href="#">View Project <span class="glyphicon glyphicon-chevron-right">
                    </span></a>
                </div>
            </div>
            <!-- /.row -->
            <!-- Pagination -->
            <!--<div class="row text-center">
            <div class="col-lg-12">
                <ul class="pagination">
                    <li><a href="#">&laquo;</a> </li>
                    <li class="active"><a href="#">1</a> </li>
                    <li><a href="#">2</a> </li>
                    <li><a href="#">3</a> </li>
                    <li><a href="#">4</a> </li>
                    <li><a href="#">5</a> </li>
                    <li><a href="#">&raquo;</a> </li>
                </ul>
            </div>
        </div>      -->
        </div>
    </div>
    <!-- /.container -->
    <!-- Products Section -->
    <section id="products" class="products-list padding100">
        <div class="container">
            <div class="row">
                <div class="section-title col-sm-8 col-sm-offset-2 col-md-8 col-md-offset-2 col-lg-8 col-lg-offset-2">
                    <h2 class="animated wow fadeInLeft" data-wow-delay="0.4s">
                        Our Innovative Latest <span class="common">' Products ' </span>All are free to download.
                        Get more ...</h2>                   
                </div>
            </div>
            <!-- ./end row -->
            <div class="row">
                <div class="col-sm-12 animated wow fadeInUp" data-wow-delay="0.6s">
                    <div id="screens" class="owl-carousel">
                        <div>
                            <img src="img/products/1.jpg" class="img-responsive" alt="screens">
                        </div>
                        <div>
                            <img src="img/products/2.jpg" class="img-responsive" alt="screens">
                        </div>
                        <div>
                            <img src="img/products/3.jpg" class="img-responsive" alt="screens">
                        </div>
                        <div>
                            <img src="img/products/1.jpg" class="img-responsive" alt="screens">
                        </div>
                        <div>
                            <img src="img/products/2.jpg" class="img-responsive" alt="screens">
                        </div>
                        <div>
                            <img src="img/products/3.jpg" class="img-responsive" alt="screens">
                        </div>
                        <div>
                            <img src="img/products/1.jpg" class="img-responsive" alt="screens">
                        </div>
                    </div>
                    <!-- ./ end slider -->
                </div>
            </div>
            <!-- ./ end row -->
        </div>
    </section>
    <!-- Download Section -->
    <section id="download" class="padding100">
        <div class="container">
            <div class="row">
                <div class="section-title col-sm-8 col-sm-offset-2 col-md-8 col-md-offset-2 col-lg-8 col-lg-offset-2">
                    <h2 class="animated wow fadeInLeft" data-wow-delay="0.4s">
                        Waiting for what <span class="common">' DOWNLOAD NOW'</span></h2>
                    
                </div>
            </div>
            <!-- ./end row -->
            <div class="row">
                <div class="col-sm-8 col-sm-offset-2 text-center">
       `             <div class="download-wrap animated wow fadeInLeft" data-wow-delay="0.4s">
                        <a href="#" class="btn btn-download wow fadeInUp"><i class="fa fa-android"></i><strong>
                            Download App</strong> <span>From Play Store</span> </a><a href="#" class="btn btn-download app wow fadeInUp"
                                data-wow-delay="0.2s"><i class="fa fa-apple"></i><strong>Download App</strong> <span>
                                    From App Store</span> </a><a href="#" class="btn btn-download window wow fadeInUp"
                                        data-wow-delay="0.2s"><i class="fa fa-windows"></i><strong>Download App</strong>
                                        <span>From windows store</span> </a>
                    </div>
                </div>
            </div>
            <!-- ./end row -->
        </div>
    </section>
  
   </asp:Content>

