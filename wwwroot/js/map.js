window.initializeMap = (markers) => {
    var latSum = 0;
    var lngSum = 0;

    markers.forEach(marker => {
        latSum = marker.lat;
        lngSum = marker.lng;
    });

    var map = L.map('map').setView([latSum, lngSum], 13);

    L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
        attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);

    markers.forEach(marker => {
        var popupContent = '<b>' + marker.name + '</b>';

        L.marker([marker.lat, marker.lng]).addTo(map).bindPopup(popupContent);
    });
};


