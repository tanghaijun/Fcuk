var express = require('express');
var router = express.Router();
var user=require('../Common/ApiData')

/* GET home page. */
router.get('/', function (req, res, next) {
     //需要4个参数，分别是方法地址、请求类型、主域名（默认是localhost，可以给一个空字符串），最后一个是回调函数
    //配置文件在config文件下的apiconfig文件
     user.getData('/api/userinfo',"Get","",function(result){
         res.render('index', {title: 'Express111',content:result.Name});
    });
});
//带参数
router.get('/:id', function (req, res, next) {
    console.log("canshufangshi");
    user.getData('/api/userinfo/'+req.params.id,"Get","",function(result){
        res.render('index', {title: 'Express111',content:result.Name});
    });
});

module.exports = router;
