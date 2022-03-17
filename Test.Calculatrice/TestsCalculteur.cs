using Caclutlatrice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Calculatrice
{
    [TestClass]
    public class TestsCalculteur
    {
        [TestMethod]
        //Method + Entée + Comportement
        public void Add_ChaineVide_RetourneZero()
        {
            int resultat = Calculateur.Add("");
            Assert.AreEqual(0, resultat);
        }
    }
}
