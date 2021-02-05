using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignmentOne.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// This method returns 3 strings containg the Cost, Tax, and Total of the service
        /// <example>GET: api/hostingcost/int </example>
        /// </summary>
        /// <param name="id">input number for how long you will use the service</param>
        /// <returns> 
        /// 3 fortnight at 5.50/FN = $16.5 CAD 
        /// HST at 13% = 2.14 CAD 
        /// Total = 18.64 CAD
        /// </returns>
        public IEnumerable<string> Get(int id)
        {
            
            double cost = id + 1;
            double costTwo = cost / 14; 
            double costThree = Math.Ceiling(costTwo);
            double costFour =  5.50 * costThree;
            string messageOne = costThree + " fortnight at 5.50/FN = $" + costFour +" CAD";
            // This math gets the correct amount for cost, and place the results in a string. 

            double hst = 0.13 * costFour;
            double hstTwo = Math.Round((Double)hst, 2);
            string messageTwo = " HST at 13% = " + hstTwo + " CAD";
            // This math gets the correct amount for tax, and place the results in a string. 

            double total = costFour + hstTwo;
            double totalTwo = Math.Round((Double)total, 2);
            string messageThree = " Total = " + totalTwo + " CAD";
            // This math gets the final total, and place the results in a string. 

            return new string[] {messageOne, messageTwo, messageThree };
            
        }
      
    }
}
