$(document).ready(() => {

    $("#button").click(function() {
        $("#row").toggleClass("style1");
        $("#row").toggleClass("style2");
        if ($("#row").hasClass("style1")) {
            $("#button").text("Execute Jquery");
        } else {
            $("#button").text("Undo Execution");
        }
    });
});