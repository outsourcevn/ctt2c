google.charts.load('current', { packages: ['corechart', 'bar'] });
//google.charts.setOnLoadCallback(drawMaterial);
google.charts.setOnLoadCallback(drawAxisTickColors);

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

function vechart2(lstId) {
    var dataGoogle = google.visualization.arrayToDataTable(lstId);
    var options = {
        title: 'Biểu đồ giá trị AQI của các trạm',
        height: 450,
        bar: { groupWidth: '65%' },
        legend: {
            alignment: 'center',
            position: 'top'
        },
        annotations: {
            textStyle: {
                fontSize: 15,
            },
            alwaysOutside: true
        }
    };

    var chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));
    chart.draw(dataGoogle, options);
}

function drawAxisTickColors() {
    $.ajax({
        method: "GET",
        url: "http://202.60.104.121/eos/services/call/json/get_stations?qi_type=aqi",
        success: function (data, status) {
            if (data.success == true) {
                var dulieu = data.stations;
                $("#listTram").html("");
                var idFirst = 0;
                var lstId = [['Trạm', 'Giá trị AQI', { role: 'annotation' }]];
                for (var i = 0; i < dulieu.length; i++) {
                    if (dulieu[i].qi > 0) {
                        lstId.push([dulieu[i].station_name, Math.round(dulieu[i].qi), Math.round(dulieu[i].qi)]);
                    }
                }
                vechart2(lstId);
            } else {
                alert("Lỗi API. Xin vui lòng kiểm tra lại!");
            }
        },
        error: function () {
            alert("Lỗi API. Xin vui lòng kiểm tra lại!");
        }
    });
}