var ws;
$(function () {
    connecService(success);

});

function success() {
    apendMes("连接成功");
    $("#send").click(function () {
        clickevent();
    });
    document.onkeydown = function () {
        if (event.keyCode == 13) {
            clickevent();
        }

    };
}
function clickevent() {
    var txt = $("#text").val();
    if (txt && txt.length > 0) {
        var data = '{"message":"' + txt + '","action":"allmessage"}';
        sendMessage(data);
        $("#text").val("");

    }
    $("#text").focus();
}
function connecService(success) {
    var support = "MozWebSocket" in window ? 'MozWebSocket' : ("WebSocket" in window ? 'WebSocket' : null);
    if (support == null) {
        appendMessage("浏览器不支持websocket<br/>");
        return;
    }
    ws = new window[support]('ws://182.92.77.101:8888/');
    // 接收到服务器发来的消息
    ws.onmessage = function (evt) {
        var newdata = $.parseJSON(evt.data);
        switch (newdata.action) {
            case "login":
                if (newdata.state == "ok") {
                    apendMes(newdata.message);
                } else {
                    alert(newdata.message);
                }
                break;
            case "allmessage":
                apendMes(newdata.message);
                break;

            case "logout":

                break;
        }
    };

    // 连接服务器成功
    ws.onopen = success;

    // 服务器被断开
    ws.onclose = function () {
        apendMes("断开连接");
        ws.close();
        ws = null;
    };
}
function appendMessage(message) {
    alert(message);
}
function sendMessage(data) {
    if (ws) {
        ws.send(data);
    }
}
function apendMes(message) {
    $(".content").append("<p>" + message + "</p>");
}