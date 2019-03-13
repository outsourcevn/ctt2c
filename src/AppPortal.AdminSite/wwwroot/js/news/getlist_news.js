var currentData = [];
var jwtToken = getCookie("ACCESS-TOKEN");
var grid = $("#dataGrid").data("kendoGrid");
(function ($) {
    'use strict';
    $(document).ready(function () {
        const toolMinis = ["bold", "italic", "underline", "strikethrough", "justifyLeft", "justifyCenter", "justifyRight", "viewHtml", "formatting", "cleanFormatting", "fontName", "fontSize", "foreColor", "backColor"];
        $("#exampleModalNew_xemchitiet .tomtat").kendoEditor({
            tools:[]
        });

        $("#exampleModalNew_xemchitiet .noidung").kendoEditor({
            tools: []
        });

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
                    url: `${appConfig.apiHostUrl}` + '/api/News/getHomeNews',
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

        $("#dataGrid").kendoGrid({
            toolbar: ["excel"],
            excel: {
                allPages: true,
                fileName: "Tổng hợp tất cả tin tức.xlsx"
            },
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
            columns: [
                { selectable: true, hidden: true },
                {
                    field: "name",
                    title: "Tiêu đề", width: "150px"
                },
                {
                    field: "abstract", title: "Tóm tắt", width: "250px",
                    template: "#=templateNote(abstract)#",
                    attributes: {
                        "class": "line-clamp"
                    }
                },
                {
                    field: "is_status", title: "Trạng thái", width: "120px",
                    template: "#=templateStatus(is_status)#"
                },
                {
                    field: "category_id", title: "Chuyên đề", template: "#=templateCate(category_id)#", width: "90px"
                },  
                {
                    field: "user_full_name", title: "Người tạo",  width: "50px"
                },
                {
                    field: "on_created", title: "Ngày tạo", template: "#=templateDate(on_created)#", width: "50px"
                },
                {
                    field: "id", title: "Hành động", width: "100px",
                    template: "#=templateAction(id , is_status)#"
                }
            ],
            excelExport: function (e) {
                var sheet = e.workbook.sheets[0];

                sheet.rows[0].cells[6] = "";
                for (var i = 1; i < sheet.rows.length; i++) {
                    var row = sheet.rows[i];
                    row.cells[6].value = "";

                    row.cells[2].value = templateStatusExport(row.cells[2].value);
                    row.cells[3].value = templateCateExport(row.cells[3].value);
                }
            }
        }).addClass("table table-responsive");

        $('#txtName').keypress(function (e) {
            var grid = $('#dataGrid').data('kendoGrid');
            if (e.which === 13) {
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

                    return itemToRemove.OrderID !== currentItem.OrderID
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
                        if (id === currentData[i].id) {
                            if (currentData[i].is_status !== 0) {
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
    });
})(jQuery);

function hoantac(id) {
    var grid = $('#dataGrid').data('kendoGrid');
    kendo.confirm("Xác nhận hoàn tác tin này?")
        .done(function () {
            callAjax(
                `${appConfig.apiHostUrl}` + '/api/News/Hoantac?id=' + id,
                null,
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

function xoavinhvien(id) {
    var grid = $('#dataGrid').data('kendoGrid');
    kendo.confirm("Xác nhận xóa vĩnh viễn tin này?")
        .done(function () {
            callAjax(
                `${appConfig.apiHostUrl}` + '/api/News/ShiftDeleteHome?id=' + id,
                null,
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

function deleteNewHome(id) {
    var grid = $('#dataGrid').data('kendoGrid');
    kendo.confirm("Xác nhận xóa?")
        .done(function () {
            callAjax(
                `${appConfig.apiHostUrl}` + '/api/News/DeleteHome?id=' + id,
                null,
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

function gopy(news_id) {
    $("#IdNotes").val(news_id);
    $("#exampleModalNew4").modal('show');
}

function clickNotes() {
    var grid = $('#dataGrid').data('kendoGrid');
    
        var data = {
            note: $("#noidungNote").val(),
            ids: $("#IdNotes").val()
        }

        kendo.confirm("Xác nhận góp ý?")
            .done(function () {
                callAjax(
                    `${appConfig.apiHostUrl}` + '/api/News/gop-y',
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
    var url = `${appConfig.apiHostUrl}` + '/api/News/UpdateStatusNewHome?Id=' + $("#newsid").val() + '&Status=' + isStatus;
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
                if (isStatus === 8) {
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

function xemchitiet(id) {
    var url = `${appConfig.apiHostUrl}` + '/api/News/getHomeNewsById?id=' + id;
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
                var data = success.model;
                $("#exampleModalNew_xemchitiet .tieude").val(data.Name);
                $("#exampleModalNew_xemchitiet .tomtat").val(data.Abstract);
                $("#exampleModalNew_xemchitiet .noidung").val(data.Content);
                $("#exampleModalNew_xemchitiet .anhdaidien").attr("src", appConfig.apiCdnUrl + data.Image);
                var tomtatedit = $("#exampleModalNew_xemchitiet .tomtat").data("kendoEditor");
                tomtatedit.value(data.Abstract);
                var noidungedit = $("#exampleModalNew_xemchitiet .noidung").data("kendoEditor");
                noidungedit.value(data.Content);


                $("#exampleModalNew_xemchitiet").modal("show");
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

function templateAction(news_id, status) {
    if (status === 4) {
        var name2 = '<button type="button" style="margin-right: 5px;" class="btn btn-primary btn-xs" onclick="hoantac(' + news_id + ')">Hoàn tác tin</button>';
        name2 += '<button type="button" style="margin-right: 5px;" class="btn btn-danger btn-xs" onclick="xoavinhvien(' + news_id + ')">Xóa vĩnh viễn</button>';
        return name2;
    } else {
        var name = '<button type="button" style="margin-right: 5px;" class="btn btn-primary btn-xs" onclick="xemchitiet(' + news_id + ')">Xem chi tiết</button>';

        var editbutton = "<a class='btn btn-primary btn-xs' href='/homenews/Edit?id=" + news_id + "'><i class='fa fa-edit'></i>&nbsp;Sửa</a> <button onclick='deleteNewHome(" + news_id + ")' type='button' class='btn btn-danger delete btn-xs'><i class= 'fa fa-trash' ></i> <span>Xóa</span></button>";
        // label-success label-danger label-info label-warning
        if (GroupId === "ttdl") {
            name += editbutton;
        }

        if (GroupId === "sysadmin") {
            name += '';
            if (status === 0) {
                name += '<button type="button" class="btn btn-primary btn-xs" onclick="xacminhthongtin(' + news_id + ')">Duyệt bài</button>';
            }

            name += '<button type="button" class="btn btn-primary btn-xs" onclick="gopy(' + news_id + ')">Góp ý</button>';
            name += '<button type="button" onclick="previewData(' + news_id + ')" class="btn btn-primary btn-xs">Xem Trước</button >';
            name += editbutton;
        }
        return name;
    }
}

function templateCate(cate){
var html = '';
    switch (cate) {
        case 1: html = ' <span class="label label-success">Văn bản chính sách</span>'; break;
        case 3: html = ' <span class="label label-success">Văn bản chính sách</span>'; break;
        case 4: html = ' <span class="label label-success">Phản ánh môi trường</span>'; break;
        case 13: html = ' <span class="label label-success">Tin truyền thông</span>'; break;
        case 14: html = ' <span class="label label-success">Giải pháp sáng kiến</span>'; break;
    }

    return html;
}

function templateCateExport(cate) {
    var html = '';
    switch (cate) {
        case 1: html ='Văn bản chính sách'; break;
        case 3: html = 'Văn bản chính sách'; break;
        case 4: html = 'Phản ánh môi trường'; break;
        case 13: html = 'Tin truyền thông'; break;
        case 14: html = 'Giải pháp sáng kiến'; break;
    }

    return html;
}

//name = name + '<button type="button" class="btn btn-primary btn-xs" onclick="baocaoketqua(' + news_id + ')">Tổng hợp kết quả xử lý</button>';
// core function
function onChange(arg) {
    ngNews.lstNewsId = this.selectedKeyNames();
}

function onPaging(arg) {
}

function templatePhanloai(istype, id) {
    var html = '<div class="form-group">';
    html += '<select class="form-control" style="font-size: 11px; color: blue;height: 15px;width: 120px;" id="sel1">';
    if (istype !== "6" && istype !== "7" && istype !== "8") {
        html += '<option disabled selected>Chưa phân loại</option>';
    } else {
        html += '<option disabled>Chưa phân loại</option>';
    }

    if (istype === "6") {
        html += '<option value="6" selected>Ô nhiễm môi trường</option>';
    } else {
        html += '<option value="6">Ô nhiễm môi trường</option>';
    }

    if (istype === "7") {
        html += '      <option value="7" selected>Cơ chế, chính sách, thủ tục hành chính</option>';
    } else {
        html += '      <option value="7">Cơ chế, chính sách, thủ tục hành chính</option>';
    }

    if (istype === "8") {
        html += '      <option value="8" selected>Giải pháp, sáng kiến bảo vệ môi trường</option>';
    } else {
        html += '      <option value="8">Giải pháp, sáng kiến bảo vệ môi trường</option>';
    }

    html += '    </select>';
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

function templateNguoitao(user_id) {
    $.ajax({
        url: `${appConfig.apiHostUrl}` + '/api/Users/getUsersById?id=' + user_id,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        type: "GET",
        responseType: "json",
        beforeSend: function (xhr) {
            $(this).addClass('disabled').attr('disabled', true);
            xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
        },
        success: function (success) {
            $("." + user_id).html(success);
        },
        error: function () {
            return "";
        }
    });
    return '<span class=' + user_id + '></span>';
}

function templatefileupload(image) {
    if (fileupload) {
        return '<img style="width: 200px;" src="' + appConfig.apiCdnUrl + image + '" />';
    } else {
        return "";
    }
}

function templateNote(note) {
    if (note) {
        return "<span class=''>" + note  + "</span>";
    } else {
        return "";
    }

}

function templateImage(image) {
    if (image === null) return '';
    return `<img class="rounded" src="${appConfig.apiCdnUrl}${image}" width="100" height="100" />`;
}

function templateStatus(status) {
    var name = '';
    // label-success label-danger label-info label-warning
    switch (status) {
        case 0: name = '<label class="label">Đang chờ duyệt</label>'; break;
        case 1: name = '<label class="label label-primary">Đã duyệt</label>'; break;
        case 4: name = '<label class="label label-primary">Đã xóa</label>'; break;
    }
    return name;
}

function templateStatusExport(status) {
    var name = '';
    // label-success label-danger label-info label-warning
    switch (status) {
        case 0:name = "Đang chờ duyệt"; break;
        case 1: name =  "Đã duyệt"; break;
        case 4: name = "Đã xóa"; break;
    }
    return name;
}



function templateSpecial(status, news_id) {
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

            getDataPhanCong(news_id, GroupId);
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
