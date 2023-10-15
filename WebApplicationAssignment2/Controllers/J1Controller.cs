using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationAssignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Receive the integers of choices of food->burger,drink,side,dessert 
        /// Output the total calories by adding the calories of each choices
        /// </summary>
        /// <param name="burger">The input integer of choice of burger</param>
        /// <param name="drink">The input integer of choice of drink</param>
        /// <param name="side">The input integer of choice of side</param>
        /// <param name="dessert">The input integer of choice of dessert</param>
        /// <returns>The total calories of all the choice by adding the calories of each choices</returns>
        /// <example>
        /// Get api/J1/Menu/1/2/3/4 -> Your total calorie count is 691
        /// Get api/J1/Menu/0/0/0/0 -> Your total calorie count is 0
        /// Get api/J1/Menu/4/3/2/2 -> Your total calorie count is 441
        /// </example>


        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int burgercalories= 0;
            int drinkcalories=0;
            int sidecalories=0;
            int dessertcalories = 0;

            int totalCalories = 0;
            string message = "";

            if (burger==1)
            {
                burgercalories = 461;
            }
            else if (burger == 2)
            {
                burgercalories = 431;
            }
            else if (burger == 3)
            {
                burgercalories = 420;
            }
            else
            {
                burgercalories = 0;
            }

            if (drink == 1)
            {
                drinkcalories = 130;
            }
            else if (drink == 2)
            {
                drinkcalories = 160;
            }
            else if(drink == 3)
            {
                drinkcalories = 118;
            }
            else
            {
                drinkcalories = 0;
            }

            if (side == 1)
            {
                sidecalories = 100;
            }
            else if (side == 2)
            {
                sidecalories = 57;
            }
            else if (side == 3)
            {
                sidecalories = 70;
            }
            else
            {
                sidecalories = 0;
            }

            if (dessert == 1)
            {
                dessertcalories = 167;
            }
            else if (dessert == 2)
            {
                dessertcalories = 266;
            }
            else if (dessert == 3)
            {
                dessertcalories = 75;
            }
            else
            {
                dessertcalories = 0;
            }
            totalCalories = burgercalories + drinkcalories + sidecalories + dessertcalories;
            message = "Your total calorie count is " + totalCalories;
            return message;
        }
    }
}
