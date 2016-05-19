var express = require('express');
var router = express.Router();
var user=require('../Common/ApiData')

/* GET home page. */
router.get('/', function (req, res, next) {
     //��Ҫ4���������ֱ��Ƿ�����ַ���������͡���������Ĭ����localhost�����Ը�һ�����ַ����������һ���ǻص�����
    //�����ļ���config�ļ��µ�apiconfig�ļ�
     user.getData('/api/userinfo',"Get","",function(result){
         res.render('index', {title: 'Express111',content:result.Name});
    });
});
//������
router.get('/:id', function (req, res, next) {
    console.log("canshufangshi");
    user.getData('/api/userinfo/'+req.params.id,"Get","",function(result){
        res.render('index', {title: 'Express111',content:result.Name});
    });
});

module.exports = router;
