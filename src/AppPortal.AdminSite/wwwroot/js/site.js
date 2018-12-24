// Write your JavaScript code.
function formatDate(date) {
    var monthNames = [
        "Tháng Một", "Tháng Hai", "Tháng Ba",
        "Tháng Tư", "Tháng Năm", "Tháng Sáu", "Tháng Bảy",
        "Tháng Tám", "Tháng Chín", "Tháng Mười",
        "Tháng Mười Một", "Tháng Mười Hai"
    ];

    var day = date.getDate();
    var monthIndex = date.getMonth();
    var year = date.getFullYear();
    var hour = date.getHours();
    var minute = date.getMinutes();
    var current_day = date.getDay();
    var day_name = '';
    switch (current_day) {
        case 0:
            day_name = "Chủ nhật";
            break;
        case 1:
            day_name = "Thứ hai";
            break;
        case 2:
            day_name = "Thứ ba";
            break;
        case 3:
            day_name = "Thứ tư";
            break;
        case 4:
            day_name = "Thứ năm";
            break;
        case 5:
            day_name = "Thứ sau";
            break;
        case 6:
            day_name = "Thứ bảy";
    }

    return day_name + ' Ngày ' + day + ' ' + monthNames[monthIndex] + ' Năm ' + year + ' ' + hour + 'h: ' + minute + 'phút';
}
