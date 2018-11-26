
var nameAlias = {
    cdp: "Cấp địa phương",
    vptc: "Văn phòng tổng cục",
    cbtddn: "Cán bộ trực đường dây nóng",
    btnmt: "Bộ tài nguyên môi trường",
    ldtcmt: "Lãnh đạo tổng cục môi trường",
    bnk: "Bộ ngành khác"
}
$(document).ready(function () {
    var jwtToken = getCookie("ACCESS-TOKEN");
    if (GroupId !== 'sysadmin' && GroupId !== 'huynv') {
        $(".sysadmin").hide();
    } else {
        $(".sysadmin").show();
    }

    if (GroupId === 'ttdl') {
        $("#btn-phan-cong").hide();
        $("#btn-bao-cao").hide();
        $(".tonghopbaocao").show();
    }

    if (GroupId !== 'cbtddn') {
        $("#addNews").hide();
        $(".createnews").hide();
    } else {
        $("#addNews").show();
        $(".createnews").show();
    }

    if (GroupId === 'ldtcmt') {
        $(".newdata").hide();
        $("#btn-phan-cong").show();
        $("#btn-xem-bao-cao").show();
        $(".tonghopbaocao").show();
    }

    if (GroupId === 'btnmt' || GroupId === 'bnk') {
        $(".newdata").hide();
        $("#btn-bao-cao").show();
    }


    function templateDate(date) {
        if (date) {
            return new Date(date).toLocaleString()
        } else {
            return "";
        }

    }

    $('#btn-phan-cong-new').on('click', function (e) {
        var grid = $('#dataGrid').data('kendoGrid');
        if (ngNews.lstNewsId.length > 0) {
            for (var i = 0; i < currentData.length; i++) {
                for (var j = 0; j < ngNews.lstNewsId.length; j++) {
                    var id = ngNews.lstNewsId[j];
                    if (id === currentData[i].id) {
                        if (currentData[i].is_status !== 1) {
                            messagerWarn('Thông báo', 'Vui lòng chọn tin đã duyệt.');
                            return;
                        }
                    }
                }
            }
            $("#exampleModalNew").modal('show');
        } else {
            messagerWarn('Thông báo', 'Vui lòng chọn tin.');
        }
    });

    var url2 = `${appConfig.apiHostUrl}/${NEWS_API.GET_NOTIFI}`;
    url2 = url2 + "?username=" + username;
    callAjax(
        url2,
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (success) {
            $("#countthongbao").html(success.length);
            success.forEach(function (item) {
                console.log(item);
                var html = '<a href="#" class="dropdown-item"><i class="fa fa-envelope mr-2" ></i> ' + item.Notification + ' <span class="float-right text-muted text-sm" >' + templateDate(item.OnCreated)+' </span></a>';
                html += '<div class="dropdown-divider"></div>';
                html = $("<div />").html(html).html();
                $("#thongbaodata").append(html);
            });         
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
            $(this).removeClass('disabled').removeAttr('disabled');
        }
    )

    $('#btn-bao-cao-new').on('click', function (e) {
        var grid = $('#dataGrid').data('kendoGrid');
        if (ngNews.lstNewsId.length > 0) {
            var url = `${appConfig.apiHostUrl}/${NEWS_API.GET_REPORT}`;
            url = url + "?id=" + parseInt(ngNews.lstNewsId[0]);
            callAjax(
                url,
                null,
                AjaxConst.GetRequest,
                function (xhr) {
                    $(this).addClass('disabled').attr('disabled', true);
                    xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                },
                function (success) {
                    try {
                        $("#commentNews").val(success.data);
                        $("#IdReport").val(success.Id);
                    } catch (e) {
                        $("#IdReport").val("0");
                    }
                    $("#exampleModalNew2").modal('show');
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
                    $(this).removeClass('disabled').removeAttr('disabled');
                }
            )
           
        } else {
            messagerWarn('Thông báo', 'Vui lòng chọn tin.');
        }
    });

    $('#clickPhanCong').on('click', function (e) {
        var grid = $('#dataGrid').data('kendoGrid');
        if ($("#phancongcho").val().join(",") !== "") {
            var data = {
                username: $("#phancongcho").val().join(","),
                ids: $("#exampleModalNew .NewsId").val(),
                note: $("#exampleModalNew .ghichubaocao").val(),
                type: 3
            }

            kendo.confirm("Xác nhận phân công?")
                .done(function () {
                    callAjax(
                        `${appConfig.apiHostUrl}/${NEWS_API.SAVE_PUBLISH_NEW_USERNAME}`,
                        data,
                        AjaxConst.PostRequest,
                        function (xhr) {
                            $(this).addClass('disabled').attr('disabled', true);
                            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                        },
                        function (success) {
                            if (!success.did_error) {
                                messagerSuccess('Thông báo', success.model);
                            }
                            if (grid) {
                                grid.clearSelection();
                                grid.dataSource.read();
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
                            $(this).removeClass('disabled').removeAttr('disabled');
                        }
                    )
                })
        } else {
            messagerWarn('Thông báo', 'Vui lòng chọn tin.');
        }
    });

    $('#clickChuyenConvan').on('click', function (e) {
        var grid = $('#dataGrid').data('kendoGrid');
        if ($(".js-data-example-ajax-chuyencongvan").val().join(",") !== "") {
            var data = {
                username: $(".js-data-example-ajax-chuyencongvan").val().join(","),
                ids: $("#exampleModalNew6 .NewsId").val(),
                note: $("#exampleModalNew6 .ghichubaocao").val(),
                type: 4
            }

            kendo.confirm("Xác nhận chuyển công văn?")
                .done(function () {
                    callAjax(
                        `${appConfig.apiHostUrl}/${NEWS_API.SAVE_PUBLISH_NEW_USERNAME}`,
                        data,
                        AjaxConst.PostRequest,
                        function (xhr) {
                            $(this).addClass('disabled').attr('disabled', true);
                            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                        },
                        function (success) {
                            if (!success.did_error) {
                                messagerSuccess('Thông báo', success.model);
                            }
                            if (grid) {
                                grid.clearSelection();
                                grid.dataSource.read();
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
                            $(this).removeClass('disabled').removeAttr('disabled');
                        }
                    )
                })
        } else {
            messagerWarn('Thông báo', 'Vui lòng chọn tin.');
        }
    });

    $("#clickBaocao").on('click', function (e) {
        var grid = $('#dataGrid').data('kendoGrid');
        if (ngNews.lstNewsId.length > 0) {
            var idReport = $("#IdReport").val();
            var data = {
                username: "",
                ids: ngNews.lstNewsId,
                Id: parseInt(idReport),
                NewsId: parseInt(ngNews.lstNewsId[0]),
                data: $("#commentNews").val(),
                UserName: username
            }
            
            kendo.confirm("Xác nhận báo cáo ?")
                .done(function () {
                    callAjax(
                        `${appConfig.apiHostUrl}/${NEWS_API.SAVE_PUBLISH_NEW_REPORT}`,
                        data,
                        AjaxConst.PostRequest,
                        function (xhr) {
                            $(this).addClass('disabled').attr('disabled', true);
                            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                        },
                        function (success) {
                            if (!success.did_error) {
                                messagerSuccess('Thông báo', success.model);
                            }
                            if (grid) {
                                grid.clearSelection();
                                grid.dataSource.read();
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
                            $(this).removeClass('disabled').removeAttr('disabled');
                        }
                    )
                })
        } else {
            messagerWarn('Thông báo', 'Vui lòng chọn tin.');
        }
    });

    $('#btn-xem-bao-cao-new').on('click', function (e) {
        var grid = $('#dataGrid').data('kendoGrid');
        if (ngNews.lstNewsId.length > 0) {
            var url = `${appConfig.apiHostUrl}/${NEWS_API.GET_REPORT}`;
            url = url + "?id=" + parseInt(ngNews.lstNewsId[0]);
            callAjax(
                url,
                null,
                AjaxConst.GetRequest,
                function (xhr) {
                    $(this).addClass('disabled').attr('disabled', true);
                    xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                },
                function (success) {
                    try {
                        $("#commentNews3").val(success.data);
                        $("#IdReport3").val(success.Id);
                        var name = nameAlias[success.UserName];
                        $("#nameBaocao").text(name);
                        $("#exampleModalNew3").modal('show');
                    } catch (e) {
                        messagerError("Alert", "Thông tin chưa có báo cáo!");
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
                    $(this).removeClass('disabled').removeAttr('disabled');
                }
            )

        } else {
            messagerWarn('Thông báo', 'Vui lòng chọn tin.');
        }
    });

    ////select 2
    //var urlselect2 = `${appConfig.apiHostUrl}` + '/api/Users/getUsersForType?type=dvct';
    //$('.js-data-example-ajax').select2({
    //    minimumResultsForSearch: -1,
    //    width: '100%',
    //    ajax: {
    //        url: urlselect2,
    //        dataType: 'json',
    //        beforeSend: function (xhr) {
    //            $(this).addClass('disabled').attr('disabled', true);
    //            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
    //        },
    //        processResults: function (data, params) {
    //            var dataReturn = [];
    //            for (var i = 0; i < data.length; i++) {
    //                var id = data[i].UserName;
    //                var text = data[i].FullName;
    //                var obj = {
    //                    id: id,
    //                    text: text
    //                }
    //                dataReturn.push(obj);
    //            }
                
    //            return {
    //                results: dataReturn
    //            };
    //        },
    //        // Additional AJAX parameters go here; see the end of this chapter for the full code of this example
    //    }
    //});

    var urlselect3 = `${appConfig.apiHostUrl}` + '/api/Users/getUsersForType?type=dvct_dp';
    $('.js-data-example-ajax-chuyencongvan').select2({
        minimumResultsForSearch: -1,
        width: '100%',
        ajax: {
            url: urlselect3,
            dataType: 'json',
            beforeSend: function (xhr) {
                $(this).addClass('disabled').attr('disabled', true);
                xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
            },
            processResults: function (data, params) {
                var dataReturn = [];
                for (var i = 0; i < data.length; i++) {
                    var id = data[i].UserName;
                    var text = data[i].FullName;
                    var obj = {
                        id: id,
                        text: text
                    }
                    dataReturn.push(obj);
                }

                return {
                    results: dataReturn
                };
            },
            // Additional AJAX parameters go here; see the end of this chapter for the full code of this example
        }
    });
});

function createSelect2(dataSeelcted) {
    var urlselect3 = `${appConfig.apiHostUrl}` + '/api/Users/getUsersForType?type=dvct';
    callAjax(
        urlselect3,
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (data) {
            if (data) {
                var dataReturn = [];
                for (var i = 0; i < data.length; i++) {
                    var id = data[i].UserName;
                    var text = data[i].FullName;
                    var obj = {
                        id: id,
                        text: text
                    }
                    dataReturn.push(obj);
                }

                $('.js-data-example-ajax').select2({
                    minimumResultsForSearch: -1,
                    width: '100%',
                    data: dataReturn
                });

                var data2 = [];
                for (var j = 0; j < dataSeelcted.length; j++) {
                    data2.push(dataSeelcted[j].UserName);
                }

                $('.js-data-example-ajax').val(data2).trigger('change');
            } else {
                messagerError("Error", "Lỗi hệ thống xin thử lại!");
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
            $(this).removeClass('disabled').removeAttr('disabled');
        }
    )
}

function phancong(news_id) {
    callAjax(
        `${appConfig.apiHostUrl}` + '/api/NewsLog/GetInfoNewLog?news_id=' + news_id + '&group=ttdl',
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (data) {
            if (data) {
                var success = data.info;
                createSelect2(data.phancong);
                $("#exampleModalNew .ghichubaocao").val("");
                $("#exampleModalNew .NewsId").val(news_id);
                $("#exampleModalNew .NewsLogId").val(success.Id);
                $("#exampleModalNew .ghichubaocao").val(success.Note);
                $("#exampleModalNew").modal('show');

                $('#fileupload3').addClass('fileupload-processing');
                $("#filebaocao3 tbody").empty();
                $.ajax({
                    // Uncomment the following to send cross-domain cookies:
                    //xhrFields: {withCredentials: true},
                    url: `${appConfig.apiHostUrl}` + '/api/NewsLog/upload/' + $("#exampleModalNew .NewsLogId").val(),
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader('Authorization', 'Bearer ' + getCookie("ACCESS-TOKEN"));
                        xhr.setRequestHeader('IdReprot', parseInt($("#exampleModalNew .NewsLogId").val()));
                    },
                    dataType: 'json',
                    context: $('#fileupload3')[0]
                }).always(function () {
                    $(this).removeClass('fileupload-processing');
                }).done(function (result) {
                    $(this).fileupload('option', 'done')
                        .call(this, $.Event('done'), { result: result });
                });

            } else {
                messagerError("Error", "Lỗi hệ thống xin thử lại!");
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
            $(this).removeClass('disabled').removeAttr('disabled');
        }
    )
}

function chuyencongvan(news_id) {
    $("#exampleModalNew6 .NewsId").val(news_id);
    $("#exampleModalNew6").modal('show');
}

function nhapketquaxuly() {
    var grid = $('#dataGrid').data('kendoGrid');
    if ($("#exampleModalNew_nhapketqua .IdReport").val() !== "") {
        var idReport = $("#exampleModalNew_nhapketqua .IdReport").val();
        var data = {
            Id: parseInt(idReport),
            Data: editor2.getData()
        }

        kendo.confirm("Xác nhận báo cáo ?")
            .done(function () {
                callAjax(
                    `${appConfig.apiHostUrl}` + '/api/NewsLog/PostReport',
                    data,
                    AjaxConst.PostRequest,
                    function (xhr) {
                        $(this).addClass('disabled').attr('disabled', true);
                        xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                    },
                    function (success) {
                        
                        if (!success.did_error) {
                            messagerSuccess('Thông báo', 'Nhập kết quả thành công!');
                        }
                        if (grid) {
                            grid.clearSelection();
                            grid.dataSource.read();
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
                        $(this).removeClass('disabled').removeAttr('disabled');
                    }
                )
            })
    } else {
        messagerWarn('Thông báo', 'Vui lòng chọn tin.');
    }
}

function nhapketquagopy() {
    var grid = $('#dataGrid').data('kendoGrid');
    if ($("#exampleModalNew_gopychidao .IdReport").val() !== "") {
        var idReport = $("#exampleModalNew_gopychidao .IdReport").val();
        var data = {
            Id: parseInt(idReport),
            Data: editorGopy.getData()
        }

        kendo.confirm("Xác nhận gửi ?")
            .done(function () {
                callAjax(
                    `${appConfig.apiHostUrl}` + '/api/NewsLog/PostReport',
                    data,
                    AjaxConst.PostRequest,
                    function (xhr) {
                        $(this).addClass('disabled').attr('disabled', true);
                        xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                    },
                    function (success) {

                        if (!success.did_error) {
                            messagerSuccess('Thông báo', 'Nhập kết quả thành công!');
                        }
                        if (grid) {
                            grid.clearSelection();
                            grid.dataSource.read();
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
                        $(this).removeClass('disabled').removeAttr('disabled');
                    }
                )
            })
    } else {
        messagerWarn('Thông báo', 'Vui lòng chọn tin.');
    }
}

function nhapketqua(news_id) {
    callAjax(
        `${appConfig.apiHostUrl}` + '/api/NewsLog/GetNewsLogByNewsIdNameFrom?NewsId=' + news_id + "&UserName=" + username,
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (success) {
            try {
                $("#exampleModalNew_nhapketqua .commentNews").val(success[0].Data);
                if (success[0].Data) {
                    editor2.setData(success[0].Data);
                }
                
                $("#exampleModalNew_nhapketqua .IdReport").val(success[0].Id);
            } catch (e) {
                $("#IdReport").val("0");
            }
            $("#exampleModalNew_nhapketqua").modal('show');
            $('#fileupload').addClass('fileupload-processing');
            $("#filebaocao tbody").empty();
            $.ajax({
                // Uncomment the following to send cross-domain cookies:
                //xhrFields: {withCredentials: true},
                url: `${appConfig.apiHostUrl}` + '/api/NewsLog/upload/' + $("#exampleModalNew_nhapketqua .IdReport").val(),
                beforeSend: function (xhr) {
                    xhr.setRequestHeader('Authorization', 'Bearer ' + getCookie("ACCESS-TOKEN"));
                    xhr.setRequestHeader('IdReprot', parseInt($("#exampleModalNew_nhapketqua .IdReport").val()));
                },
                dataType: 'json',
                context: $('#fileupload')[0]
            }).always(function () {
                $(this).removeClass('fileupload-processing');
            }).done(function (result) {
                $(this).fileupload('option', 'done')
                    .call(this, $.Event('done'), { result: result });
            });
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
            $(this).removeClass('disabled').removeAttr('disabled');
        }
    )
}

function gopychidao(news_id) {
    editorGopy.setData("");
    callAjax(
        `${appConfig.apiHostUrl}` + '/api/NewsLog/GetNewsLogByNewsIdNameFrom?NewsId=' + news_id + "&UserName=" + username,
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (success) {
            try {
                $("#exampleModalNew_gopychidao .commentNews").val(success[0].Data);
                if (success[0].Data) {
                    editorGopy.setData(success[0].Data);
                }

                $("#exampleModalNew_gopychidao .IdReport").val(success[0].Id);
            } catch (e) {
                $("#IdReport").val("0");
            }
            $("#exampleModalNew_gopychidao").modal('show');
            $('#fileupload4').addClass('fileupload-processing');
            $("#filebaocao tbody").empty();
            $.ajax({
                // Uncomment the following to send cross-domain cookies:
                //xhrFields: {withCredentials: true},
                url: `${appConfig.apiHostUrl}` + '/api/NewsLog/upload/' + $("#exampleModalNew_gopychidao .IdReport").val(),
                beforeSend: function (xhr) {
                    xhr.setRequestHeader('Authorization', 'Bearer ' + getCookie("ACCESS-TOKEN"));
                    xhr.setRequestHeader('IdReprot', parseInt($("#exampleModalNew_gopychidao .IdReport").val()));
                },
                dataType: 'json',
                context: $('#fileupload4')[0]
            }).always(function () {
                $(this).removeClass('fileupload-processing');
            }).done(function (result) {
                $(this).fileupload('option', 'done')
                    .call(this, $.Event('done'), { result: result });
            });
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
            $(this).removeClass('disabled').removeAttr('disabled');
        }
    )
}

function xemchitiet(news_id) {
    callAjax(
        `${appConfig.apiHostUrl}` + '/api/NewsLog/GetReport?NewsId=' + news_id,
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (success) {
            $("#thongtinbody").html("");
            success.forEach(function (value) {
                var html = "";
                if (!value.Data) {
                    value.Data = "";
                }
                html = '<label for="recipient-name" class="col-form-label">' + value.FullUserName + '</label><p>' + value.Data + '</p>';
                for (var i = 0; i < value.files.length; i++) {
                    html += '<a href="' + value.files[0].url +'" target="_blank">' + value.files[0].name + '</a><br>';
                }
                    
                $("#thongtinbody").append(html);

            });

            $("#exampleModalNew_xemchitiet").modal("show");
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
            $(this).removeClass('disabled').removeAttr('disabled');
        }
    )
}


function congkhai(news_id) {
    var grid = $('#dataGrid').data('kendoGrid');
    var ids = [];
    ids.push(news_id);
    if (news_id > 0) {
        kendo.confirm("Xác nhận đăng tin này?")
            .done(function () {
                callAjax(
                    `${appConfig.apiHostUrl}/${NEWS_API.SAVE_PROCESS_NEW}`,
                    ids,
                    AjaxConst.PostRequest,
                    function (xhr) {
                        $(this).addClass('disabled').attr('disabled', true);
                        xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                    },
                    function (success) {
                        if (!success.did_error) {
                            messagerSuccess('Thông báo', success.model);
                        }
                        if (grid) {
                            grid.clearSelection();
                            grid.dataSource.read();
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
                        $(this).removeClass('disabled').removeAttr('disabled');
                    }
                )
            })
    } else {
        messagerWarn('Thông báo', 'Vui lòng chọn tin.');
    }
}

function baocaoketqua(news_id) {
    var url = `${appConfig.apiHostUrl}/${NEWS_API.GET_REPORT}`;
    url = url + "?id=" + news_id;
    callAjax(
        url,
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (success) {
            try {
                $("#commentNews").val(success.data);
                $("#IdReport").val(success.Id);
            } catch (e) {
                $("#IdReport").val("0");
            }
            $("#exampleModalNew2").modal('show');
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
            $(this).removeClass('disabled').removeAttr('disabled');
        }
    )
}