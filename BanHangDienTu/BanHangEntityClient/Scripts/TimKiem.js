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
    var keyword = $("#searchtxt").val();
    var fromprice = $("#fromprice").val();
    var toprice = $("#toprice").val();

    var url = window.location.href;
    if (url.includes("&")) {
        url = url.split("&")[0];
    }
    var parameters = "";
    if (fromprice != "" && toprice == "") {
        parameters = "&fromprice=" + fromprice;
    }
    else if (fromprice == "" && toprice != "") {
        parameters = "&toprice=" + toprice;
    }
    else if (fromprice != "" && toprice != "") {
        parameters = "&fromprice=" + fromprice + "&toprice=" + toprice;
    }
    $.ajax({
        type: "GET",
        url: "/Devices/TimKiem",
        data: {
            keyword: url.split("keyword=", 2)[1],
            fromprice: fromprice,
            toprice: toprice
        },
        success: function (result) {
            window.location.href = url + parameters;
        },
        error: function (err) {
            alert("Đã có lỗi xảy ra!");
        }
    });
}

function sort() {
    var fromprice = $("#fromprice").val();
    var toprice = $("#toprice").val();
    var sort = $("#sort").val();

    var url = window.location.href;
    if (url.includes("&")) {
        url = url.split("&")[0];
    }
    var parameters = "";
    if (fromprice != "" && toprice == "") {
        parameters = "&fromprice=" + fromprice;
    }
    else if (fromprice == "" && toprice != "") {
        parameters = "&toprice=" + toprice;
    }
    else if (fromprice != "" && toprice != "") {
        parameters = "&fromprice=" + fromprice + "&toprice=" + toprice;
    }

    if (sort != "id") {
        parameters += "&sort=" + sort;
    }
    $.ajax({
        type: "GET",
        url: "/Devices/TimKiem",
        data: {
            keyword: url.split("catalog=", 2)[1],
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