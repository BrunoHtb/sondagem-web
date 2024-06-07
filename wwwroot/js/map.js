window.initializeMap = (markers) => {
    var latSum = 0;
    var lngSum = 0;

    markers.forEach(marker => {
        latSum = marker.lat;
        lngSum = marker.lng;
    });

    var map = L.map('map').setView([latSum, lngSum], 15);

    L.tileLayer('http://{s}.google.com/vt?lyrs=s,h&x={x}&y={y}&z={z}', {
        subdomains: ['mt0', 'mt1', 'mt2', 'mt3'],
    }).addTo(map);

    markers.forEach(marker => {
        var popupContent = '<b>' + marker.name + '</b>';

        L.marker([marker.lat, marker.lng]).addTo(map).bindPopup(popupContent);
    });
};


