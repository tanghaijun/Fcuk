//ȱ�ٷ�������Ĵ����������ղ�̫����
var http = require('http');
var optModel=require('../Config/ApiConfig');
var Obj; //���ص����ݶ���
//�������ɣ��鷳
var main={
    getData: function (path,method,hostname,callback) {
        var opt = [];
        opt = optModel.Init(path, method,hostname);
       var req1 = http.request(opt, function (res) {
           console.log("Got response: " + res.statusCode);
           res.on('data', function (obj) {
               Obj = JSON.parse(obj); //Ĭ����ô�յ������ַ������͵�json����
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