$(function () {
    $("div:eq(14)").click(function () {
        var url = "AddCategory.aspx";
        $(location).prop('href', url);
    });
    $("div:eq(15)").click(function () {
        var url = "ViewProduct.aspx";
        $(location).prop('href', url);
    });
    $("div:eq(16)").click(function () {
        var url = "AddPromotion.aspx";
        $(location).prop('href', url);
    });
    $("div:eq(17)").click(function () {
        var url = "view_users.aspx";
        $(location).prop('href', url);
    });
    $("div:eq(18)").click(function () {
        var url = "PenOrder.aspx";
        $(location).prop('href', url);
    });
});//load