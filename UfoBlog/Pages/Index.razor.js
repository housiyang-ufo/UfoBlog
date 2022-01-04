export function Initialize() {
    var height = document.documentElement.clientHeight - 111; // 93
    var other = height - document.getElementById("Hitokoto").clientHeight - 18 + "px"; // 93
    $("#message").css("height", height + "px");
    $("#other").css("height", other);
    $("#sidebar").css("height", height + "px");
    $("img").css("border-radius","50%");
}