$(document).ready(function() {
    document.getElementById("#spnPassword").onclick = function (e)
    { 
        if (tmpCounter == 0) {
            $("#txtPassword").attr("type", "text");
            $("#icnPassword").attr("class", "glyphicon glyphicon-eye-close");
            tmpCounter = 1;
        }
        else {
            $("#txtPassword").attr("type", "password");
            $("#icnPassword").attr("class", "glyphicon glyphicon-eye-open");
            tmpCounter = 0;
        }
    }
})