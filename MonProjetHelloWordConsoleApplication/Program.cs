using Oddo.Domain;
using System;
using System.Collections.Generic;

namespace ODDO.Clients.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>() { "", "", "" }; 
            System.Console.WriteLine("Hello Word.");
            Compte c = new Compte
            {
                Numero = "C1000",
                Proprietaire = "Amine", 
                Solde = 1000M
            }; //  Object initializer, since C# 3
            System.Console.WriteLine(c);
        }
    }
}
