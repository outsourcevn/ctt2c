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
                    url: `${appConfig.apiHostUrl}/${TOPICS_API.GET_LIST}`,
                    dataType: "json",
                    type: AjaxConst.GetRequest,
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                    },
                    data: {
                        keyword: ngNews.keyword,
                        parentId: ngNews.parentId,
                        excludeId: ngNews.excludeId
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
                    template: "#=name#",
                    title: "Tên danh mục"
                },
                {
                    field: "level",
                    template: "#=templateSeparate(level)#",
                    title: "Cấp độ"
                },
                {
                    field: "prefix_name", title: "Danh mục cha",
                    template: "#=prefix_name#"
                },
                {
                    field: "id", title: "Chức năng",
                    attributes: { style: "text-align:center" },
                    template: "<a class='k-button' href='/Topics/Edit?id=#=id#'><i class='fa fa-edit'></i>&nbsp;Sửa</a>" +
                        " <button data-itemId='#=id#' onclick='onDelete(this)' class='k-button'><i class='fa fa-times'></i> Xóa</button>"
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
    ngNews.lstCatsId = this.selectedKeyNames();
}

function onPaging(arg) {
}

function templateSeparate(level) {
    var htmlSeparate = "";
    for (var i = level * 1; i > 0; i--) {
        htmlSeparate += "|--";
    }
    return htmlSeparate;
}

function onDelete(tag) {
    var jwtToken = getCookie("ACCESS-TOKEN");
    var $this = $(tag);
    var itemId = $this.attr("data-itemId");
    //$.get("/Category/Delete/" + itemId, function (response) {
    //    $(tag).closest("tr").remove();
    //});
    var grid = $('#dataGrid').data('kendoGrid');
    kendo.confirm("Xác nhận xóa danh mục này?")
        .done(function () {
            callAjax(
                `${appConfig.apiHostUrl}/${TOPICS_API.DELETE}`,
                itemId,
                AjaxConst.PostRequest,
                function (xhr) {
                    //$this.addClass('disabled').attr('disabled', true);
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
                    //$('#btn-delete-all').removeClass('disabled').removeAttr('disabled');
                }
            )
        })
}
