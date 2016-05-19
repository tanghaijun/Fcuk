var express = require('express');
var router = express.Router();
var user=require('../Common/ApiData')

/* GET home page. */
router.get('/', function (req, res, next) {

     user.getData('/api/userinfo',"Get","",function(result){
         res.render('index', {title: 'Express111',content:result.Name});
    });
});

module.exports = router;
