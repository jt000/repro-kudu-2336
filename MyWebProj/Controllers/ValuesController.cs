using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace MyWebProj.Controllers
{
    public class ValuesController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
                           {
                               Content = new ByteArrayContent(Encoding.ASCII.GetBytes("Hello World!")),
                           };
        }
    }
}
