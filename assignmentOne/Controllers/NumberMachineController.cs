using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignmentOne.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// This method returns a string that contains 4 math equations.
        /// <example>GET: api/numbermachine/int</example>
        /// </summary>
        /// <param name="id">input number for math questions</param>
        /// <returns>
        ///Here is an addition: 33
        ///A multiplication: 69
        ///A subtraction: 3
        ///And last a division: 11</returns>
        public IEnumerable<string>Get(int id)
        {
            int add = id + 10;
            int multi = id * 3;
            int sub = id - 20;
            int div = id / 2;
            return new string[] { "Here is an addition: " + add, "A multiplication: " + multi, "A subtraction: " + sub, "And last a division: " + div };

        }
 
      
    }
}