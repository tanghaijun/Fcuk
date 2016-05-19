//缺少发生错误的处理，参数接收不太合理
var http = require('http');
var optModel=require('../Config/ApiConfig');
var Obj; //返回的数据对象
//先这样吧，麻烦
var main={
    getData: function (path,method,hostname,callback) {
        var opt = [];
        opt = optModel.Init(path, method,hostname);
       var req1 = http.request(opt, function (res) {
           console.log("Got response: " + res.statusCode);
           res.on('data', function (obj) {
               Obj = JSON.parse(obj); //默认怎么收到的是字符串类型的json对象？
              // Obj=obj;
           }).on('end', function () {
               callback(Obj);
           });
       }).on('error', function (e) {
           console.log("Got error: " + e.message);
       })
       req1.end();
       return Obj;
    }
}
module.exports = main;