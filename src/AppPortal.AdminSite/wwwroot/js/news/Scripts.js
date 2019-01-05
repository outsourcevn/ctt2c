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
    } else {
        date = new Date(date);
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

function previewData(event) {
    var form = document.getElementById(ngNews.formName);
    var $form = $('form#' + ngNews.formName);
    var jwtToken = getCookie("ACCESS-TOKEN");

    form.classList.add('was-validated');

    var publishDate = $("input[id='OnPublished']").val();
    if (!publishDate) {
        var dateCurrent = new Date();
        publishDate = dateCurrent.toLocaleDateString();
    }

    if ($form.valid()) {
        var csrfToken = $("input[name='__RequestVerificationToken']").val();
        var dataJson = {
            Id: $("input[id='News_id']").val(),
            CategoryId: $("input[id='CategoryId']").val(),
            Name: $("input[id='Name']").val(),
            Abstract: $("#Abstract").data("kendoEditor").value(),
            Content: $("#Content").data("kendoEditor").value(),
            Image: $("input[id='Image']").val(),
            Link: $("input[id='Link']").val(),
            IsShow: $("input#IsShow:checked").val(),
            Sename: $("input[id='Sename']").val(),
            MetaTitle: $("input[id='MetaTitle']").val(),
            MetaKeywords: $("input[id='MetaKeywords']").val(),
            MetaDescription: $('input#MetaDescription').val(),
            UserId: $("input[id='News_UserId']").val(),
            UserName: $("input[id='News_UserName']").val(),
            UserFullName: $("input[id='UserFullName']").val(),
            UserEmail: $("input[id='News_UserEmail']").val(),
            SourceNews: $("input[id='SourceNews']").val(),
            Note: $("textarea[id='Note']").val(),
            IsStatus: 0,
            OnPublished: $("input[id='OnPublished']").val(),
            sovanban: $("input[id='sovanban']").val(),
            tenvanban: $("input[id='tenvanban']").val(),
            ngaybanhanh: $("input[id='ngaybanhanh']").val(),
            loaivanban: $("input[id='loaivanban']").val(),
            cqbanhanh: $("input[id='cqbanhanh']").val(),
            ngayhieuluc: $("input[id='ngayhieuluc']").val(),
            tinhtranghieuluc: $("input[id='tinhtranghieuluc']").val(),
            nguoiky: $("input[id='nguoiky']").val(),
            chucdanh: $("input[id='chucdanh']").val(),
        };
        //console.log(dataJson);
        callAjax(
            `${appConfig.apiHostUrl}` + '/api/News/NewsPreviewCreateOrUpdate',
            dataJson,
            AjaxConst.PostRequest,
            function (xhr) {
                xhr.setRequestHeader('__RequestVerificationToken', csrfToken);
                xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                $form.children('.card-footer').children('.form-group').find('button').addClass('disabled').attr('disabled', true);
            },
            function (success) {
                //console.log('success ', success)
                if (!success.did_error) {
                    var url = urlTrangchu + 'News/previewTintuc?id=' + success.model;
                    window.open(url, '_blank');
                }
            },
            function (xhr, status, error) {
                if (xhr.status === 400) {
                    var err = eval("(" + xhr.responseText + ")");
                    err.forEach(function (item) {
                        messagerError(item.Code, item.Description);
                    });
                } else {
                    messagerError(MESSAGES.ERR_CONNECTION.key, MESSAGES.ERR_CONNECTION.value);
                }
            },
            function (complete) {

            }
        )
    }
}