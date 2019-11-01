using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarteLibrairie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarteLibrairie.Model;

namespace CarteGame.Tests
{
    [TestClass()]
    public class MainTests
    {
        [TestMethod()]
        public void MainTest()
        {
            Assert.Fail();
        }

        //[TestMethod()]
        //public void deposerReussiTest()
        //{
        //    Carte carte1 = new Carte(couleur: Couleur.CARREAU, valeur: Valeur.TROIS);
        //    Carte carte2 = new Carte(couleur: Couleur.TREFLE, valeur: Valeur.DAME);
        //    Carte carte3 = new Carte(couleur: Couleur.COEUR, valeur: Valeur.HUIT);
        //    Carte carte4 = new Carte(couleur: Couleur.PIQUE, valeur: Valeur.AS);
        //    Main maMain = new Main();
        //    maMain += carte1;
        //    maMain += carte2;
        //    maMain += carte3;
        //    maMain += carte4;
        //    Carte[] c = new Carte[] { carte1, carte2 }; 
        //    CollectionAssert.AreEqual(maMain.Deposer(carte1, carte2),c);
        //}
        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException), "Cartes ne sont pas presents dans la main")]
        //public void DeposerFailTest()
        //{

        //    Carte carte1 = new Carte(couleur: Couleur.CARREAU, valeur: Valeur.TROIS);
        //    Carte carte2 = new Carte(couleur: Couleur.TREFLE, valeur: Valeur.DAME);
        //    Carte carte3 = new Carte(couleur: Couleur.COEUR, valeur: Valeur.HUIT);
        //    Carte carte4 = new Carte(couleur: Couleur.PIQUE, valeur: Valeur.AS);
        //    Main maMain = new Main();
        //    maMain += carte1;
        //    maMain += carte2;
           
        //    Carte[] c = new Carte[] { carte1, carte2 };
        //    maMain.Deposer(carte3, carte4);

        //}


        //[TestMethod()]
        //public void ToStringTest()
        //{
           
        //    Main maMain = new Main();
        //    maMain += new Carte(couleur: Couleur.CARREAU, valeur: Valeur.TROIS);
        //    maMain += new Carte(couleur: Couleur.TREFLE, valeur: Valeur.DAME);
        //    maMain += new Carte(couleur: Couleur.TREFLE, valeur: Valeur.DAME);

        //    String expected = $"Voici ta main \n 3 de {Couleur.CARREAU} \nDame de {Couleur.TREFLE} \n";
        //    Assert.AreEqual(maMain.ToString(), expected);
        //}
        /*[TestMethod]
        public void TestIndexerGetterFound()
        {

            Carte carte1 = new Carte(couleur: Couleur.CARREAU, valeur: Valeur.TROIS);
            Main maMain = new Main();
            maMain += carte1;


            Assert.AreEqual(carte1, maMain[Valeur.TROIS, Couleur.CARREAU]);


        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Message de l'indexer get  pour Carte  avec la valeur 4" +
            " et la couleur CARREAU n'existe pas dans la liste")]
        public void TestIndexerGetterNoFound()
        {
            Carte carte1 = new Carte(couleur: Couleur.CARREAU, valeur: Valeur.TROIS);

            Main maMain = new Main();
            maMain += carte1;
            Carte carte2 = maMain[valeur: Valeur.QUATRE, couleur: Couleur.CARREAU];
            System.ArgumentException(message)



        }*/
        [TestMethod]
        public void TestCarteConstructor()
        {
            Carte c = new Carte(Couleur.COEUR, Valeur.AS);
            Assert.IsTrue( c.Valeur == Valeur.AS && c.Couleur == Couleur.COEUR);
        }

        [TestMethod]
        public void TestCarteToSring()
        {
            Carte c = new Carte(Couleur.NOIR, Valeur.JOKER);
            Assert.AreEqual(c.ToString(), "JOKER-NOIR");
        }

        [TestMethod]
        public void TestComparableSameCarte()
        {
            Carte c = new Carte(Couleur.NOIR, Valeur.JOKER);
            Assert.IsTrue(c.CompareTo(new Carte(Couleur.NOIR, Valeur.JOKER)) == 0);
        }
        [TestMethod]
        public void TestComparableWithBiggerCarte()
        {
            Carte c = new Carte(Couleur.COEUR, Valeur.NEUF);
            Assert.IsTrue(c.CompareTo(new Carte(Couleur.COEUR, Valeur.DEUX)) == -1);
        }
        [TestMethod]
        public void TestComparableWithSmallerCarte()
        {
            Carte c = new Carte(Couleur.COEUR, Valeur.NEUF);
            Assert.IsTrue(c.CompareTo(new Carte(Couleur.COEUR, Valeur.HUIT)) == 1);
        }

        //[TestMethod]
        //public void TestPaquetConstructor()
        //{
        //    Paquet p = new Paquet();
        //    Assert.IsTrue(p.cartes.Count == 54);
        //}


        [TestMethod]
        public void TestPaquetTirer()
        {
            Paquet p = new Paquet();

            Assert.AreEqual(p.Tirer() ,new Carte(Couleur.TREFLE,Valeur.TROIS));
        }
        //[TestMethod]
        //public void TestPaquetBrasser()
        //{
        //    Paquet p = new Paquet();
        //    p.Brasser();
        //    Assert.AreNotEqual(p.cartes.First(), new Carte(Couleur.TREFLE, Valeur.TROIS));
        //}
        //[TestMethod]
        //public void TestPaquetEchanger()
        //{
        //    Paquet p = new Paquet();
        //    Carte c1 = p.cartes.First();
            
        //    p.Echanger(0, 1);
        //    Assert.AreNotEqual(p.cartes.First(),c1 );
        //}
        //[TestMethod]
        //public void TestPaquetAjouter()
        //{
        //    Paquet p = new Paquet();
        //    Carte c1 = p.cartes.First();

        //    p.Ajouter(c1);
        //    Assert.IsTrue(p.cartes.Count == 55);
        //}











    }
}