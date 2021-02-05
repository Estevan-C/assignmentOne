using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace assignmentOne.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// This method gets the square of a number.
        /// <example>GET: api/square/int</example>
        /// </summary>
        /// <param name="num">input number for square</param>
        /// <returns>10 will return 100</returns>
        public int Get(int num)
        {
            return num * num;
        }

      
    }
}
