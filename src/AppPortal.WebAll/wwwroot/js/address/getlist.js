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
                    url: `${appConfig.apiHostUrl}/${ADDRESS_API.GET_LISTS}`,
                    dataType: "json",
                    type: AjaxConst.GetRequest,
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                    },
                    data: {
                        keyword: ngNews.keyword,
                        provinceId: ngNews.provinceId
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
                    field: "name", title: "Họ và tên",
                    template: "#=name#"
                },
                {
                    field: "province_type", title: "Loại",
                    template: "#=province_type#"
                },
                {
                    field: "lat_long", title: "Kinh độ, vĩ độ",
                    template: "#=lat_long#"
                },
                {
                    field: "province_id", title: "Mã tỉnh/huyện/thành phố",
                    template: "#=province_id#"
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
    });
})(jQuery);

// core function
function onChange(arg) {
    ngNews.lstAddressId = this.selectedKeyNames();
}

function onPaging(arg) {
}
