window.onscroll = function() {scrollFunction();};

/*
 * This function applies the `hide` class to `header-title` ID
 * when the user scrolls 80 pixels down.
 */
function scrollFunction()
{
    var header_title = document.getElementsByClassName("hrow");
    var header_background = document.getElementsById("h");
    if (document.body.scrollTop > 80 || document.documentElement.scrollTop > 80)
    {header_title.classList.add("hide");
    header_background.classList.add("hideimg");}

    else {header_title.classList.remove("hide");
        header_background.classList.remove("hideimg");}
}