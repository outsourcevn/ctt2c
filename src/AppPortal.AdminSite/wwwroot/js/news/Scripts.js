'use strict';
const NEWS_API = {
    GET_LIST_NEWS: 'api/News/getNews',
    CREATE_OR_UPDATE: 'api/News/CreateOrUpdate',
    CREATE_OR_UPDATE_NEWS: 'api/News/HomeNewsCreateOrUpdate',
    DELETE: 'api/News/Delete',
    SET_URL_NEW: 'api/News/set-url-new',
    DELETE_ALL_NEW: 'api/News/delete-all-new',
    SAVE_PROCESS_NEW: 'api/News/save-process-new',
    SAVE_PUBLISH_NEW: 'api/News/save-publish-new',
    SAVE_PUBLISH_NEW_USERNAME: 'api/News/save-publish-new-username',
    SAVE_DAFT_NEW: 'api/News/save-dafts-new',
    ADD_RELATED_NEW: 'api/News/add-related-new',
    SAVE_PUBLISH_NEW_REPORT: 'api/News/save-publish-new-report',
    SAVE_PUBLISH_NEW_NOTE: 'api/News/save-publish-new-note',
    GET_REPORT: 'api/News/GetReport',
    GET_NOTIFI: 'api/News/GetNotifi',

    //Update Status
    UPDATE_STATUS: 'api/News/UpdateStatus',
    
};

const CATS_API = {
    GET_TREES: 'api/Categories/getTreeCats'
};

function formatDate(date) {
    if (date == undefined) {
        date = new Date();
    }
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