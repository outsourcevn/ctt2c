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
        autoUpload: true,
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

    $('#fileupload2').fileupload({
        url: `${appConfig.apiHostUrl}` + '/api/NewsLog/upload',
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Authorization', 'Bearer ' + getCookie("ACCESS-TOKEN"));
            xhr.setRequestHeader('IdReprot', parseInt($("#exampleModalNew_nhapketqua .IdReport").val()));
        }
    });

    $('#fileupload2').on('fileuploaddestroy', function (e, data) {
        var val = $('input[name="_csrfToken"]').val();
        data.headers = { 'Authorization': 'Bearer ' + getCookie("ACCESS-TOKEN") };
    });

    // Enable iframe cross-domain access via redirect option:
    $('#fileupload2').fileupload(
        'option',
        'redirect',
        window.location.href.replace(
            /\/[^\/]*$/,
            '/cors/result.html?%s'
        )
    );

    $('#fileupload3').fileupload({
        // Uncomment the following to send cross-domain cookies:
        //xhrFields: {withCredentials: true},
        url: `${appConfig.apiHostUrl}` + '/api/NewsLog/upload',
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Authorization', 'Bearer ' + getCookie("ACCESS-TOKEN"));
            xhr.setRequestHeader('IdReprot', parseInt($("#exampleModalNew .NewsLogId").val()));
        }
    });

    $('#fileupload3').on('fileuploaddestroy', function (e, data) {
        var val = $('input[name="_csrfToken"]').val();
        //data.formData = {_csrfToken: val};
        data.headers = { 'Authorization': 'Bearer ' + getCookie("ACCESS-TOKEN") };
    });

    // Enable iframe cross-domain access via redirect option:
    $('#fileupload3').fileupload(
        'option',
        'redirect',
        window.location.href.replace(
            /\/[^\/]*$/,
            '/cors/result.html?%s'
        )
    );

    $('#fileupload4').fileupload({
        // Uncomment the following to send cross-domain cookies:
        //xhrFields: {withCredentials: true},
        url: `${appConfig.apiHostUrl}` + '/api/NewsLog/upload',
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Authorization', 'Bearer ' + getCookie("ACCESS-TOKEN"));
            xhr.setRequestHeader('IdReprot', parseInt($("#exampleModalNew_gopychidao .IdReport").val()));
        }
    });

    $('#fileupload4').on('fileuploaddestroy', function (e, data) {
        var val = $('input[name="_csrfToken"]').val();
        //data.formData = {_csrfToken: val};
        data.headers = { 'Authorization': 'Bearer ' + getCookie("ACCESS-TOKEN") };
    });

    // Enable iframe cross-domain access via redirect option:
    $('#fileupload4').fileupload(
        'option',
        'redirect',
        window.location.href.replace(
            /\/[^\/]*$/,
            '/cors/result.html?%s'
        )
    );

    // tra loi nguoi dan
    $('#fileupload5').fileupload({
        // Uncomment the following to send cross-domain cookies:
        //xhrFields: {withCredentials: true},
        url: `${appConfig.apiHostUrl}` + '/api/NewsLog/upload',
        beforeSend: function (xhr) {
            xhr.setRequestHeader('Authorization', 'Bearer ' + getCookie("ACCESS-TOKEN"));
            xhr.setRequestHeader('IdReprot', parseInt($("#exampleModalNew_congkhai .IdReport").val()));
            xhr.setRequestHeader('NewsId', parseInt($("#exampleModalNew_congkhai .NewsId").val()));
        }
    });

    $('#fileupload5').on('fileuploaddestroy', function (e, data) {
        var val = $('input[name="_csrfToken"]').val();
        //data.formData = {_csrfToken: val};
        data.headers = { 'Authorization': 'Bearer ' + getCookie("ACCESS-TOKEN") };
    });

    // Enable iframe cross-domain access via redirect option:
    $('#fileupload5').fileupload(
        'option',
        'redirect',
        window.location.href.replace(
            /\/[^\/]*$/,
            '/cors/result.html?%s'
        )
    );
    
});
