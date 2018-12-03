var currentData = [];
var jwtToken = getCookie("ACCESS-TOKEN");
var grid = $("#dataGrid").data("kendoGrid");
(function ($) {
    'use strict';
    $(document).ready(function () {
        var jwtToken = getCookie("ACCESS-TOKEN");

        var dataSource = new kendo.data.DataSource({
            serverPaging: true,
            serverFiltering: true,
            batch: true,
            page: ngNews.pageNumber,
            pageSize: ngNews.pageSize,
            schema: {
                data: function (result) {
                    console.log(result);
                    var params = result.page;
                    // update url assign
                    currentData = result.datas || result;
                    return result.datas || result;
                },
                total: function (result) {
                    return result.counts;
                },
                model: { id: "id", name: 'name' },
            },
            transport: {
                read: {
                    url: `${appConfig.apiHostUrl}/${NEWS_API.GET_LIST_NEWS}`,
                    dataType: "json",
                    type: AjaxConst.GetRequest,
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                    },
                    data: {
                        keyword: ngNews.keyword,
                        categoryId: ngNews.categoryId,
                        status: ngNews.status,
                        type: ngNews.type,
                        username: username,
                        GroupId: GroupId
                    }
                }
            }
        });


        function onClick(e) {
            var grid = $("#dataGrid").data("kendoGrid");
            var row = $(e.target).closest("tr");

            if (row.hasClass("k-state-selected")) {
                setTimeout(function (e) {
                    var grid = $("#dataGrid").data("kendoGrid");
                    grid.clearSelection();
                })
            } else {
                grid.clearSelection();
            };
        };

        var columnsData = [
            { selectable: true, hidden: true },
            {
                field: "name",
                title: "Tiêu đề"
            },
        ];

        if (GroupId != "dvct") {
            var objDVCT = {
                field: "is_status", title: "Trạng thái", width: "150px",
                template: "#=templateSpecial(is_status, id)#"
            };
            columnsData.push(objDVCT);
        } else {
            var objDVCT2 = {
                field: "is_type", title: "Phân loại", width: "200px",
                template: "#=templatePhanloai2(is_type , id)#"
            };

            columnsData.push(objDVCT2);
        }

        if (GroupId == "ttdl") {
            var objVPTC = {
                field: "is_type", title: "Phân loại", width: "100px",
                template: "#=templatePhanloai(is_type , id)#"
            };
            columnsData.push(objVPTC);
        }

        if (GroupId == "ldtcmt") {
            var objDVCT6 = {
                field: "is_type", title: "Phân loại", width: "200px",
                template: "#=templatePhanloai2(is_type , id)#"
            };

            columnsData.push(objDVCT6);
        }

        columnsData.push({
            field: "on_created", title: "Ngày tiếp nhận", template: "#=templateDate(on_created)#", width: "90px"
        });

        columnsData.push({
            field: "id", title: "Hành động", width: "100px",
            template: "#=templateAction(is_status , id)#"
        });

        
        
        $("#dataGrid").kendoGrid({
            dataSource: dataSource,
            pageable: {
                refresh: true,
                numeric: true,
                alwaysVisible: true,
                pageSizes: [5, 10, 15, 20, 50, 100]
            },
            scrollable: false,
            persistSelection: true,
            change: onChange,
            page: onPaging,
            columns: columnsData
        }).addClass("table table-responsive");

        $('#txtName').keypress(function (e) {
            var grid = $('#dataGrid').data('kendoGrid');
            if (e.which == 13) {
                var keyword = $('#txtName').val();
                grid.dataSource.read({
                    keyword: keyword
                });
            }
        });

        $("#dataGrid tbody").on("click", "tr", function (e) {

            var rowElement = this;
            var row = $(rowElement);
            var grid = $("#dataGrid").getKendoGrid();
            
            
            if (row.hasClass("k-state-selected")) {

                var selected = grid.select();

                selected = $.grep(selected, function (x) {
                    var itemToRemove = grid.dataItem(row);
                    var currentItem = grid.dataItem(x);

                    return itemToRemove.OrderID != currentItem.OrderID
                })

                grid.clearSelection();

                grid.select(selected);

                e.stopPropagation();
            } else {
                grid.clearSelection();
                grid.select(row)

                e.stopPropagation();
            }
        });

        // btn-delete-all
        $('#btn-delete-all').on('click', function (e) {
            var grid = $('#dataGrid').data('kendoGrid');
            if (ngNews.lstNewsId.length > 0) {
                kendo.confirm("Xác nhận xóa tin này?")
                    .done(function () {
                        callAjax(
                            `${appConfig.apiHostUrl}/${NEWS_API.DELETE_ALL_NEW}`,
                            ngNews.lstNewsId,
                            AjaxConst.PostRequest,
                            function (xhr) {
                                $('#btn-delete-all').addClass('disabled').attr('disabled', true);
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
                                $('#btn-delete-all').removeClass('disabled').removeAttr('disabled');
                            }
                        )
                    })
            } else {
                messagerWarn('Thông báo', 'Vui lòng chọn tin.');
            }
        });
        // btn-save-publish-new
        $('#btn-save-publish-new').on('click', function (e) {
            var grid = $('#dataGrid').data('kendoGrid');
            if (ngNews.lstNewsId.length > 0) {
                for (var i = 0; i < currentData.length; i++) {
                    for (var j = 0; j < ngNews.lstNewsId.length; j++) {
                        var id = ngNews.lstNewsId[j];
                        if (id == currentData[i].id) {
                            if (currentData[i].is_status != 0) {
                                messagerWarn('Thông báo', 'Vui lòng chọn tin đang chờ xử lý.');
                                return;
                            }
                        }
                    }
                }
                $("#exampleModalNew4").modal('show');
            } else {
                messagerWarn('Thông báo', 'Vui lòng chọn tin.');
            }
        });

        // btn-save-process-new
        $('#btn-save-process-new').on('click', function (e) {
            var grid = $('#dataGrid').data('kendoGrid');
            if (ngNews.lstNewsId.length > 0) {
                kendo.confirm("Xác nhận đăng tin này?")
                    .done(function () {
                        callAjax(
                            `${appConfig.apiHostUrl}/${NEWS_API.SAVE_PROCESS_NEW}`,
                            ngNews.lstNewsId,
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
        // btn-save-dafts-new
        $('#btn-save-dafts-new').on('click', function (e) {
            var grid = $('#dataGrid').data('kendoGrid');
            if (ngNews.lstNewsId.length > 0) {
                kendo.confirm("Xác nhận đưa vào tin nháp?")
                    .done(function () {
                        callAjax(
                            `${appConfig.apiHostUrl}/${NEWS_API.SAVE_DAFT_NEW}`,
                            ngNews.lstNewsId,
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

        $("#exampleModalNew_xemchitiet2 .tomtat").kendoEditor({
            tools: []
        });

        $("#exampleModalNew_xemchitiet2 .noidung").kendoEditor({
            tools: []
        });

        $("#exampleModalNew_xemchitiet2 .noidung-ttdl").kendoEditor({
            tools: []
        });

        $("#exampleModalNew_xemchitiet2 .noidung-ldtcmt").kendoEditor({
            tools: []
        });
    });
})(jQuery);


function baocaolanhdao(news_id) {
    $("#IdNotes").val(news_id);
    $("#exampleModalNew4").modal('show');
}

function clickNotes() {
    var grid = $('#dataGrid').data('kendoGrid');
        var data = {
            note: $("#noidungNote").val(),
            ids: $("#IdNotes").val()
        }

        kendo.confirm("Xác nhận duyệt tin này và chuyển lên lãnh đạo tổng cục?")
            .done(function () {
                callAjax(
                    `${appConfig.apiHostUrl}/${NEWS_API.SAVE_PUBLISH_NEW_NOTE}`,
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
}


function xacminhthongtin(news_id) {
    console.log(news_id);
    $("#newsid").val(news_id);
    $("#exampleModalNew5").modal('show');
}

function updateTrangThai(isStatus) {
    var grid = $('#dataGrid').data('kendoGrid');
    var url = `${appConfig.apiHostUrl}/${NEWS_API.UPDATE_STATUS}` + '?Id=' + $("#newsid").val() + '&Status=' + isStatus;
    callAjax(
        url,
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (success) {
            if (!success.did_error) {
                messagerSuccess('Thông báo', success.model);
                $("#exampleModalNew5").modal("hide");
                if (isStatus == 8) {
                    $("#exampleModalNew4").modal("show");
                }
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
}

function templateAction(is_status, news_id) {
    //var name = '<button type="button" class="btn btn-primary btn-xs" onclick="xacminhthongtin(' + news_id + ')">Xác minh</button>';
    var name = '';
    var editbutton = "<a class='btn btn-primary btn-xs' href='/News/Edit?id=" + news_id + "'><i class='fa fa-edit'></i>&nbsp;Sửa</a>";
    // label-success label-danger label-info label-warning
    if (GroupId === "ttdl") {
        name = name + '<button type="button" class="btn btn-primary btn-xs" onclick="phancong(' + news_id + ')">Phân công</button>';
        name = '<button type="button" class="btn btn-primary btn-xs" onclick="congkhai(' + news_id + ')">Công khai</button>';
        name = name + '<button type="button" class="btn btn-primary btn-xs" onclick="xemchitiet(' + news_id + ')">Xem báo cáo</button>';
        name = name + editbutton;
    }

    if (GroupId === "ldtcmt") {
        //switch (is_status) {
        //    case 10: name = '<button type="button" class="btn btn-primary btn-xs" onclick="congkhai(' + news_id + ')">Công bố</button>'; break;
        //    default:
        //        name = '<button type="button" class="btn btn-primary btn-xs" onclick="congkhai(' + news_id + ')">Công bố</button>';
        //        break;
        //}
        name = name + '<button type="button" class="btn btn-primary btn-xs" onclick="xemchitiet(' + news_id + ')">Xem báo cáo</button>';
        name = name + '<button type="button" class="btn btn-primary btn-xs" onclick="xemchitietNoiDung(' + news_id + ')">Xem nội dung</button>';
        name = name + '<button type="button" class="btn btn-primary btn-xs" onclick="gopychidao(' + news_id + ')">Góp ý chỉ đạo</button>';
    }

    if (GroupId === "dvct") {
        //switch (is_status) {
        //    case 5: name = '<button type="button" class="btn btn-primary btn-xs" onclick="chuyencongvan(' + news_id + ')">Chuyển công văn</button>'; break;
        //    default: name = '<button type="button" class="btn btn-primary btn-xs" onclick="chuyencongvan(' + news_id + ')">Chuyển công văn</button>'; break;
        //}
        name = name + '<button type="button" class="btn btn-primary btn-xs" onclick="nhapketqua(' + news_id + ')">Báo cáo kết quả xử lý</button>';
        name = name + '<button type="button" class="btn btn-primary btn-xs" onclick="xemchitietNoiDung(' + news_id + ')">Xem chi tiết</button>';
    }

    if (GroupId === "dvct_dp") {  
        name = name + '<button type="button" class="btn btn-primary btn-xs" onclick="nhapketqua(' + news_id + ')">Nhập kết quả xử lý</button>';
    }

    return name;
}

function xemchitietNoiDung(news_id) {
    var element = $("#exampleModalNew_xemchitiet2");
    var editor = element.find(".noidung").data("kendoEditor");
    var editor2 = element.find(".noidung-ttdl").data("kendoEditor");
    var editor3 = element.find(".noidung-ldtcmt").data("kendoEditor");
    $(".item-from-file-ttdl").html("");
    element.find(".tieude").val("");
    editor.value("");
    editor.value("");
    $("#exampleModalNew_xemchitiet2").modal("show");
    var url = `${appConfig.apiHostUrl}` + '/api/News/xemchitiet?Id=' + news_id;
    callAjax(
        url,
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (success) {
            if (!success.did_error) {
                var info = success.info;
                var ldtcmt = success.ldtcmt;
                var ttdl = success.ttdl;
               
                element.find(".tieude").val(info.Name);
               
                editor.value(info.Content);

                //ttdl
               
                editor2.value(ttdl.newsLog.Note);

                var htmlTtdl = "";
                if (ttdl.lstFiles.length > 0) {
                    for (var i = 0; i < ttdl.lstFiles.length; i++) {
                        var fileItem = ttdl.lstFiles[i];
                        htmlTtdl += '<a target="_blank" href="' + fileItem.url + '">' + fileItem.name + '</a></br>';
                    }
                    $(".item-from-file-ttdl").html(htmlTtdl);
                }

                //ldtcmt
                
                editor3.value(ldtcmt.newsLog.Data );
                var htmlldtcmt = "";
                if (ldtcmt.lstFiles.length > 0) {
                    for (var j = 0; j < ldtcmt.lstFiles.length; j++) {
                        var fileItem2 = ttdl.lstFiles[j];
                        htmlldtcmt += '<a target="_blank" href="' + fileItem2.url + '">' + fileItem2.name + '</a></br>';
                    }
                    $(".item-from-file-ldtcmt").html(htmlldtcmt);
                }
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
            if (grid) {
                grid.clearSelection();
                grid.dataSource.read();
            }
        },
        function (complete) {
            $(this).removeClass('disabled').removeAttr('disabled');
        }
    );
}

//name = name + '<button type="button" class="btn btn-primary btn-xs" onclick="baocaoketqua(' + news_id + ')">Tổng hợp kết quả xử lý</button>';
// core function
function onChange(arg) {
    ngNews.lstNewsId = this.selectedKeyNames();
}

function onPaging(arg) {
}

function phanloaiNews(args, id) {
    var istype = parseInt($(args).val());
    var grid = $('#dataGrid').data('kendoGrid');
    var url = `${appConfig.apiHostUrl}` + '/api/News/phanloai?Id=' + id + '&istype=' + istype;
    callAjax(
        url,
        null,
        AjaxConst.GetRequest,
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
            if (grid) {
                grid.clearSelection();
                grid.dataSource.read();
            }
        },
        function (complete) {
            $(this).removeClass('disabled').removeAttr('disabled');
        }
    )
}

function templatePhanloai(istype, id) {
    var html = '<div class="form-group">';
    html += '<select class="form-control" onchange="phanloaiNews(this,'+id+')" style="font-size: 12px; color: blue;height: 15px;width: 120px;" id="sel1">';
    if (istype != "6" && istype != "7" && istype != "8" ) {
        html += '<option disabled selected>Chưa phân loại</option>';
    } else {
        html += '<option disabled>Chưa phân loại</option>';
    }

    if (istype == "6") {
        html += '<option value="6" selected>Ô nhiễm môi trường</option>';
    } else {
        html += '<option value="6">Ô nhiễm môi trường</option>';
    }

    if (istype == "7") {
        html += '      <option value="7" selected>Cơ chế, chính sách, thủ tục hành chính</option>';
    } else {
        html += '      <option value="7">Cơ chế, chính sách, thủ tục hành chính</option>';
    }

    if (istype == "8") {
        html += '      <option value="8" selected>Giải pháp, sáng kiến bảo vệ môi trường</option>';
    } else {
        html += '      <option value="8">Giải pháp, sáng kiến bảo vệ môi trường</option>';
    }
  
    html += '    </select>';
    return html;
}

function templatePhanloai2(istype) {
    var html = '';
    switch (istype) {
        case 6: html = ' <span class="label label-success">Ô nhiễm môi trường</span>'; break;
        case 7: html = ' <span class="label label-success">Cơ chế, chính sách, thủ tục hành chính</span>'; break;
        case 8: html = ' <span class="label label-success">Giải pháp, sáng kiến bảo vệ môi trường</span>'; break;
    }

    return html;
}

function templateContent(content) {
    if (content) {
        return content;
    } else {
        return "";
    }
}


function templateDate(date) {
    if (date) {
        return new Date(date).toLocaleString()
    } else {
        return "";
    }
    
}

function templatefileupload(fileupload) {
    if (fileupload) {
        var split = fileupload.split(",");
        var string = "";
        for (var i = 0; i < split.length; i++) {
            string += "<a class='atailieu' href='" + split[i] +"' target='_blank'>" + split[i] + "</a><br>";
        }
        return string;
    } else {
        return "";
    }
}

function templateNote(note) {
    if (note) {
        return "<span class='noteData'>" + note + "</span>";
    } else {
        return "";
    }
    
}

function templateImage(image) {
    if (image === null) return '';
    return `<img class="rounded" src="${appConfig.apiCdnUrl}${image}" width="100" height="100" />`;
}

function templateSpecial(status , news_id) {
    var name = '';
    // label-success label-danger label-info label-warning
    switch (status) {
        case 0: name = '<label class="label label-warning">Đang chờ xử lý</label>'; break;
        case 1: name = '<label class="label label-danger label-primary">Đã duyệt</label>'; break;
        case 2: name = '<label class="label label-danger">Tin nháp</label>'; break;
        case 3: name = '<label class="label label-success">Đã xác nhận đăng tin</label>'; break;
        case 4: name = '<label class="label label-danger">Đã xóa</label>'; break;
        case 5:
            name = '<label class="label label-danger">Đã phân công</label> <br> <span id="phancong' + news_id + '"><span>';
            
            getDataPhanCong(news_id , GroupId);
            break;
        case 6: name = '<label class="label label-danger">Đã báo cáo</label>'; break;
        case 7: name = '<label class="label label-danger">Tiếp nhận</label>'; break;
        case 8: name = '<label class="label label-danger">Đã xác minh</label>'; break;
        case 9: name = '<label class="label label-danger">Từ chối</label>'; break;
        case 10: name = '<label class="label label-danger">Báo cáo lãnh đạo</label>'; break;
        default: name = '<label class="label label-warning">Đang chờ xử lý</label>'; break;
    }
    return name;
}

function getDataPhanCong(news_id, group_name_from) {
    callAjax(
        `${appConfig.apiHostUrl}` + '/api/NewsLog/GetNewsLogByNewsIdGroupNameFrom?NewsId=' + news_id + "&GroupNameFrom=" + group_name_from + "&type=3",
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (success) {
            var returnText = "";
            for (var i = 0; i < success.length; i++) {
                returnText += success[i].FullUserName + "<br>";
            }
            
            $("#phancong" + news_id).html(returnText);
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

function getDataPhanCong(news_id, group_name_from) {
    callAjax(
        `${appConfig.apiHostUrl}` + '/api/NewsLog/GetNewsLogByNewsIdGroupNameFrom?NewsId=' + news_id + "&GroupNameFrom=" + group_name_from + "&type=3",
        null,
        AjaxConst.GetRequest,
        function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        function (success) {
            var returnText = "";
            for (var i = 0; i < success.length; i++) {
                returnText += success[i].FullUserName + "<br>";
            }
            
            $("#phancong" + news_id).html(returnText);
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