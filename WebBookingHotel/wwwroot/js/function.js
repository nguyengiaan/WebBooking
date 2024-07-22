$(document).ready(function () {
    $('#hotel').select2();
    $('#tags').select2();
    $("#check_lang").click(function () {
        $(".check_lang").toggle();
    });
    if ($(document).width() > 768) {
        $("#isearch").click(function () {
            $(".isearch").toggle();
        });
    } else {
        $("#isearch").click(function () {
            $(".search-form").submit();
        });
    }

});


function submit_form_search_news() {
    itemid = 20;
    url = '';
    var keyword = document.getElementById('key').value;
    keyword = encodeURIComponent(encodeURIComponent(keyword));
    var link_search = document.getElementById('link_search_news').value;
    url += '&keyword=' + keyword;
    var check = 1;
    var link = link_search + '/' + keyword + '.html';
    window.location.href = link;
    return false;
}

//function js scroll header
var scrollHeader = function () {
    var nav = $('.l-nav');
    var body = $('body');
    if (nav.length > 0) {
        $(window).scroll(function () {
            if ($(this).scrollTop() > 0) {
                nav.addClass('has-fixed');
                body.addClass('has-padding');
            }
            if ($(this).scrollTop() <= 0) {
                nav.removeClass('has-fixed');
                body.removeClass('has-padding');
            }
        });
    }
};

//var function Menu Expand
var menuExpand = function () {
    if ($('.js-menu-expand').length > 0) {
        $('.js-menu-expand').click(function (e) {
            e.preventDefault();
            var menu = $('#menu-ovelay-id');
            var book = $('#book-ovelay-id');
            var body = $('body');
            if (menu.hasClass('active')) {
                $('.c-ovelay-bottom').attr("style", "z-index: 2;");
                body.removeClass('is-ovelay');
                menu.removeClass('active');
                $('.l-nav .c-menu-expand').removeClass('active');
            } else {
                $('.c-ovelay-bottom').attr("style", "z-index: 3;");
                $('.l-nav .c-book-expand').removeClass('active');
                book.removeClass('active');
                body.addClass('is-ovelay');
                menu.addClass('active');
                $('.l-nav .c-menu-expand').addClass('active');
            }
        });
    }
};

//var function book Expand
var bookExpand = function () {
    if ($('.js-book-expand').length > 0) {
        $('.js-book-expand').click(function (e) {
            e.preventDefault();
            var menu = $('#menu-ovelay-id');
            var book = $('#book-ovelay-id');
            var body = $('body');
            if (book.hasClass('active')) {
                body.removeClass('is-ovelay');
                book.removeClass('active');
                $('.l-nav .c-book-expand').removeClass('active');
            } else {
                $('.l-nav .c-menu-expand').removeClass('active');
                menu.removeClass('active');
                body.addClass('is-ovelay');
                book.addClass('active');
                $('.l-nav .c-book-expand').addClass('active');
            }
        });
    }
};

//function js main slider
var mainSlider = function () {
    if ($('.c-slider').length > 0) {
        $('#slider-id').owlCarousel({
            items: 1,
            loop: true,
            margin: 0,
            responsiveClass: false,
            nav: false,
            dots: true,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplaySpeed: 1000,
            autoplayHoverPause: false,
            navText: false,
        });
    }
};

//function js button menu
var buttonMenu = function () {
    var slider = $('.c-slider');
    var sliderHeight = slider.height();
    var thisHeight = 46;
    var buttonTop = (sliderHeight / 2) - (thisHeight / 2);
    $(window).scroll(function () {
        if ($(this).scrollTop() > buttonTop) {
            $('.c-slider .c-menu-expand').fadeOut();
            $('.c-slider .c-book-expand').fadeOut();
            $('.l-nav.is-home .c-menu-expand').fadeIn();
            $('.l-nav.is-home .c-book-expand').fadeIn();
        } else {
            $('.c-slider .c-menu-expand').fadeIn();
            $('.c-slider .c-book-expand').fadeIn();
            $('.l-nav.is-home .c-menu-expand').fadeOut();
            $('.l-nav.is-home .c-book-expand').fadeOut();
        }
    });
};

//function js voucher slider
var voucherSlider = function () {
    if ($('.c-voucher-slider').length > 0) {
        $('#voucher-slider-id').owlCarousel({
            loop: true,
            responsiveClass: true,
            nav: false,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 2,
                    margin: 15
                },
                992: {
                    items: 3,
                    margin: 30
                }
            }
        });
    }
};

//function js testimonials slider
var testimonialsSlider = function () {
    if ($('.c-testimonials-slider').length > 0) {
        $('#testimonials-slider-id').owlCarousel({
            items: 1,
            loop: true,
            margin: 0,
            responsiveClass: false,
            nav: true,
            dots: false,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplaySpeed: 1000,
            autoplayHoverPause: false,
            navText: false,
        });
    }
};


//function js footer menu
var footerMenu = function () {
    if ($('.c-footer-menu').length > 0) {
        $('#footer-menu-id').owlCarousel({
            loop: false,
            margin: 0,
            responsiveClass: true,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 2,
                    nav: true,
                },
                768: {
                    items: 4,
                    mouseDrag: false,
                    touchDrag: false,
                    nav: false,
                }
            }
        });
    }
};

//function js footer tabs
var footerTabs = function () {
    if ($('.c-footer-menu').length > 0) {
        $('.c-footer-menu .c-menu-block a').click(function (e) {
            e.preventDefault();
            var id = $(this).attr('href');
            var parent = $(this).parent();
            var tabParent = $('.c-footer-main');
            $('.c-footer-menu .c-menu-block').removeClass('active');
            parent.addClass('active');
            $('.c-footer-pane', tabParent).hide();
            $(id).show();
        });
    }
};

//function js footer brand tabs
var footerBrandTabs = function () {
    if ($('.c-map-list').length > 0) {
        $('.c-map-list ul li a').click(function (e) {
            e.preventDefault();
            var id = $(this).attr('href');
            var parent = $(this).parent();
            var tabParent = $('.c-map-content');
            var imageId = $(this).attr('data-image');
            $('.c-map-list ul li').removeClass('active');
            parent.addClass('active');
            $('.c-map-pane', tabParent).hide();
            $(id).show();
            $('.c-map-view img').removeClass('active').hide();
            $('#footer-brand-image-' + imageId).show();
        });
    }
};

//function js intro menu
var introMenu = function () {
    if ($('.c-intro-menu').length > 0) {
        $('#intro-menu-id').owlCarousel({
            loop: false,
            margin: 0,
            responsiveClass: true,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 1,
                    nav: true,
                },
                768: {
                    items: 4,
                    mouseDrag: false,
                    touchDrag: false,
                    nav: false,
                }
            }
        });
    }
};

//function js intro tabs
var introTabs = function () {
    if ($('.c-intro-menu').length > 0) {
        $('.c-intro-menu .c-intro-block a').click(function (e) {
            e.preventDefault();
            var id = $(this).attr('href');
            var parent = $(this).parent();
            var tabParent = $('.c-intro-content');
            $('.c-intro-menu .c-intro-block').removeClass('active');
            parent.addClass('active');
            $('.c-intro-pane', tabParent).removeClass('active');
            $(id).addClass('active');
        });
    }
};

//function js brand slider
var brandSlider = function () {
    if ($('.c-brand-slider').length > 0) {
        $('#brand-slider-id').owlCarousel({
            loop: false,
            responsiveClass: true,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 1,
                    margin: 0,
                    nav: true
                },
                768: {
                    items: 4,
                    mouseDrag: false,
                    touchDrag: false,
                    margin: 1,
                    nav: false,
                }
            }
        });
    }
};

//function js service slider
var serviceSlider = function () {
    if ($('.c-service-slider').length > 0) {
        $('#service-slider-id').owlCarousel({
            loop: false,
            responsiveClass: true,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 1,
                    margin: 0,
                    nav: true
                },
                768: {
                    items: 3,
                    mouseDrag: false,
                    touchDrag: false,
                    margin: 1,
                    nav: false,
                }
            }
        });
    }
};

//function js promotions slider
var promotionsSlider = function () {
    if ($('.c-promotions-slider').length > 0) {
        $('#promotions-slider-id').owlCarousel({
            loop: false,
            responsiveClass: true,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 1,
                    margin: 0,
                    nav: true
                },
                768: {
                    items: 2,
                    mouseDrag: false,
                    touchDrag: false,
                    margin: 1,
                    nav: false,
                }
            }
        });
    }
};

//function js promotions news slider
var promotionsNewsSlider = function () {
    if ($('.c-promotions-news').length > 0) {
        $('#promotions-news-id').owlCarousel({
            loop: false,
            responsiveClass: true,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 1,
                    margin: 0,
                    nav: true,
                    autoHeight: true
                },
                768: {
                    items: 2,
                    margin: 1,
                    nav: true,
                    autoHeight: true
                },
                992: {
                    items: 4,
                    mouseDrag: false,
                    touchDrag: false,
                    margin: 1,
                    nav: false
                }
            }
        });
    }
};

//function js destinations slider
var destinationsSlider = function () {
    if ($('.c-destinations-slider').length > 0) {
        $('.js-destinations-slider').owlCarousel({
            loop: true,
            responsiveClass: true,
            nav: true,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 1,
                    margin: 0
                },
                768: {
                    items: 2,
                    margin: 40
                },
                992: {
                    items: 2,
                    margin: 65
                },
                1200: {
                    items: 2,
                    margin: 90
                },
                1600: {
                    items: 2,
                    margin: 115
                }
            }
        });
    }
};

//function js menu slider
var menuSlider = function () {
    if ($('.c-menu-slider').length > 0) {
        $('#menu-slider-id').owlCarousel({
            loop: false,
            margin: 0,
            responsiveClass: true,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 2,
                    nav: true,
                },
                768: {
                    items: 4,
                    mouseDrag: false,
                    touchDrag: false,
                    nav: false,
                }
            }
        });
    }
};

//function js menu slider 3 col
var menuSlider3col = function () {
    if ($('.js-menu-3col').length > 0) {
        $('.js-menu-3col').owlCarousel({
            loop: false,
            margin: 0,
            responsiveClass: true,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 2,
                    nav: true,
                },
                768: {
                    items: 3,
                    mouseDrag: false,
                    touchDrag: false,
                    nav: false,
                }
            }
        });
    }
};

//function js cal match height
var calMatchHeight = function () {
    if ($('.js-match-height').length > 0) {
        $('.js-match-height >ul >li').matchHeight();
    }
};

//function js detail slider
var detailSlider = function () {
    if ($('.c-detail-slider').length > 0) {
        $('#detail-slider-id').owlCarousel({
            items: 1,
            loop: true,
            margin: 0,
            responsiveClass: false,
            nav: false,
            dots: true,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplaySpeed: 1000,
            autoplayHoverPause: false,
            navText: false,
        });
    }
};


//function js about slider
var aboutSlider = function () {
    if ($('.c-about-slider').length > 0) {
        $('#about-slider-id').owlCarousel({
            items: 1,
            loop: true,
            margin: 0,
            responsiveClass: false,
            nav: false,
            dots: true,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplaySpeed: 1000,
            autoplayHoverPause: false,
            navText: false,
        });
    }
};

//function js mission slider
var missionSlider = function () {
    if ($('.c-mission-slider').length > 0) {
        $('#mission-slider-id').owlCarousel({
            loop: false,
            margin: 0,
            responsiveClass: true,
            dots: false,
            autoplay: false,
            autoHeight: true,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 1,
                    nav: true,
                },
                576: {//768
                    items: 2,
                    mouseDrag: false,
                    touchDrag: false,
                    nav: false,
                }
            }
        });
    }
};

//function js history slider
var historySlider = function () {

    var historyOwl = $('#history-slider-id');
    historyOwl.owlCarousel({
        items: 1,
        loop: false,
        margin: 0,
        responsiveClass: true,
        dots: false,
        nav: false,
        autoplay: false,
        autoHeight: true,
        autoplayTimeout: 8000,
        autoplayHoverPause: false,
        navText: false,
    });


    var pointOwl = $('#point-slider-id');
    pointOwl.owlCarousel({
        loop: false,
        margin: 0,
        responsiveClass: true,
        dots: false,
        nav: false,
        autoplay: false,
        autoHeight: true,
        autoplayTimeout: 8000,
        autoplayHoverPause: false,
        navText: false,
        center: true,
        responsive: {
            0: {
                items: 3
            },
            768: {
                items: 5
            }
        }
    });

    $('.c-history-prev').click(function () {
        historyOwl.trigger('prev.owl.carousel');
        pointOwl.trigger('prev.owl.carousel');
    });
    $('.c-history-next').click(function () {
        historyOwl.trigger('next.owl.carousel');
        pointOwl.trigger('next.owl.carousel');
    });
    historyOwl.on("dragged.owl.carousel", function (event) {
        //console.log('event : ',event.relatedTarget['_drag']['direction']);
        if (event.relatedTarget['_drag']['direction'] === "left") {
            pointOwl.trigger('next.owl.carousel');
        } else {
            pointOwl.trigger('prev.owl.carousel');
        }
    });
    pointOwl.on("dragged.owl.carousel", function (event) {
        //console.log('event : ',event.relatedTarget['_drag']['direction']);
        if (event.relatedTarget['_drag']['direction'] === "left") {
            historyOwl.trigger('next.owl.carousel');
        } else {
            historyOwl.trigger('prev.owl.carousel');
        }
    });
    $('.c-poin-item').click(function (e) {
        e.preventDefault();
        var startNumber = $(this).attr('data-number');
        pointOwl.trigger('to.owl.carousel', startNumber - 1);
        historyOwl.trigger('to.owl.carousel', startNumber - 1);
    });
};

//function js ovelay slider
var ovelaySlider = function () {
    if ($('.c-ovelay-slider').length > 0) {
        var ovelaySliderOwl = $('#ovelay-slider-id');
        ovelaySliderOwl.owlCarousel({
            items: 1,
            loop: false,
            margin: 0,
            responsiveClass: false,
            nav: false,
            dots: true,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplaySpeed: 1000,
            autoplayHoverPause: false,
            navText: false,
            animateOut: 'fadeOut',
            animateIn: 'fadeIn',
        });
    }
    if ($('.c-mega-slider').length > 0) {
        var megaSliderOwl = $('#mega-slider-id');
        megaSliderOwl.owlCarousel({
            loop: false,
            margin: 0,
            responsiveClass: true,
            dots: false,
            autoplay: false,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 1,
                    nav: true,
                },
                768: {
                    items: 4,
                    mouseDrag: false,
                    touchDrag: false,
                    nav: false,
                }
            }
        });
    }
    if ($('.c-mega-item').length > 0) {
        $('.c-mega-item .c-mega-item__title a').click(function (e) {
            e.preventDefault();
            var parent = $(this).parent().parent();
            var root = $('.c-mega-slider');
            if (!parent.hasClass('active')) {
                $('.c-mega-item', root).removeClass('active');
                parent.addClass('active');
            }
            var startNumber = $(this).attr('data-number');
            console.log(startNumber);
            ovelaySliderOwl.trigger('to.owl.carousel', startNumber - 1);
        });
    }
    megaSliderOwl.on("dragged.owl.carousel", function (event) {
        //console.log('event : ',event.relatedTarget['_drag']['direction']);
        if (event.relatedTarget['_drag']['direction'] === "left") {
            ovelaySliderOwl.trigger('next.owl.carousel');
        } else {
            ovelaySliderOwl.trigger('prev.owl.carousel');
        }
    });
    $('.owl-next', megaSliderOwl).click(function (e) {
        e.preventDefault();
        ovelaySliderOwl.trigger('next.owl.carousel');
    });
    $('.owl-prev', megaSliderOwl).click(function (e) {
        e.preventDefault();
        ovelaySliderOwl.trigger('prev.owl.carousel');
    });
};

//function js ovelay menu slider
var ovelayMenuSlider = function () {
    if ($('.c-ovelay-menu').length > 0) {
        $('.js-ovelay-menu').owlCarousel({
            margin: 10,
            loop: false,
            autoWidth: true,
            nav: false,
            dots: false,
            responsive: {
                0: {
                    items: 1,
                },
                600: {
                    items: 1,
                },
                1000: {
                    items: 7,
                    nav: true,
                }
            }
        });
    }
};

//function js mega scroll
var megaScroll = function () {
    if ($('.c-mega-item').length > 0) {
        $('.js-mega-scroll').slimScroll({
            height: 'auto',
            alwaysVisible: true,
            size: '10px',
            color: '#555',
        });
    }
};

//function js review slider
var reviewSlider = function () {
    if ($('.c-review-slider').length > 0) {
        $('#review-slider-id').owlCarousel({
            items: 1,
            loop: true,
            margin: 0,
            responsiveClass: false,
            nav: false,
            dots: true,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplaySpeed: 1000,
            autoplayHoverPause: false,
            navText: false,
        });
    }
};

//function js review expand more
var reviewExpandMore = function () {
    if ($('.c-review-entry').length > 0) {
        $('.c-review-entry__more').click(function (e) {
            e.preventDefault();
            var parent = $(this).parent().parent().parent();
            parent.addClass('active');
        });
        $('.c-review-entry__less').click(function (e) {
            e.preventDefault();
            var parent = $(this).parent().parent().parent();
            parent.removeClass('active');
        });
    }
};

//function js special slider
var specialSlider = function () {
    if ($('.c-special-slider').length > 0) {
        $('#special-slider-id').owlCarousel({
            loop: true,
            responsiveClass: true,
            nav: true,
            dots: false,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 1,
                    margin: 0
                },
                768: {
                    items: 2,
                    margin: 10
                }
            }
        });
    }
};

//function js review slider
var ourbrandSlider = function () {
    if ($('.c-ourbrand-slider').length > 0) {
        $('#ourbrand-slider-id').owlCarousel({
            items: 1,
            loop: true,
            margin: 0,
            responsiveClass: false,
            nav: true,
            dots: false,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplaySpeed: 1000,
            autoplayHoverPause: false,
            navText: false,
        });
    }
};

//function js culture testimonials
var cultureTestimonials = function () {
    if ($('.c-culture-testimonials').length > 0) {
        $('#culture-testimonials-id').owlCarousel({
            items: 1,
            loop: true,
            margin: 0,
            responsiveClass: false,
            nav: true,
            dots: false,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplaySpeed: 1000,
            autoplayHoverPause: false,
            navText: false,
        });
    }
};

//function js culture slider
var cultureSlider = function () {
    if ($('.c-culture-slider').length > 0) {
        var cultureSliderOwl = $('#culture-slider-id');
        cultureSliderOwl.owlCarousel({
            items: 1,
            loop: true,
            margin: 0,
            responsiveClass: false,
            nav: false,
            dots: false,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplaySpeed: 1000,
            autoplayHoverPause: false,
            navText: false,
            thumbs: true,
            thumbsPrerendered: true
        });
    }
};

//function js culture working
var cultureWorking = function () {
    if ($('.c-culture-working__list').length > 0) {
        $('.c-culture-working__list ul li a').click(function (e) {
            e.preventDefault();
            var id = $(this).attr('href');
            var parent = $(this).parent();
            var tabParent = $('.c-culture-working__img');
            $('.c-culture-working__list ul li').removeClass('active');
            parent.addClass('active');
            $('img', tabParent).hide().removeClass('active');
            $(id).show().addClass('active');
        });
    }
};

//function js bookingroom expand
var bookingroomExpand = function () {
    if ($('.c-booking-table').length > 0) {
        $('.js-other-price').click(function (e) {
            e.preventDefault();
            var parent = $(this).parent().parent().parent();
            var nextParent = parent.next();
            var dataRoom = $(this).attr('data-room');
            var root = $('.c-booking-table');
            //console.log(dataRoom);
            if (parent.hasClass('active')) {
                parent.removeClass('active');
                $('.tr-detail[data-room=' + dataRoom + ']', root).slideUp();
                $('.fas', this).removeClass('fa-angle-up').addClass('fa-angle-down');
            } else {
                $('.tr-detail', root).slideUp();
                $('.js-other-price .fas', root).removeClass('fa-angle-up').addClass('fa-angle-down');
                $('.tr-title', root).removeClass('active');
                parent.addClass('active');
                $('.tr-detail[data-room=' + dataRoom + ']', root).slideDown();
                $('.fas', this).removeClass('fa-angle-down').addClass('fa-angle-up');
            }
        });
    }
};

//function js review banner slider
var reviewBannerSlider = function () {
    if ($('.c-review-banner').length > 0) {
        $('#review-banner-id').owlCarousel({
            items: 1,
            loop: true,
            margin: 0,
            responsiveClass: false,
            nav: true,
            dots: false,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplaySpeed: 1000,
            autoplayHoverPause: false,
            navText: false,
        });
    }
};

//function js datepicker
var datepickerInit = function () {
    if ($('.datetimepicker').length > 0) {
        $('.datetimepicker').datetimepicker({
            format: 'DD/MM/YYYY',
            minDate: moment(),
            widgetPositioning: {
                horizontal: 'right',
                vertical: 'bottom'
            }
        });
    }
};

//function js blog slider
var blogSlider = function () {
    if ($('.c-blog-slider').length > 0) {
        $('#blog-slider-id').owlCarousel({
            loop: true,
            responsiveClass: true,
            nav: true,
            dots: false,
            autoplay: true,
            autoHeight: false,
            autoplayTimeout: 8000,
            autoplayHoverPause: false,
            navText: false,
            responsive: {
                0: {
                    items: 1,
                    margin: 0
                },
                768: {
                    items: 2,
                    margin: 1
                }
            }
        });
    }
};

//function js fancybox popup view
var fancyboxPopupView = function () {
    $('[data-fancybox]').fancybox({
        youtube: {
            controls: 1,
            showinfo: 0
        },
        vimeo: {
            color: 'f00'
        },
        btnTpl: {
            // Arrows
            arrowLeft:
                '<a data-fancybox-prev class="fancybox-button fancybox-button--arrow_left" title="{{PREV}}" href="javascript:;">' +
                '<span class="icon-arrow-left"></span>' +
                "</a>",
            arrowRight:
                '<a data-fancybox-next class="fancybox-button fancybox-button--arrow_right" title="{{NEXT}}" href="javascript:;">' +
                '<span class="icon-arrow-right"></span>' +
                "</a>",
            smallBtn:
                '<button type="button" data-fancybox-close class="fancybox-button fancybox-close-small" title="{{CLOSE}}">' +
                '<span class="icon-close"></span>' +
                "</button>"
        }
    });
};

//function js rate star
var rateStar = function () {
    if ($('.js-review-star').length > 0) {
        $('.js-review-star .fa-star').click(function (e) {
            e.preventDefault();
            var numberStar = $(this).attr('data-number');
            $('.js-review-star').removeClass().addClass('c-review-star js-review-star is-' + numberStar);
            $('.js-review-star input[type=hidden]').val(numberStar);
        });
    }
};

//function js rate star
var rangeInit = function () {
    if ($('.c-review-percent').length > 0) {
        $("[data-slider]")
            .bind("slider:ready slider:changed", function (event, data) {
                $(this).nextAll("span").html(data.value.toFixed(0));
            });
    }
};

//function js review scroll
var reviewScroll = function () {
    if ($('.c-review-trip__list').length > 0) {
        $('.js-review-scroll').slimScroll({
            height: 'auto',
            size: '10px',
            color: '#555',
        });
    }
};

//function go top
var goTop = function () {
    //hide button top on top
    $(window).scroll(function () {
        if ($(this).scrollTop() > 150) {
            $('.js-go-top').fadeIn();
        } else {
            $('.js-go-top').fadeOut();
        }
    });
    // button top
    $('.js-go-top').click(function (e) {
        e.preventDefault();
        $("html, body").animate({ scrollTop: $('body').offset().top }, 700);
    });
};

//function js mega submenu click
var megaSubmenuClick = function () {
    if ($('.c-mega-list').length > 0) {
        $('.c-mega-list ul li.c-mega-child a.item-lv').click(function (e) {
            e.preventDefault();
            var parent = $(this).parent();
            var root = $(this).parent().parent();
            if (parent.hasClass('active')) {
                parent.removeClass('active');
                $('>ul', parent).slideUp();
            } else {
                $('>li.c-mega-child.active > ul', root).slideUp();
                $('>li.c-mega-child.active', root).removeClass('active');
                parent.addClass('active');
                $('>ul', parent).slideDown();
            }
        });
    }
};

//function js inview init
var inviewInit = function () {
    var viewport = $(window).width();
    if (viewport > 767) {
        $('.c-news-list.js-news-list .b-grid').one('inview', function (event, visible) {
            if (visible) {
                $(this).addClass('animated fadeInUp delayp2');
            }
        });
        $('.c-about-us.js-about-us .c-about-title').one('inview', function (event, visible) {
            if (visible) {
                $(this).addClass('animated fadeInLeft');
            }
        });
        $('.c-about-us.js-about-us .b-maincontent').one('inview', function (event, visible) {
            if (visible) {
                $(this).addClass('animated fadeInLeft');
            }
        });
        $('.c-about-us.js-about-us .c-about-thumb').one('inview', function (event, visible) {
            if (visible) {
                $(this).addClass('animated fadeInLeft delayp2');
            }
        });
        $('.c-history-bg.js-history .c-about-left .c-about-title').one('inview', function (event, visible) {
            if (visible) {
                $(this).addClass('animated fadeInLeft');
            }
        });
        $('.c-history-bg.js-history .c-about-right .b-maincontent').one('inview', function (event, visible) {
            if (visible) {
                $(this).addClass('animated fadeInLeft delayp2');
            }
        });
        $('.c-history-bg.js-history .js-about-magic').one('inview', function (event, visible) {
            if (visible) {
                $(this).addClass('animated fadeInDown delayp4');
            }
        });
        $('.c-mission-inner.js-mission-inner .c-mission-item').one('inview', function (event, visible) {
            if (visible) {
                $(this).addClass('animated fadeInLeft');
            }
        });
        $('.c-dev-inner.js-dev-inner .c-dev-inner__thumb').one('inview', function (event, visible) {
            if (visible) {
                $(this).addClass('animated fadeInDown');
            }
        });
        $('.c-dev-inner.js-dev-inner .b-maincontent').one('inview', function (event, visible) {
            if (visible) {
                $(this).addClass('animated fadeInDown delayp2');
            }
        });
    }
};