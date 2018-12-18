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
        url: `${appConfig.apiHostUrl}` + '/api/NewsLog/uploadAno',
        add: function (e, data) {
            var uploadErrors = [];
            var acceptFileTypes = /\.(gif|jpg|jpeg|tiff|png|doc|docx|xls|xlsx|mp4|mpeg|wmv)$/i;

            if ($("#filebaocao tbody tr").length >= 5) {
                uploadErrors.push('Chỉ có thể upload 5 file');
            }

            if (data.originalFiles[0]['type'].indexOf("image") == -1 && data.originalFiles[0]['type'].indexOf("officedocument") == -1
                && data.originalFiles[0]['type'].indexOf("video") == -1 && data.originalFiles[0]['type'].indexOf("msword") == -1
                && data.originalFiles[0]['type'].indexOf("application/pdf") == -1) {
                uploadErrors.push('Chỉ chấp nhận ảnh video và tài liệu');
            }

            if (data.originalFiles[0]['size'].length && data.originalFiles[0]['size'] > 5000000) {
                uploadErrors.push('File không được vượt quá 50mb');
            }

            if (uploadErrors.length > 0) {
                alert(uploadErrors.join("\n"));
            } else {
                data.submit();
            }
        },
        change: function (e, data) {
            
        }
    });

    $('#fileupload').on('fileuploaddestroy', function (e, data) {
        $(data.context).remove();
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
