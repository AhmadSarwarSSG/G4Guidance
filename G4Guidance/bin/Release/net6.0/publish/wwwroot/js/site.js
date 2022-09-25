// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var start = 0;
var end = 6;
$(".blog-item").slice(start, end).show()
$(".blog-Load").on("click", function () {
    start = start + 6
    end = end + 6;
    $(".blog-item").slice(start, end).show()
    if ($(".blog-item:hidden").length == 0) {
        $(".blog-Load").fadeOut("slow")
    }
})
if (document.getElementById("userinfo").innerHTML != "") {
    document.getElementById("login_btn").style.display = "none";
    document.getElementById("signup_btn").style.display = "none";
    document.getElementById("user-img").style.display = "inline-block";
}
else {
    document.getElementById("user-img").style.display = "none";
}
