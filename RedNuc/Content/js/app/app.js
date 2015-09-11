$(function () {

    //Add blue animated border and remove with condition when focus and blur
    if ($('.fg-line')[0]) {
        $('body').on('focus', '.form-control', function () {
            $(this).closest('.fg-line').addClass('fg-toggled');
        })

        $('body').on('blur', '.form-control', function () {
            var p = $(this).closest('.form-group');
            var i = p.find('.form-control').val();

            if (p.hasClass('fg-float')) {
                if (i.length == 0) {
                    $(this).closest('.fg-line').removeClass('fg-toggled');
                }
            }
            else {
                $(this).closest('.fg-line').removeClass('fg-toggled');
            }
        });
    }

    /*
    * Waves Animation
    */
    (function () {
        Waves.attach('.btn:not(.btn-icon):not(.btn-float)');
        Waves.attach('.btn-icon, .btn-float', ['waves-circle', 'waves-float']);
        Waves.init();
    })();

});