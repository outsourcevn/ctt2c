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
                    url: `${appConfig.apiHostUrl}/${ROLE_API.GET_LISTS}`,
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
                    field: "field.RoleDescription", title: "Nhóm quyền",
                    template: "#=field.RoleDescription#"
                },
                {
                    field: "name", title: "Mã quyền", width: "200px",
                    template: "#=name#"
                },
                {
                    field: "id", title: "Sửa", width:"50px",
                    attributes: { style: "text-align:center" },
                    template: "<a class='k-button' href='/Roles/Edit?id=#=id#'><i class='fa fa-edit'></i>&nbsp;Sửa</a>"
                }
            ]
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
    });
})(jQuery);

// core function
function onChange(arg) {
    ngNews.lstRolesId = this.selectedKeyNames();
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