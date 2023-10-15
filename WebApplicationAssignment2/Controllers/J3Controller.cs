using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationAssignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// This question is taken from 2009 Canadian Computing Competition: Junior Division (Problem J3: Good times)
        /// Receives integer representing the time in Ottawa in 24 hour format
        /// Outputs the local time in the cities(Victoria, Edmonton, Winnipge, Toronto, Haifax, St.John) including Ottawa
        /// </summary>
        /// <param name="ottawa_time">Input integer representing the time in Ottawa in 24 hour format</param>
        /// <returns>The local time of each of the cities listed above including Ottawa</returns>
        /// <example>
        /// Get api/J3/time/1420 -> 1420 in Ottawa, 1120 in Victoria, 1220 in Edmonton, 1320 in Winnipge, 1420 in Toronto, 1520 in Halifax, 1550 in St. John's
        /// Get api/J3/time/1300 -> 1300 in Ottawa, 1000 in Victoria, 1100 in Edmonton, 1200 in Winnipge, 1300 in Toronto, 1400 in Halifax, 1430 in St. John's
        /// Get api/J3/time/1130 -> 1130 in Ottawa, 830 in Victoria, 930 in Edmonton, 1030 in Winnipge, 1130 in Toronto, 1230 in Halifax, 1260 in St. John's
        /// </example>
        [HttpGet]
        [Route("api/J3/time/{ottawa_time}")]
        //2009
        public string time(int ottawa_time)
        {
            string message = "";
            int victoria_time = ottawa_time - 300;
            int edmonton_time = ottawa_time - 200;
            int winnipeg_time = ottawa_time - 100;
            int toronto_time = ottawa_time;
            int halifax_time = ottawa_time + 100;
            int StJohn_time = ottawa_time + 130;

            message = ottawa_time + " in Ottawa, " + victoria_time + " in Victoria, " + edmonton_time + " in Edmonton, " + winnipeg_time +" in Winnipge, "
                + toronto_time + " in Toronto, " + halifax_time + " in Halifax, " + StJohn_time + " in St. John's";

            return message;
        }
        
    }
}
