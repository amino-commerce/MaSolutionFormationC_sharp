using BankingApp.L1.DataAccess.Facade;
using BankingApp.L1.DataAccess.Implementations;
using BankingApp.L2.Business.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.L2.Business.Implementations
{
    public class ComptesBusinessImpl : ICompteBusiness
    {
        public const decimal TAUX = 0.1M;


        //private IComptesRepository repo; = new ComptesRepositoryImpl_EF();

        private IComptesRepository repo;

        public ComptesBusinessImpl(IComptesRepository repo) { this.repo = repo; }

        public decimal ConsulterCompte(string id)
        {
            var result = repo.FindById(id);
            if (result != null)
            {
                //supposons qu'une regle metier stipule que les comptes commencent par un 'E'
                // sont des comptes eparges et que le tauc d'epage est de 10 %
                return (result.Numero.StartsWith("C")) ? result.Solde * (1 + TAUX) : result.Solde;
            }
            else
                return decimal.MinValue;
        }
    }
}
