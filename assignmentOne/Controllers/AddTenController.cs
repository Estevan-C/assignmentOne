using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignmentOne.Controllers
{
    public class AddTenController : ApiController
    {

        /// <summary>
        /// This method returns an int thats been plus by 10.
        /// <example>GET: api/addten/int</example>
        /// </summary>
        /// <param name="id">input number that will be added by 10</param>
        /// <returns>10 will return 20</returns>
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
