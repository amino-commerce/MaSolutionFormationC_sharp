using System;
using ComptesApp.Library.Implementations;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oddo.Domain;

namespace ComptesApp.Library.Tests
{
    [TestClass]
    public class UnitTestComptesManagerImplMemory
    {


        [TestMethod()]
        public void FindByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void OuvrirCompteTest()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE

            var underTest = new ComptesManagerImpl_Memory();
            var expected = new Compte { Numero = "C1000", Proprietaire = "Zakaria", Solde = 1000M}; // number of existings accounts
            var id = "C1000";

            //ACT

            var actual = underTest.FindById(id);

            /*foreach (var item in actual)
            {
                Console.WriteLine(item.Proprietaire);
            }*/
            //ASSERT

            Assert.AreEqual(expected, actual);
        }
    }
}
