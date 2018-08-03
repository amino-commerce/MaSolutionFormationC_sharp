using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegates
{
    //delegate void Operation(int x, int y);// Forme de la delegation

    class Program // Le délégateur
    {
        static void Main(string[] args)
        {


            // Subscription
            //Operation delegué1 = CalculUtils.Additionner;

            Action<int, int> delegué1 = CalculUtils.Additionner; // Action & Func since C#4 , 2010

            // Aother Subscription

            delegué1 += CalculUtils.Multiplier;

            // Another Subscription using a anonymous delagte since C#2, 2005
            delegué1 += delegate (int a, int b)
            {
                Console.WriteLine($"La soustraction  de {a} et {b} est egal : {a - b}");
            };

            // Another Subscription using a anonymous delagte since C#2, 2005
            delegué1 += (a,b) => // since C# 3, 2008
            {
                Console.WriteLine($"La soustraction  de {a} et {b} est egal : {a - b}");
            };

            
            //Notification
            delegué1(11, 22);
        }
    }
}
