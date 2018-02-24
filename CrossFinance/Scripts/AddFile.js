$(document).on('click', '#close-preview', function () {
    $('.file-loadFile').popover('hide');
    // Hover befor close the preview
    $('.file-loadFile').hover(
        function () {
            $('.file-loadFile').popover('show');
        },
         function () {
             $('.file-loadFile').popover('hide');
         }
    );
});

$(function () {
    // Create the close button
    var closebtn = $('<button/>', {
        type: "button",
        text: 'x',
        id: 'close-preview',
        style: 'font-size: initial;',
    });
    closebtn.attr("class", "close pull-right");
    // Clear event
    $('.file-loadFile-clear').click(function () {
        $('.file-loadFile').attr("data-content", "").popover('hide');
        $('.file-loadFile-filename').val("");
        $('.file-loadFile-clear').hide();
        $('.file-loadFile-input input:file').val("");
        $(".file-loadFile-input-title").text("Browse");
    });

    $(".file-loadFile-input input:file").change(function () {
        var file = this.files[0];
        var reader = new FileReader();
        reader.onload = function (e) {
            $(".file-loadFile-input-title").text("Change");
            $(".file-loadFile-clear").show();
            $(".file-loadFile-filename").val(file.name);
        }
        reader.readAsDataURL(file);
    });
});