'use strict';
const TOPICS_API = {
    CREATE_OR_UPDATE: 'api/ProcessWorks/CreateOrUpdateAno',
    GET_TREES: 'api/Topics/getTreesAno',
};

var callAjax = function (url, entryData, requestType, beforeCallBack, successCallBack, errorCallBack, completeCallBack) {
    return $.ajax({
        url: url,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        data: JSON.stringify(entryData),
        async: true,
        cache: false,
        type: requestType,
        responseType: "json",
        beforeSend: beforeCallBack,
        success: successCallBack,
        error: errorCallBack,
        complete: completeCallBack
    });
};

$.fn.clearFormData = function () { var $form = $(this); $form[0].reset(); };