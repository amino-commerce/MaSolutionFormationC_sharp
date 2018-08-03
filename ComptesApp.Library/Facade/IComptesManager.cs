using Oddo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptesApp.Library.Facade
{
    public interface IComptesManager
    {
        // CRUD
        void OuvrirCompte(Compte o); // Create du CRUD
        Compte FindById(string id); // R CRUD
        IEnumerable<Compte> FindAll(); //Un autre R
        void Update(Compte c); // U
        void Delete(string id);
    }
}
