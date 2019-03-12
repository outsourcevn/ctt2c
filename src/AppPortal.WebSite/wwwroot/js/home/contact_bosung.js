Date.prototype.yyyymmdd = function () {
    var mm = this.getMonth() + 1; // getMonth() is zero-based
    var dd = this.getDate();

    return [this.getFullYear(),
    (mm > 9 ? '' : '0') + mm,
    (dd > 9 ? '' : '0') + dd
    ].join('-');
};

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
    $('#CategoryId').val(dataItem.id);
}

// Check inserted URL for valid Media Link
function testUrlForMedia(pastedData) {
    var success = false;
    var media = {};
    var youtube_id = '';
    if (pastedData.match('http://(www.)?youtube|youtu\.be|.com')) {
        if (pastedData.match('embed')) {
            youtube_id = pastedData.split(/embed\//)[1].split('"')[0];
        } else {
            youtube_id = pastedData.split(/v\/|v=|youtu\.be\//)[1].split(/[?&]/)[0];
        }
        media.type = "youtube";
        media.id = youtube_id;
        success = true;
    }

    if (success) {
        return media;
    } else {
        alert(
            "No valid media id detected.\nBe sure to use the \"Share\" url, located in the menu under the video on the youtube page.");
    }
    return false;
}

function insertVideo(e) {
    var editor = $(this).data("kendoEditor");

    var dialog = $($("#insertVideo-template").html())
        .find(".insertVideo-insert")
        .click(function () {

            var media = testUrlForMedia(dialog.element.find("input").val());
            if (media) {
                var template = kendo.template($("#youTube-template").html());

                editor.exec("insertHtml", { value: template({ source: media.id }) });
            }

            dialog.close();
        })
        .end()
        .find(".insertVideo-cancel")
        .click(function () {
            dialog.close();
        })
        .end()
        .kendoWindow({
            modal: true,
            title: "Insert Video",
            animation: false,
            deactivate: function () {
                dialog.destroy();
            }
        }).data("kendoWindow");

    dialog.center().open();
}

var form = document.getElementById("frm_contact");
var $form = $('form#frm_contact');


function submitForm() {
    $("#frm_contact").submit();
}

function onCompleted(event) {
    $("#contactSubmit").attr("disabled", true);
    
    if (document.getElementById("cpatchaTextBox").value !== code) {
        alert("Mã bảo mật sai. Xin thử lại!");
        createCaptcha();
        $("#contactSubmit").attr("disabled", false);
        return;
    }
    var form = document.getElementById(ngNews.formName);
    var $form = $('form#' + ngNews.formName);

    form.classList.add('was-validated');

    if ($form.valid()) {
        $("#buttonModel").click();
        $("#noidungthongbao").html('Góp ý, phản ánh của anh/chị đã được bổ sung thành công.');

        var csrfToken = $("input[name='__RequestVerificationToken']").val();

        var fileuploads = $("#filebaocao tr");
        var fileupload = "";
        for (var i = 0; i < fileuploads.length; i++) {
            var file = fileuploads[i];
            fileupload += $(file).find("td:first a").attr("href") + ",";
        }

        var dataJson = {
            Id: $("#Id").val(),
            fileUpload: fileupload,
            Noidungbosung: $("#Noidungbosung").data("kendoEditor").value()
        };
        //console.log(dataJson);
        callAjax(
            `${appConfig.apiHostUrl}` + '/api/News/BosungTT',
            dataJson,
            'POST',
            function (xhr) {
                xhr.setRequestHeader('__RequestVerificationToken', csrfToken);
                $form.children('.form-item').find('button').addClass('disabled').attr('disabled', true);
            },
            function (success) {
                if (!success.did_error) {
                }
            },
            function (xhr, status, error) {
                if (xhr.status === 400) {
                    var err = eval("(" + xhr.responseText + ")");
                    err.forEach(function (item) {
                        alert(item.Description);
                    });
                } else {
                    console.log('Vui lòng kiểm tra lại kết nối');
                }
                $("#contactSubmit").attr("disabled", false);
            },
            function (complete) {
                $("#contactSubmit").attr("disabled", false);
                $form.children('.form-item').find('button').removeClass('disabled').removeAttr('disabled');
            }
        );
    } else {
        $("#contactSubmit").attr("disabled", false);
    }
}


$(function () {
    const toolMinis = ["bold", "italic", "underline", "strikethrough", "justifyLeft", "justifyCenter", "justifyRight", "insertImage", "insertFile",
        { name: "insertVideo", tooltip: "Chèn video từ Youtube", exec: insertVideo }];


    $("textarea#Noidungbosung").kendoEditor({
        tools: toolMinis,
        imageBrowser: {
            messages: {
                dropFilesHere: "Drop files here"
            },
            transport: {
                read: `${appConfig.apiCdnUrl}/ImageBrowser/Read`,
                create: {
                    url: `${appConfig.apiCdnUrl}/ImageBrowser/Create`,
                    type: 'POST'
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
                return result.model || result;
            },
            model: { id: "id", name: 'name', children: 'items' },
        },
        transport: {
            read: {
                url: `${appConfig.apiHostUrl}/${TOPICS_API.GET_TREES}`,
                dataType: "json",
                type: 'GET'
            }
        }
    });

    $("#cat_treeview").kendoTreeView({
        dataSource: treeViewDataSource,
        dataTextField: 'name',
        checkboxes: true,
        check: onCheck,
    });

    jQuery.extend(jQuery.validator.messages, {
        required: "Yêu cầu bắt buộc phải điền",
        remote: "Please fix this field.",
        email: "Please enter a valid email address.",
        url: "Please enter a valid URL.",
        date: "Please enter a valid date.",
        dateISO: "Please enter a valid date (ISO).",
        number: "Please enter a valid number.",
        digits: "Please enter only digits.",
        creditcard: "Please enter a valid credit card number.",
        equalTo: "Please enter the same value again.",
        accept: "Please enter a value with a valid extension.",
        maxlength: jQuery.validator.format("Please enter no more than {0} characters."),
        minlength: jQuery.validator.format("Please enter at least {0} characters."),
        rangelength: jQuery.validator.format("Please enter a value between {0} and {1} characters long."),
        range: jQuery.validator.format("Please enter a value between {0} and {1}."),
        max: jQuery.validator.format("Please enter a value less than or equal to {0}."),
        min: jQuery.validator.format("Please enter a value greater than or equal to {0}.")
    });
    $("#frm_contact").submit(function (event) {
        captcha.validateUnsafe(function (isCaptchaCodeCorrect) {

            if (isCaptchaCodeCorrect) {
                // Captcha code is correct
            } else {
                // Captcha code is incorrect
            }

        });

        event.preventDefault();
    });

    $("#contact_form2 input").focus(function (e) {
       // e.preventDefault();
        // $("#myModal").modal("show");
        window.location.href = "/home/contact";
    });

    $("#contact_form2").click(function (e) {
        window.location.href = "/home/contact";
      //  e.preventDefault();
      //  $("#myModal").modal("show");
    });

    createCaptcha();
});

var code;
function createCaptcha() {
    //clear the contents of captcha div first 
    document.getElementById('captcha').innerHTML = "";
    var charsArray =
        "0123456789";
    var lengthOtp = 6;
    var captcha = [];
    for (var i = 0; i < lengthOtp; i++) {
        //below code will not allow Repetition of Characters
        var index = Math.floor(Math.random() * charsArray.length + 1); //get the next character from the array
        if (captcha.indexOf(charsArray[index]) == -1)
            captcha.push(charsArray[index]);
        else i--;
    }
    var canv = document.createElement("canvas");
    canv.id = "captcha";
    canv.width = 100;
    canv.height = 50;
    var ctx = canv.getContext("2d");
    ctx.font = "25px Georgia";
    ctx.fillStyle = "yellow";
    ctx.fillRect(0, 0, canv.width, canv.height);
    ctx.strokeText(captcha.join(""), 0, 30);
    //storing captcha so that can validate you can save it somewhere else according to your specific requirements
    code = captcha.join("");
    document.getElementById("captcha").appendChild(canv); // adds the canvas to the body element
}
function validateCaptcha() {
    event.preventDefault();
    if (document.getElementById("cpatchaTextBox").value == code) {
        alert("Valid Captcha")
    } else {
        alert("Invalid Captcha. try Again");
        createCaptcha();
    }
}

