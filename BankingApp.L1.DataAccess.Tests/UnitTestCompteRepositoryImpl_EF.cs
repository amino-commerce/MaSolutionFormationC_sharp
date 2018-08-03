using System;
using BankingApp.L0.Domain;
using BankingApp.L1.DataAccess.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingApp.L1.DataAccess.Tests
{
    [TestClass]
    public class UnitTestCompteRepositoryImpl_EF
    {
        [TestMethod]
        public void TestOuvrirCompte()
        {
            //ARRANGE


            var c = new Compte { Numero = "C200", Proprietaire = "Zakaria", Solde = 200M };
            var underTest = new ComptesRepositoryImpl_EF();
            //ACT

            underTest.OuvrirCompte(c);

            //ASSERT
            //Si on arrive ici avec success, ce que c'est bon

        }

        [TestMethod]
        public void TestFindById_Nominal()
        {
            var id = "C100";
            //ARRANGE


            var expeced = new Compte { Numero = "C100", Proprietaire = "Mohamed Amine", Solde = 100M };
            var underTest = new ComptesRepositoryImpl_EF();
            //ACT

            var actual = underTest.FindById(id);

            //ASSERT
            //Si on arrive ici avec success, ce que c'est bon
            Assert.AreEqual(expeced, actual);
        }

        [TestMethod]
        public void TestFindById_Degrade()
        {
            //ARRANGE
            var id = "Z100";
            
            var underTest = new ComptesRepositoryImpl_EF();
            //ACT

            var actual = underTest.FindById(id);

            //ASSERT
            //Si on arrive ici avec success, ce que c'est bon
            Assert.IsNull(actual);
        }
    }
}
