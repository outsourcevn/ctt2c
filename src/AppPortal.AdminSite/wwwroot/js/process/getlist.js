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
                    return result.datas || result;
                },
                total: function (result) {
                    return result.counts;
                },
                model: { id: "id", name: 'name' },
            },
            transport: {
                read: {
                    url: `${appConfig.apiHostUrl}/${PROCESS_API.GET_LISTS}`,
                    dataType: "json",
                    type: AjaxConst.GetRequest,
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                    },
                    data: {
                        keyword: ngNews.keyword,
                        categoryId: ngNews.categoryId,
                        status: ngNews.status,
                        type: ngNews.type
                    }
                }
            }
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
            columns: [
                { selectable: true, width: "50px" },
                {
                    field: "name",
                    title: "Tiêu đề"
                },
                {
                    field: "abstract", title: "Tóm tắt",
                    template: "#=abstract#"
                },
                {
                    field: "is_status", title: "Trạng thái", width: "150px",
                    template: "#=templateSpecial(is_status)#"
                },
                {
                    field: "image", title: "Ảnh", width: "100px",
                    template: "#=templateImage(image)#"
                },
                {
                    field: "on_created", title: "Ngày gửi yêu cầu"
                },
                {
                    field: "on_updated", title: "Ngày xử lý"
                },
                {
                    field: "on_published", title: "Ngày duyệt"
                },
                {
                    field: "id", title: "Chức năng", width:"50px",
                    attributes: { style: "text-align:center" },
                    template: "<a data-toggle='tooltip' data-placement='left' title='Cập nhật yêu cầu xử lý' class='k-button' href='/ProcessWorks/Step?id=#=id#'><i class='fa fa-edit'></i>&nbsp;Cập nhật</a>"
                }
            ]
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

        // btn-delete-all
        $('#btn-delete-all').on('click', function (e) {
            var grid = $('#dataGrid').data('kendoGrid');
            if (ngNews.lstNewsId.length > 0) {
                kendo.confirm("Xác nhận yêu cầu này không hợp lệ?")
                    .done(function () {
                        callAjax(
                            `${appConfig.apiHostUrl}/${PROCESS_API.DELETE_ALL_NEW}`,
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
                kendo.confirm("Xác nhận công bố tin lên cổng thông tin?")
                    .done(function () {
                        callAjax(
                            `${appConfig.apiHostUrl}/${PROCESS_API.SAVE_PUBLISH_NEW}`,
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

        // btn-save-process-new
        $('#btn-save-process-new').on('click', function (e) {
            var grid = $('#dataGrid').data('kendoGrid');
            if (ngNews.lstNewsId.length > 0) {
                kendo.confirm("Xác nhận duyệt yêu cầu của người dân?")
                    .done(function () {
                        callAjax(
                            `${appConfig.apiHostUrl}/${PROCESS_API.SAVE_PROCESS_NEW}`,
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
                kendo.confirm("Yêu cầu đang được xử lý?")
                    .done(function () {
                        callAjax(
                            `${appConfig.apiHostUrl}/${PROCESS_API.SAVE_DAFT_NEW}`,
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

// core function
function onChange(arg) {
    ngNews.lstNewsId = this.selectedKeyNames();
}

function onPaging(arg) {
}

function templateImage(image) {
    if (image === null) return '';
    return `<img class="rounded" src="${appConfig.apiCdnUrl}${image}" width="100" height="100" />`;
}

function templateSpecial(status) {
    var name = '';
    // label-success label-danger label-info label-warning
    switch (status) {
        case 0: name = '<label class="label label-warning">Yêu cầu mới của người dân</label>'; break;
        case 1: name = '<label class="label label-danger label-primary">Đã công bố</label>'; break;
        case 2: name = '<label class="label label-danger">Đang chờ xử lý</label>'; break;
        case 3: name = '<label class="label label-success">Đã xác nhận yêu cầu</label>'; break;
        case 4: name = '<label class="label label-danger">Yêu cầu không hợp lệ</label>'; break;
        default: name = '<label class="label label-warning">Đang chờ xử lý</label>'; break;
    }
    return name;
}