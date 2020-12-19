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

function modelOpen() {
    
}

window.javaScriptFunction = {
    showModal: function () {
        document.addEventListener('DOMContentLoaded', function () {
            var Modalelem = document.querySelector('.modal');
            var instance = M.Modal.init(Modalelem);
            instance.open();
        });
    },

    showAlert: function (test) {
        alert(test);
    },
    //displayWelcome: function (welcomeMessage) {
    //    document.getElementById('welcome').innerText = welcomeMessage;
    //},
    //returnArrayAsyncJs: function () {
    //    DotNet.invokeMethodAsync('BlazorWebAssemblySample', 'ReturnArrayAsync')
    //        .then(data => {
    //            data.push(4);
    //            console.log(data);
    //        });
    //},
    //sayHello: function (dotnetHelper) {
    //    return dotnetHelper.invokeMethodAsync('SayHello')
    //        .then(r => console.log(r));
    //}
};