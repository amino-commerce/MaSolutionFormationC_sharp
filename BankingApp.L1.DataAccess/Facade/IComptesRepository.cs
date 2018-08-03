
using BankingApp.L0.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L1.DataAccess.Facade
{
    public interface IComptesRepository
    {
        // CRUD
        void OuvrirCompte(Compte o); // Create du CRUD
        Compte FindById(string id); // R CRUD
        IEnumerable<Compte> FindAll(); //Un autre R
        void Update(Compte c); // U
        void Delete(string id);
    }
}
