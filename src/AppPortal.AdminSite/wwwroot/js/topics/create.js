'use strict';

$(document).ready(function () {
    var jwtToken = getCookie("ACCESS-TOKEN");
      
    const treeViewDataSource = new kendo.data.HierarchicalDataSource({
        schema: {
            data: function (result) {
                //console.log(result.model);
                // update url assign
                return result.model || result;
            },
            model: { id: "id", name: 'name', children: 'items' },
        },
        transport: {
            read: {
                url: `${appConfig.apiHostUrl}/${TOPICS_API.GET_TREES}`,
                dataType: "json",
                type: AjaxConst.GetRequest,
                beforeSend: function (xhr) {
                    xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                }
            }
        }
    });

    $("#cat_treeview").kendoTreeView({
        dataSource: treeViewDataSource,
        dataTextField: 'name',
        checkboxes: true,
        check: onCheck,
    });

    $('input#Name').on('change', function () {
        var input = $(this).val();
        if (input === '') return;

        if (input.length > 5) {
            callAjax(
                `${appConfig.apiHostUrl}/${TOPICS_API.SET_URL}`,
                input,
                AjaxConst.PostRequest,
                function (xhr) {
                    xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                },
                function (data) {
                    if (data) {
                        $('input#Sename').val(data.model.response);
                    }
                },
                function (error) {
                    console.log(err);
                },
                function () { });
        }
    })
});

function traverse(nodes, callback) {
    for (var i = 0; i < nodes.length; i++) {
        var node = nodes[i];
        var children = node.hasChildren && node.children.data();

        callback(node);

        if (children) {
            traverse(children, callback);
        }
    }
}

function onCheck(e) {
    var dataItem = this.dataItem(e.node);

    var rootNodes = $("#cat_treeview").getKendoTreeView().dataSource.data();

    traverse(rootNodes, function (node) {
        if (node != dataItem) {
            node.set("checked", false);
        }
    });
    console.log(dataItem.id);
    $('#ParentId').val(dataItem.id);
}

(function () {
    'use strict';
    window.addEventListener('load', function () {
        var form = document.getElementById(ngNews.formName);
        var $form = $('form#' + ngNews.formName);
        var jwtToken = getCookie("ACCESS-TOKEN");
        form.addEventListener('submit', function (event) {
            if ($form.valid() === false) {
                event.preventDefault();
                event.stopPropagation();
            }
            form.classList.add('was-validated');
            event.preventDefault();
            if ($form.valid()) {
                var csrfToken = $("input[name='__RequestVerificationToken']").val();
                var dataJson = {
                    Id: $("input[id='cat_id']").val(),
                    ParentId: $("input[id='ParentId']").val(),
                    Name: $("input[id='Name']").val(),
                    IsShow: $("input#IsShow:checked").val(),
                    Sename: $("input[id='Sename']").val(),
                    MetaTitle: $("input[id='MetaTitle']").val(),
                    MetaKeywords: $("input[id='MetaKeywords']").val(),
                    MetaDescription: $("textarea[id='MetaDescription']").val(),
                    ShowType: $("select[name='ShowType'] option:selected").val(),
                    TargetUrl: $("select[name='TargetUrl'] option:selected").val(),
                    OrderSort: $("input[id='OrderSort']").val()
                };
                //console.log(dataJson);
                callAjax(
                    `${appConfig.apiHostUrl}/${TOPICS_API.CREATE_OR_UPDATE}`,
                    dataJson,
                    AjaxConst.PostRequest,
                    function (xhr) {
                        xhr.setRequestHeader('__RequestVerificationToken', csrfToken);
                        xhr.setRequestHeader('Authorization', `Bearer ${jwtToken}`);
                        $form.children('.card-footer').children('.form-group').find('button').addClass('disabled').attr('disabled', true);
                    },
                    function (success) {
                        //console.log('success ', success)
                        if (!success.did_error) {
                            messagerSuccess('Thông báo', success.model);
                            var html = '<div class="alert alert-info alert-dismissible">' +
                                '<button type="button" class="close" data-dismiss="alert" aria-hidden="true">×</button>' +
                                '<h5><i class="icon icon fa fa-info"></i> Thông báo!</h5>' +
                                success.model +
                                '</div>';
                            $('#result_message').append(html);
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
                        $form.children('.card-footer').children('.form-group').find('button').removeClass('disabled').removeAttr('disabled');
                        $form.clearFormData();
                    }
                )
            }
        }, false);
    }, false);
})();

