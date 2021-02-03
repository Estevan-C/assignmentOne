using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignmentOne.Controllers
{
    public class GreetingsController : ApiController
    {

        /// <summary>
        /// This method returns a string containing the number that was enter.
        /// <example> GET: api/greetings/int </example>
        /// </summary>
        /// <param name="id">input number for how many people there are</param>
        /// <returns>Greetings to 3 people</returns> 
        public string Get(int id)
        {
            return "Greetings to " + id + " people";
        }
      
    }
}