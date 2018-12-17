// Write your JavaScript code.
var GOOGLE_MAP_KEY = "AIzaSyBlLvJ9NzDhCd9z-urxEAe83JGCqv1G0TI";
function googleInput() {
    var map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: -33.8688, lng: 151.2195 },
        zoom: 13,
        mapTypeId: 'roadmap'
    });

    var input = document.getElementById('address_map');
    var searchBox = new google.maps.places.SearchBox(input);
    map.controls[google.maps.ControlPosition.TOP_LEFT].push(input);
    searchBox.addListener('places_changed', function () {
        var places = searchBox.getPlaces();
        if (places.length > 0) {
            $("#lat").val(places[0].geometry.location.lat());
            $("#lng").val(places[0].geometry.location.lng());
        }
    });
}
