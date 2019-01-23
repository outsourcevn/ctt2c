'use strict';
/**
 * App config
 */
var appConfig = {
    apiBaseUrl: "",
    apiHostUrl: "",
    apiCdnUrl: ""
};

const MESSAGES = {
    ERR_CONNECTION: {
        key: '',
        value: 'No Internet Connection, Please Check Internet Connection, Internal Server Error, NotFound or Clear browser cache and cookies.'
    }
};

/**
 * jQFormSerializeArrToJson convert SerializeArr to Json Object
 * @param {any} formSerializeArr
 */
function jQFormSerializeArrToJson(formSerializeArr) {
    var jsonObj = {};
    jQuery.map(formSerializeArr, function (n, i) {
        jsonObj[n.name] = n.value;
    });

    return jsonObj;
}

/*---toast Helper---*/
function Toast(type, css, msg) {
    this.type = type;
    this.css = css;
    this.msg = 'This is positioned in the ' + msg + '. You can also style the icon any way you like.';
}

const toasts = [
    new Toast('error', 'toast-bottom-full-width', 'bottom full width'),
    new Toast('info', 'toast-top-right', 'top full width'),
    new Toast('warning', 'toast-top-left', 'top left'),
    new Toast('success', 'toast-top-right', 'top right'),
    new Toast('warning', 'toast-bottom-right', 'bottom right'),
    new Toast('error', 'toast-bottom-left', 'bottom left')
];

const toastrOptions = {
    "closeButton": true,
    "debug": false,
    "newestOnTop": true,
    "progressBar": true,
    /*"positionClass": "toast-top-full-width",*/
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "300",
    "hideDuration": "1000",
    "timeOut": "5100",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
};

toastr.options = toastrOptions;
var messagerError = function (title, msg) {
    var t = toasts[0];
    toastr.options.positionClass = t.css;
    toastr[t.type](msg, title);
}

var messagerInfo = function (title, msg) {
    var t = toasts[1];
    toastr.options.positionClass = t.css;
    toastr[t.type](msg, title);
}

var messagerWarn = function (title, msg) {
    var t = toasts[2];
    toastr.options.positionClass = t.css;
    toastr[t.type](msg, title);
}

var messagerSuccess = function (title, msg) {
    var t = toasts[3];
    toastr.options.positionClass = t.css;
    toastr[t.type](msg, title);
}
/*---toast Helper---*/

/*---Ajax Helper---*/
const AjaxConst = {
    GetRequest: 'GET',
    PostRequest: 'POST',
    PutRequest: 'PUT',
    DeleteRequest: 'DELETE',
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

var callAjaxOnlyGet = function (url, requestType, successCallBack, errorCallBack) {
    return $.ajax({
        url: url,
        contentType: "application/json; charset=utf-8",
        async: true,
        cache: false,
        type: requestType,
        responseType: "json",
        success: successCallBack,
        error: errorCallBack
    });
};

/*---Ajax Helper---*/

/**
 * COOKIE HELPER
 * Get cookie with name
 * @param {any} cname
 */
function getCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}

function setCookie(name, value, days) {
    var expires = "";
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        expires = "; expires=" + date.toUTCString();
    }
    console.log(name + "=" + (value || "") + expires + "; path=/");
    document.cookie = name + "=" + (value || "") + expires + "; path=/";
}

/**
 * COOKIE HELPER
 */

/**
 * Jquery Extensions
 * */
$.fn.clearValidation = function () { var v = $(this).validate(); $('[name]', this).each(function () { v.successList.push(this); v.showErrors(); }); v.resetForm(); v.reset(); };
$.fn.clearFormData = function () { var $form = $(this); $form[0].reset(); $form.removeClass('was-validated'); };
/* DinamicMenu()
 * dinamic activate menu
 */
$.fn.dinamicMenu = function () {
    var url = window.location
    var $this = $(this);
    // Will also work for relative and absolute hrefs
    $this.parent().parent().siblings('li').removeClass('menu-open')
    $this.each(function () {
        //|| (url.href.indexOf(this.href) > -1 && url.search !== '')
        if (this.href === url.href) {
            $(this).addClass('active not-active')
            $(this).parent().parent().prev('a').addClass('active')
            $(this).parent().parent().parent().addClass('menu-open')
        }
    })
};
/**
 * Jquery Extensions
 */

/**
 * Start Bootstrap
 **/
(function () {
    //load-config
    if (JSON.parse(localStorage.getItem('appsettings') === null)) {
        callAjaxOnlyGet(
            '/api/account/load-config',
            AjaxConst.GetRequest,
            function (success) {
                if (success.data) {
                    localStorage.setItem('appsettings', JSON.stringify(success.data));
                    appConfig = success.data;
                }
            },
            function (xhr, status, error) {
                console.log(error);
            }
        );
    } else {
        var getAppConfigs = JSON.parse(localStorage.getItem('appsettings'));
        appConfig = getAppConfigs;
        //console.log('getAppConfigs ', appConfig);
    }
})();
/**
 * Start Bootstrap
 **/

//Enable sidebar dinamic menu
$(function () {
    $('.nav-treeview li a').dinamicMenu()
})

// Handler error if ajax request unauthorized
$(document).ajaxError(function (event, xhr, settings) {
    if (xhr.status === 401) {
        document.forms["frm_logout"].submit()
    }
});