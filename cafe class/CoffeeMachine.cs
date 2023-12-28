using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cafe_class
{
    internal class CoffeeMachine
    {
        int water=500;
        int coffee=500;
        int milk=500;
        int chocolate=500;


        public CoffeeMachine()
        {
            water = 500;
            coffee = 500;

        }
       public bool makeBlackCoffee()
        {
            if (water >= 300 && coffee >= 20)
            {
                water = water - 300;
                coffee = coffee - 20;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool makeLatte()
        {
            if (water >= 300 && coffee >= 20 && milk >= 10)
            {
                water = water - 300;
                coffee = coffee - 20;
                milk = milk - 10;
                 return true;
            }
             
            else
            {
            return false;
            }

        } 

        public bool makechocolate()
        {
            if (water >= 300 && coffee >= 20 && chocolate >= 20)
            {
                water = water - 300;
               chocolate = chocolate - 20;
                return true;
            }

            else
            {
                return false;
            }

        }
        public bool makemocha()
        {
            if (water >= 300 && coffee >= 20 && chocolate >= 10)
            {
                water = water - 300;
                coffee = coffee - 20;
                chocolate= chocolate - 10;
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
