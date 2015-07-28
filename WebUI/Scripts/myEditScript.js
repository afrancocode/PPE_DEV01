$(document).ready(function () {
    $("#spnPassword").click(function () {
        if ($("#txtPassword").is(":password")) {
            $("#txtPassword").attr("type", "text");
            $("#icnPassword").attr("class", "glyphicon glyphicon-eye-close");
        }
        else {
            $("#txtPassword").attr("type", "password");
            $("#icnPassword").attr("class", "glyphicon glyphicon-eye-open");
        }
    });

    $("#spnPPPassword").click(function () {
        if ($("#txtPPPassword").is(":password")) {
            $("#txtPPPassword").attr("type", "text");
            $("#icnPPPassword").attr("class", "glyphicon glyphicon-eye-close");
        }
        else {
            $("#txtPPPassword").attr("type", "password");
            $("#icnPPPassword").attr("class", "glyphicon glyphicon-eye-open");
        }
    });
});