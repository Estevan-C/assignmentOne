using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignmentOne.Controllers
{
    public class GreetingController : ApiController
    {

        /// <summary>
        /// This method returns a string from a Get request.
        /// <example>GET: api/greeting</example>
        /// </summary>
        /// <returns>Hello World!</returns>
        public string Get()
        {
            return "Hello World!";
        }
    }
}