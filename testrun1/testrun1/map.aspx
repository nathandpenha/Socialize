<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="map.aspx.cs" Inherits="testrun1.map" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <table border="0">
<tr>
    <td>
        Your Number:
    </td>
    <td>
        <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
    </td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required"
            ControlToValidate="txtNumber" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>
        Password:
    </td>
    <td>
        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
    </td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required"
            ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>
        Recepient Number:
    </td>
    <td>
        <asp:TextBox ID="txtRecepientNumber" runat="server" Width = "300"></asp:TextBox>
    </td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required"
            ControlToValidate="txtRecepientNumber" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>
        Message:
    </td>
    <td>
        <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine"></asp:TextBox>
    </td>
    <td>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Required"
            ControlToValidate="txtMessage" ForeColor="Red"></asp:RequiredFieldValidator>
    </td>
</tr>
<tr>
    <td>
    </td>
    <td>
        <asp:Button ID="btnSend" runat="server" Text="Send" onclick="btnSend_Click1" />
    </td>
    <td>
    </td>
</tr>
</table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
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
</script><div id="dvMap" style="width: 337px; height: 279px">

    </div>
 
 
 
    </form>
</body>
</html>
