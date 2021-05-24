function onlyCheckOne(id) {
    $("#types").find("input").each(function () {
        if ($(this).attr('id') != id && $(this).is(':checked')) {
            $(this).prop('checked', false);
        }
    });
    $("#fromprice").val("");
    $("#toprice").val("");
    filter();
}

function checkMoney() {
    if ($("#fromprice").val() < 0 || $("#toprice").val() < 0) {
        alert("Giá tiền không thể là số âm!");
        return false;
    }
    else if ($("#fromprice").val() != "" && $("#toprice").val() != "" && $("#fromprice").val() > $("#toprice").val()) {
        alert("Giá từ phải nhỏ hơn giá đến!");
        return false;
    }
    else {
        filter();
    }
}

function filter() {
    var type = "";
    var fromprice = $("#fromprice").val();
    var toprice = $("#toprice").val();

    $("#types").find("input").each(function () {
        if ($(this).is(':checked')) {
            type += $(this).val() + ",";
        }
    });

    if (type.endsWith(",")) {
        type = type.substr(0, type.length-1);
    }

    var url = window.location.href;
    if (url.includes("&")) {
        url = url.split("&")[0];
    }
    var parameters = "";
    if (type != "" && fromprice == "" && toprice == "") {
        parameters = "&type=" + type;
    }
    else if (type != "" && fromprice != "" && toprice == "") {
        parameters = "&type=" + type + "&fromprice=" + fromprice;
    }
    else if (type != "" && fromprice == "" && toprice != "") {
        parameters = "&type=" + type + "&toprice=" + toprice;
    }
    else if (type != "" && fromprice != "" && toprice != "") {
        parameters = "&type=" + type + "&fromprice=" + fromprice + "&toprice=" + toprice;
    }
    else if (type == "" && fromprice != "" && toprice == "") {
        parameters = "&fromprice=" + fromprice;
    }
    else if (type == "" && fromprice == "" && toprice != "") {
        parameters = "&toprice=" + toprice;
    }
    else if (type == "" && fromprice != "" && toprice != "") {
        parameters = "&fromprice=" + fromprice + "&toprice=" + toprice;
    }
    $.ajax({
        type: "GET",
        url: "/Devices/Danhmuc",
        data: {
            catalog: url.split("catalog=",2)[1],
            type: type,
            fromprice: fromprice,
            toprice: toprice
        },
        success: function (result) {
            window.location.href = url+parameters;
        },
        error: function (err) {
            alert("Đã có lỗi xảy ra!");
        }
    });
}

function sort() {
    var type = "";
    var fromprice = $("#fromprice").val();
    var toprice = $("#toprice").val();
    var sort = $("#sort").val();

    $("#types").find("input").each(function () {
        if ($(this).is(':checked')) {
            type += $(this).val() + ",";
        }
    });

    if (type.endsWith(",")) {
        type = type.substr(0, type.length - 1);
    }

    var url = window.location.href;
    if (url.includes("&")) {
        url = url.split("&")[0];
    }
    var parameters = "";
    if (type != "" && fromprice == "" && toprice == "") {
        parameters = "&type=" + type;
    }
    else if (type != "" && fromprice != "" && toprice == "") {
        parameters = "&type=" + type + "&fromprice=" + fromprice;
    }
    else if (type != "" && fromprice == "" && toprice != "") {
        parameters = "&type=" + type + "&toprice=" + toprice;
    }
    else if (type != "" && fromprice != "" && toprice != "") {
        parameters = "&type=" + type + "&fromprice=" + fromprice + "&toprice=" + toprice;
    }
    else if (type == "" && fromprice != "" && toprice == "") {
        parameters = "&fromprice=" + fromprice;
    }
    else if (type == "" && fromprice == "" && toprice != "") {
        parameters = "&toprice=" + toprice;
    }
    else if (type == "" && fromprice != "" && toprice != "") {
        parameters = "&fromprice=" + fromprice + "&toprice=" + toprice;
    }

    if (sort != "id") {
        parameters += "&sort=" + sort; 
    }
    $.ajax({
        type: "GET",
        url: "/Devices/Danhmuc",
        data: {
            catalog: url.split("catalog=", 2)[1],
            type: type,
            fromprice: fromprice,
            toprice: toprice,
            sort: sort
        },
        success: function (result) {
            window.location.href = url + parameters;
        },
        error: function (err) {
            alert("Đã có lỗi xảy ra!");
        }
    });
}
