using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace helloWorldAPI.Controllers
{
    public class HelloController : ApiController
    {
        public string GetHello()
        {
            return "<h3>Hello Abhijeet</h3>";
        }
    }
}
