'use strict';

$(document).ready(function () {

    var fileupload = $("#fileUpload").val();
    var fileuploadSplit = fileupload.split(',');
    $.each(fileuploadSplit, function (key,value) {
        $("#fileuploadcontent").append('<br><a target="_blank" href="'+value+'">'+ value + '</a>');
    });
    $('img#image_preview').attr('src', `${appConfig.apiCdnUrl}${ngNews.Image}`);
    var jwtToken = getCookie("ACCESS-TOKEN");
    const toolMinis = ["bold", "italic", "underline", "strikethrough", "justifyLeft", "justifyCenter", "justifyRight", "viewHtml", "formatting", "cleanFormatting", "fontName", "fontSize", "foreColor", "backColor"];
    const tools = ["bold", "italic", "underline", "strikethrough", "justifyLeft", "justifyCenter", "justifyRight", "justifyFull", "insertUnorderedList", "insertOrderedList", "indent", "outdent", "createLink", "unlink", "insertImage", "insertFile", "subscript", "superscript", "tableWizard", "createTable", "addRowAbove", "addRowBelow", "addColumnLeft", "addColumnRight", "deleteRow", "deleteColumn", "viewHtml", "formatting", "cleanFormatting", "fontName", "fontSize", "foreColor", "backColor", "print"];
    $("#files").kendoUpload({
        multiple: false,
        async: {
            chunkSize: 5 * 1024 * 1024, // bytes
            saveUrl: `${appConfig.apiCdnUrl}/Upload/ChunkSave`,
            removeUrl: `${appConfig.apiCdnUrl}/Upload/remove`,
            autoUpload: true,
            batch: true
        },
        validation: {
            allowedExtensions: [".gif", ".jpg", ".png", ".img", ".bmp", ".jpg", ".tiff"]
        },
        success: function onSuccess(e) {
            if (e.response) {
                $('input#Image').val(e.response.url);
                $('img#image_preview').attr('src', `${appConfig.apiCdnUrl}/${e.response.url}`);            
            }
        },
    });

    $("textarea#Abstract").kendoEditor({
        tools: toolMinis
    });
    $("textarea#Content").kendoEditor({
        tools: tools,
        imageBrowser: {
            messages: {
                dropFilesHere: "Drop files here"
            },
            transport: {
                read: `${appConfig.apiCdnUrl}/ImageBrowser/Read`,
                destroy: {
                    url: `${appConfig.apiCdnUrl}/ImageBrowser/Destroy`,
                    type: AjaxConst.PostRequest
                },
                create: {
                    url: `${appConfig.apiCdnUrl}/ImageBrowser/Create`,
                    type: AjaxConst.PostRequest
                },
                thumbnailUrl: `${appConfig.apiCdnUrl}/ImageBrowser/Thumbnail`,
                uploadUrl: `${appConfig.apiCdnUrl}/ImageBrowser/upload`,
                imageUrl: `${appConfig.apiCdnUrl}/ImageBrowser/Image?path={0}`
            }
        }
    });

    $("textarea#Noidungbosung").kendoEditor({
        tools: tools,
        imageBrowser: {
            messages: {
                dropFilesHere: "Drop files here"
            },
            transport: {
                read: `${appConfig.apiCdnUrl}/ImageBrowser/Read`,
                destroy: {
                    url: `${appConfig.apiCdnUrl}/ImageBrowser/Destroy`,
                    type: AjaxConst.PostRequest
                },
                create: {
                    url: `${appConfig.apiCdnUrl}/ImageBrowser/Create`,
                    type: AjaxConst.PostRequest
                },
                thumbnailUrl: `${appConfig.apiCdnUrl}/ImageBrowser/Thumbnail`,
                uploadUrl: `${appConfig.apiCdnUrl}/ImageBrowser/upload`,
                imageUrl: `${appConfig.apiCdnUrl}/ImageBrowser/Image?path={0}`
            }
        }
    });

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
                url: `${appConfig.apiHostUrl}/${CATS_API.GET_TREES}`,
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
        dataBound: function () { bindingModel(ngNews.CategoryId); }
    });

    //setTimeout(bindingModel(1), 3000)

    $('input#Name').on('change', function () {
        var input = $(this).val();
        if (input === '') return;

        if (input.length > 5) {
            callAjax(
                `${appConfig.apiHostUrl}/${NEWS_API.SET_URL_NEW}`,
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

function bindingModel(id) {
    if (id === null || id === '' || id === 0 || id === '0') return;
    var Id = parseInt(id);
    var rootNodes = $("#cat_treeview").getKendoTreeView().dataSource.data();
    traverse(rootNodes, function (node) {
        if (node.id === Id) {
            node.set("checked", true);
        }
    });
}

function onCheck(e) {
    var dataItem = this.dataItem(e.node);
    var rootNodes = $("#cat_treeview").getKendoTreeView().dataSource.data();

    traverse(rootNodes, function (node) {
        if (node != dataItem) {
            node.set("checked", false);
        }
    });
    //console.log(dataItem.id);
    $('#CategoryId').val(dataItem.id);
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
                    Id: $("input[id='News_id']").val(),
                    CategoryId: $("input[id='CategoryId']").val(),
                    Name: $("input[id='Name']").val(),
                    Content: $("#Content").data("kendoEditor").value(),
                    Image: $("input[id='Image']").val(),
                    Link: $("input[id='Link']").val(),
                    IsShow: $("input#IsShow:checked").val(),
                    Sename: $("input[id='Sename']").val(),
                    MetaTitle: $("input[id='MetaTitle']").val(),
                    MetaKeywords: $("input[id='MetaKeywords']").val(),
                    MetaDescription: $("textarea[id='MetaDescription']").val(),
                    UserId: $("input[id='News_UserId']").val(),
                    UserName: $("input[id='News_UserName']").val(),
                    UserFullName: $("input[id='News_UserFullName']").val(),
                    UserEmail: $("input[id='News_UserEmail']").val(),
                    SourceNews: $("input[id='SourceNews']").val(),
                    Note: $("textarea[id='Note']").val(),
                    IsStatus: $("input[id='IsStatus']").val(),
                };
                //console.log(dataJson);
                callAjax(
                    `${appConfig.apiHostUrl}/${NEWS_API.CREATE_OR_UPDATE}?Id=${dataJson.Id}`,
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
                    }
                )
            }
        }, false);
    }, false);
})();

