var option = {
    hostname: 'test.fang.com',  //一定不能加http:// 会造成错误，我操
   // hostname: 'localhost',
    port: 80,
   // path: 'path', //访问的方法地址
    path:'/',
    method: 'Get',
    headers:{
        //这里放期望发送出去的请求头
        'Content-Type':'application/json' //设置了json不好使。
    }
};

option.Init= function (path,method,hostname) {
    option.hostname=hostname||option.hostname;
    option.path=path||option.path;
    option.method=method||option.method;
    return option;
}

////两个参数只设置方法地址和请求类型
//bindOption(option, "Init", function (path,method) {
//    option.path=path;
//    option.method=method;
//    return option;
//});
////三个参数设置域名
//bindOption(option, "Init", function (hostname,path,method) {
//    option.hostname=hostname;
//    option.path=path;
//    option.method=method;
//    return option;
//});
//
//function bindOption(obj, name, fn) {
//    var old = obj[name]; //每个方法中都会存在一个各自的old对象，产生了闭包
//    obj[name] = function () {
//        if (fn.length == arguments.length) {  //这里的fn.length是方法定义参数的个数，和arguments.length传入的个数是两回事
//            return fn.apply(this, arguments); //返回传入在匿名函数，执行
//        }
//        else {
//            return old.apply(this, arguments); //返回数组的方法,再次向上进行查找
//        }
//    }
//}

module.exports=option;