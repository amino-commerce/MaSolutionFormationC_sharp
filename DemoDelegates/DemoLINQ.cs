using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegates
{
    class DemoLINQ
    {
        static void Main(string[] args)
        {
            IEnumerable<string> participants = new List<string> { "Mohamed Amine", "Khalil", "Abesalam", "Othman", "Oussama", "Ahmed" };

            var anonyme = new { Id = 100, Nom = "PC" };
            var filtres_extension_style = participants.Where(p => p.StartsWith("A"));
            var filtres_query_style = from p in participants where p.StartsWith("A")
                                      select new { NOm = p, Entreprise = "ODDO"};




            //var vs dynamic
            //var i = 111;
            //dynamic val = 111; 
        }
    }
}
