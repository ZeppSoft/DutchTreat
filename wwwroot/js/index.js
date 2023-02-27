/// <reference path="../lib/jquery/dist/jquery.js" />
$(document).ready(function () {
    var x = 0;
    var s = "";

    /*alert("Hello world!");*/
    console.log("Hello world!");

    // the alias for jQuery is $ char


    //var theForm = document.getElementById("theForm");
    //theForm.hidden = true;

    //var button = document.getElementById("buyButton");
    //button.addEventListener("click", function () {
    //    console.log("Buying Item");
    //});

    var theForm = $("#theForm");
    theForm.hide();

    var button = $("#buyButton");
    button.on("click", function () {
        console.log("Buying Item");
    });


    var productInfo = $(".product-info li");
    productInfo.on("click", function () {
        console.log("You clicked on " + $(this).text());
    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () {
        $popupForm.toggle(1000);
    });
});
