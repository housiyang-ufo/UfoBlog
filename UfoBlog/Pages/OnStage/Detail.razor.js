export function Initialize(data) {
    var height = document.documentElement.clientHeight - 111 + "px"; // 93
    $("#message").css("height", height);
    $("#sidebar").css("height", height);
    var testView = editormd.markdownToHTML("test-markdown-view", {
        markdown: data
        // markdown : "[TOC]\n### Hello world!\n## Heading 2", // Also, you can dynamic set Markdown text
        // htmlDecode : true,  // Enable / disable HTML tag encode.
        // htmlDecode : "style,script,iframe",  // Note: If enabled, you should filter some dangerous HTML tags for website security.
    });

}