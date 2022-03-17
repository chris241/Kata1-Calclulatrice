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
        [TestMethod]
        public void Add_ChaineAvecUnNombre_RetourneLeNombre()
        {
            int resultat = Calculateur.Add("1");
            Assert.AreEqual(1,resultat);
        }
        [TestMethod]
        public void Add_ChaineAvecUnAutreNombre_RetourneLeNombre()
        {
            int resultat = Calculateur.Add("2");
            Assert.AreEqual(2, resultat);
        }
        [TestMethod]
        public void Add_ChaineAvecDeuxNombres_RetourneLaSomme()
        {
            int resultat = Calculateur.Add("2,1");
            Assert.AreEqual(3, resultat);
        }
        [TestMethod]
        public void Add_ChaineAvecDeuxAutresNombres_RetourneLaSomme()
        {
            int resultat = Calculateur.Add("2,4");
            Assert.AreEqual(6, resultat);
        }
        [TestMethod]
        public void Add_ChaineAvecPlusieursNombres_RetourneLaSomme()
        {
            int resultat = Calculateur.Add("2,4,3");
            Assert.AreEqual(9, resultat);
        }
        [TestMethod]
        public void Add_ChaineAvecRetourChariotEtDeuxNombres_RetourneLaSomme()
        {
            int resultat = Calculateur.Add("1\n2");
            Assert.AreEqual(3, resultat);
        }
        [TestMethod]
        public void Add_ChaineAvecRetourChariotEtDautreNombres_RetourneLaSomme()
        {
            int resultat = Calculateur.Add("4\n2");
            Assert.AreEqual(6, resultat);
        }
        [TestMethod]
        public void Add_ChaineAvecPlusieursRetourChariotEtDautreNombres_RetourneLaSomme()
        {
            int resultat = Calculateur.Add("4\n2\n1");
            Assert.AreEqual(7, resultat);
        }
        [TestMethod]
        public void Add_ChaineAvecPlusieursRetourChariotEtQuatreNombres_RetourneLaSomme()
        {
            int resultat = Calculateur.Add("1,2\n3\n4");
            Assert.AreEqual(10, resultat);
        }
        [TestMethod]
        public void Add_ChaineAvecDelimiteurEtUnNombre_RetourneLeNombre()
        {
            int resultat = Calculateur.Add("//;\n4");
            Assert.AreEqual(4, resultat);
        }
        [TestMethod]
        public void Add_ChaineAvecDelimiteurEtDeuxNombres_RetourneLaSomme()
        {
            int resultat = Calculateur.Add("//;\n1;2");
            Assert.AreEqual(3, resultat);
        }
    }
}
