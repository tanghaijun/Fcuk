using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FuckApi.Models;
namespace FuckApi.Controllers
{
    public class UserInfoController : ApiController
    {
        // GET api/userinfo
        public HttpResponseMessage Get()
        {

            Test test = new Test();
            test.Id = "1";
            test.Name = "yukaifei";
            var result = Common.Convert.toJson(test);
            return result;
        }

        // GET api/userinfo/5
        public HttpResponseMessage Get(int id)
        {
            Test test = new Test();
            test.Id = "2";
            test.Name = "haha";
            var result = Common.Convert.toJson(test);
            return result;
        }

        // POST api/userinfo
        public void Post([FromBody]string value)
        {
        }

        // PUT api/userinfo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/userinfo/5
        public void Delete(int id)
        {
        }
    }
}
