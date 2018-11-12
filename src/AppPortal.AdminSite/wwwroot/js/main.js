/*
 * jQuery File Upload Plugin JS Example
 * https://github.com/blueimp/jQuery-File-Upload
 *
 * Copyright 2010, Sebastian Tschan
 * https://blueimp.net
 *
 * Licensed under the MIT license:
 * https://opensource.org/licenses/MIT
 */

/* global $, window */

$(function () {
    'use strict';

    // Initialize the jQuery File Upload widget:
    $('#fileupload').fileupload({
        // Uncomment the following to send cross-domain cookies:
        //xhrFields: {withCredentials: true},
        url: `${appConfig.apiHostUrl}` + '/api/NewsLog/upload',
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Authorization', 'Bearer ' + getCookie("ACCESS-TOKEN"));
            xhr.setRequestHeader('IdReprot', parseInt($("#exampleModalNew_nhapketqua .IdReport").val()));
        }
    });

    $('#fileupload').on('fileuploaddestroy', function (e, data) {
        var val = $('input[name="_csrfToken"]').val();
        //data.formData = {_csrfToken: val};
        data.headers = { 'Authorization': 'Bearer ' + getCookie("ACCESS-TOKEN") };
    });

    // Enable iframe cross-domain access via redirect option:
    $('#fileupload').fileupload(
        'option',
        'redirect',
        window.location.href.replace(
            /\/[^\/]*$/,
            '/cors/result.html?%s'
        )
    );
});
