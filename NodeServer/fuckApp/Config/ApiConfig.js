var option = {
    hostname: 'test.fang.com',  //һ�����ܼ�http:// ����ɴ����Ҳ�
   // hostname: 'localhost',
    port: 80,
   // path: 'path', //���ʵķ�����ַ
    path:'/',
    method: 'Get',
    headers:{
        //������������ͳ�ȥ������ͷ
        'Content-Type':'application/json' //������json����ʹ��
    }
};

option.Init= function (path,method,hostname) {
    option.hostname=hostname||option.hostname;
    option.path=path||option.path;
    option.method=method||option.method;
    return option;
}

////��������ֻ���÷�����ַ����������
//bindOption(option, "Init", function (path,method) {
//    option.path=path;
//    option.method=method;
//    return option;
//});
////����������������
//bindOption(option, "Init", function (hostname,path,method) {
//    option.hostname=hostname;
//    option.path=path;
//    option.method=method;
//    return option;
//});
//
//function bindOption(obj, name, fn) {
//    var old = obj[name]; //ÿ�������ж������һ�����Ե�old���󣬲����˱հ�
//    obj[name] = function () {
//        if (fn.length == arguments.length) {  //�����fn.length�Ƿ�����������ĸ�������arguments.length����ĸ�����������
//            return fn.apply(this, arguments); //���ش���������������ִ��
//        }
//        else {
//            return old.apply(this, arguments); //��������ķ���,�ٴ����Ͻ��в���
//        }
//    }
//}

module.exports=option;