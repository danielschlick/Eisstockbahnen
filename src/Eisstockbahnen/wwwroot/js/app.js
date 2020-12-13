function initialize() {
    var latlng = new google.maps.LatLng(48.369060, 13.820479);
    new google.maps.Marker({
        position: latlng,
        map,
        title: "Eisstockbahnen Ratzenböck!",
    });

    var options = {
        zoom: 14,
        center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };


    var map = new google.maps.Map(document.getElementById("map"), options);
}   