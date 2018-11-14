google.charts.load('current', { packages: ['corechart', 'bar'] });
google.charts.setOnLoadCallback(drawMaterial);

function drawMaterial() {
    var data = google.visualization.arrayToDataTable([
        ['Địa điểm', 'Chỉ số', { role: 'style' }],
        ['', 0, ''],
        ['Hà Nội', 55, 'rgb(255, 254, 0)'],
        ['Đà Nẵng', 40, 'green'],
        ['Tp Hồ Chí Minh', 68, 'rgb(255, 254, 0)'],
        ['Hải Phòng', 43, 'green'],
        ['Huế', 40, 'green'],
    ]);
    var options = {
        title: 'Chỉ số AQI tại thời điểm hiện tại',
    };
    var chart = new google.visualization.ColumnChart(
        document.getElementById('chart_div'));
    chart.draw(data, options);
}
    


