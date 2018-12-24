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
                    url: `${appConfig.apiHostUrl}/${USER_API.GET_LISTS}`,
                    dataType: "json",
                    type: AjaxConst.GetRequest,
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                    },
                    data: {
                        keyword: ngNews.keyword
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
                    field: "field.fullName", title: "Họ và tên",
                    template: "#=field.fullName#"
                },
                {
                    field: "field.email", title: "Email",
                    template: "#=field.email#"
                },
                {
                    field: "name", title: "Tên đăng nhập",
                    template: "#=name#"
                },
                {
                    field: "field.phone", title: "Số điện thoại", width: "150px",
                    template: "#=templatePhoneNumber(field.phone)#"
                },
                {
                    field: "field.typeAccount", title: "Trạng thái", width: "200px",
                    template: "#=templateSpecial(field.typeAccount)#"
                },
                {
                    field: "id", title: "Sửa", width:"50px",
                    attributes: { style: "text-align:center" },
                    template: "<a class='k-button' href='/Users/CreateOrUpdate?id=#=id#'><i class='fa fa-edit'></i>&nbsp;Sửa</a>"
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

        // XÓA
        $('#btn-xoa').on('click', function (e) {
            var grid = $('#dataGrid').data('kendoGrid');
            if (ngNews.lstUsersId.length > 0) {
                kendo.confirm("Bạn chắc chắn muốn xóa tài khoản?")
                    .done(function () {
                        //console.log(ngNews.lstUsersId)
                        callAjax(
                            `${appConfig.apiHostUrl}/${USER_API.REMOVE_ALL}`,
                            ngNews.lstUsersId,
                            AjaxConst.PostRequest,
                            function (xhr) {
                                $('#btn-xoa').addClass('disabled').attr('disabled', true);
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
                                $('#btn-xoa').removeClass('disabled').removeAttr('disabled');
                            }
                        )
                    })
            } else {
                messagerWarn('Thông báo', 'Vui lòng chọn tài khoản cần xóa.');
            }
        });
    });
})(jQuery);

// core function
function onChange(arg) {
    ngNews.lstUsersId = this.selectedKeyNames();
}

function onPaging(arg) {
}

function templatePhoneNumber(number) {
    if (number === null) return '';
    return number;
}

function templateSpecial(status) {
    var name = '';
    switch (status) {
        case 'Users': name = '<label class="label label-warning">Tài khoản cán bộ</label>'; break;
        case 'Admins': name = '<label class="label label-danger label-primary">Tài khoản quản trị</label>'; break;
    }
    return name;
}