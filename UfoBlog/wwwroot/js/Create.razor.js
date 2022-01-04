var editor;

export function Initialize() {
    editor = editormd("test-editor", {
         width  : "100%",
         height : "700px",
        path: "editormd/lib/",
    });
    $("body").css("height", "");
}

/**
 * 获取Markdown的Values 
 **/
export function GetMarkdownValues()
{
    var value = document.getElementById("test-editor");
    if (/^### Hello Editor.md !/.test(value.textContent))
        return;

    return editor.getMarkdown();
}

export function InputFileClick() {
    $("#inputFile").click();
}

export function BGroundImage(url) {
    $(".imgDiv").css("background-image", "url(" + url + ")");
}

/*
* 在网上看到用 new RegExp() 比 正则字面量  速度快
* 网址：https://www.cnblogs.com/52cik/p/js-regular-literal-regexp.html
* 我没测试过，姑且一试，以后有机会弄个测试出来
* */

/*
* 正则放定义的原因：
* 是我不想在函数里重复定义正则，比较损性能，但如果不是多次使用级别的，那也损不了多少性。
* */
// var reg =  /<[^>]+>/gi;  //过滤所有的html标签
var reg = new RegExp('<[^>]+>', 'gi');  //过滤所有的html标签，不包括内容

// var reg2 = /<(img|br|hr|input)[^>]*>/gi;  //只匹配img、br、hr、input标签
var reg2 = new RegExp('<(img|br|hr|input)[^>]*>', 'gi');  //只匹配img、br、hr、input标签

// var reg3 = /<(\S*)[^>]*>[^<]*<\/(\1)>/gi;        //分组匹配，过滤所有的html标签，包括内容
var reg3 = new RegExp('<(\\S*)[^>]*>[^<]*<\\/(\\1)>', 'gi');  //分组匹配，过滤所有的html标签，包括内容



/*
* 将所有的标签过滤，不过滤标签内内容
* */
export function filterHtml() {
    var str = editor.getMarkdown();

    if (typeof str != 'string') {  //不是字符串
        return str;
    }

    return str.replace(reg, '');
}

/*
* 讲所有的标签过滤，也过滤标签内的内容
* str 需要过滤的字符串
* isbool  为false则需要单标签过滤，为true则不需要单标签过滤
* */
function filterHtmlOrContainer(str, isbool) {
    if (typeof str != 'string') {  //不是字符串
        return str;
    }
    var result = str;
    if (!isbool) {  //先把单标签过滤了
        result = result.replace(reg2, '');
    }
    result = result.replace(reg3, '');    //先经过分组匹配，把双标签去除，如果是嵌套标签，则会先将嵌套标签内的双标签过滤掉
    if (reg3.test(result)) { //如果为true，则代表还有标签
        return filterHtmlOrContainer(result, true);
    } else {
        return result;
    }
}