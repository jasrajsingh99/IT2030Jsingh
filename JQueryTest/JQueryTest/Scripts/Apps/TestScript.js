$(function () {
    //Hide button
    $("#hide_btn").click(function () {
        $(".hide_content").hide();

    });


    //Show button
    $("#show_btn").click(function () {
        $(".hide_content").show();

    });

    //Fun button click
    $("#fun_btn").click(function () {
        //$("#mainJQ").toggleClass("fun");
        //$("mainJQ").find("a").addClass("fun");
        $("mainJQ").find("p").css("color", "purple");

    });

    
});