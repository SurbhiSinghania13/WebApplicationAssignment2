using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationAssignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Recieve integers representing the number of sides on the first and second die
        /// Output the total number of ways it can role the value 10
        /// </summary>
        /// <param name="m">Input integer representing the number of sides on the first die</param>
        /// <param name="n">Input integer representing the number of sides on the second die</param>
        /// <returns>Total number of ways the first and second die role the value 10</returns>
        /// <example>
        /// Get api/J2/DiceGame/6/8 -> There are 5 ways to get the sum 10
        /// Get api/J2/DiceGame/8/9 -> There are 8 ways to get the sum 10
        /// Get api/J2/DiceGame/3/3 -> There are 0 ways to get the sum 10
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int total_ways = 0;
            string message ="";
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(i + j == 10)
                    {
                        total_ways ++;
                    }
                }
                message = "There are " + total_ways + " ways to get the sum 10";
            }
            return message;
        }
    }
}
