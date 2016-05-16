
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FuckApi.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Index()
        {
            return new string[] { "value1", "value2" };
            
        }


    }
}
