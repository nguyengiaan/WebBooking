//var function init call
var initReady = function () {
    //function run
    //scrollHeader();
    menuExpand();
    bookExpand();
    mainSlider();
    buttonMenu();
    voucherSlider();
    testimonialsSlider();
    blogSlider();
    footerMenu();
    //footerTabs();
    footerBrandTabs();
    introMenu();
    introTabs();
    brandSlider();
    serviceSlider();
    promotionsSlider();
    promotionsNewsSlider();
    destinationsSlider();
    menuSlider();
    menuSlider3col();
    calMatchHeight();
    detailSlider();
    // faqSlider();
    // faqExpand();
    aboutSlider();
    missionSlider();
    historySlider();
    ovelaySlider();
    ovelayMenuSlider();
    megaScroll();
    reviewSlider();
    reviewExpandMore();
    specialSlider();
    ourbrandSlider();
    cultureTestimonials();
    cultureSlider();
    cultureWorking();
    bookingroomExpand();
    reviewBannerSlider();
    datepickerInit();
    fancyboxPopupView();
    rateStar();
    rangeInit();
    reviewScroll();
    goTop();
    megaSubmenuClick();
    inviewInit();
};
var initLoad = function () {
    //function run
};
var initResize = function () {
    //function run
};

//document ready before js
$(document).ready(function () {

    //js autoload when document ready
    initReady();


});

$(window).scroll(function () {
    var height = $(window).scrollTop();

    if (height == 0) {
        $(".sticky").removeClass("fix-height");
        $("#search").css("display", "block")

    }
    if (height > 0) {
        if (!$(".sticky").hasClass("fix-height")) {
            $(".sticky").addClass("fix-height");
        }
        $("#search").css("display", "none")

    }

});
//window load all before js
$(window).on("load", function (e) {

    //js autoload when window load
    initLoad();

});

//window resize before js
$(window).resize(function () {

    //js autoload when window resize
    initResize();

});