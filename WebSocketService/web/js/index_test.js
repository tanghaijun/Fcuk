var ws;
$(function () {
    connecService(success);

});

function success() {
    apendMes("连接成功");
    var data = {
        message: "",
        action: "list"
    };
    sendMessage(JSON.stringify(data));
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
        var data = {
            message: txt,
            action: "allmessage"
        };
        sendMessage(JSON.stringify(data));
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
    ws = new window[support]('ws://192.168.187.251:8888/');
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
                apendMes(newdata.data);
                break;

            case "logout":
                apendMes("断开连接");
                break;
            case "list":
                apendMes(newdata.data);
                break;
        }
    };

    // 连接服务器成功
    ws.onopen = success;

    // 服务器被断开
    ws.onclose = function () {
        if (ws != null) {
            var data = '{"message":"","action":"logout"}';
            sendMessage(data);
        }
       
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