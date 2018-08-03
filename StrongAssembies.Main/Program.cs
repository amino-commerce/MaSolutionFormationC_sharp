using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrongAssemblies.Library;

namespace StrongAssembies.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La somme de 10 et 5 est " + Calculateur.Ajouter(5, 10));
        }
    }
}
