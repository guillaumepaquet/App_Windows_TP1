using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarteLibrairie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [TestMethod()]
        public void deposerReussiTest()
        {
            Carte carte1 = new Carte(couleur: Couleur.CARREAU, valeur: Valeur.TROIS);
            Carte carte2 = new Carte(couleur: Couleur.TREFLE, valeur: Valeur.DAME);
            Carte carte3 = new Carte(couleur: Couleur.COEUR, valeur: Valeur.HUIT);
            Carte carte4 = new Carte(couleur: Couleur.PIQUE, valeur: Valeur.AS);
            Main maMain = new Main();
            maMain += carte1;
            maMain += carte2;
            maMain += carte3;
            maMain += carte4;
            Carte[] c = new Carte[] { carte1, carte2 }; 
            CollectionAssert.AreEqual(maMain.deposer(carte1, carte2),c);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Cartes ne sont pas presents dans la main")]
        public void DeposerFailTest()
        {

            Carte carte1 = new Carte(couleur: Couleur.CARREAU, valeur: Valeur.TROIS);
            Carte carte2 = new Carte(couleur: Couleur.TREFLE, valeur: Valeur.DAME);
            Carte carte3 = new Carte(couleur: Couleur.COEUR, valeur: Valeur.HUIT);
            Carte carte4 = new Carte(couleur: Couleur.PIQUE, valeur: Valeur.AS);
            Main maMain = new Main();
            maMain += carte1;
            maMain += carte2;
           
            Carte[] c = new Carte[] { carte1, carte2 };
            maMain.deposer(carte3, carte4);

        }


        [TestMethod()]
        public void ToStringTest()
        {
           
            Main maMain = new Main();
            maMain += new Carte(couleur: Couleur.CARREAU, valeur: Valeur.TROIS);
            maMain += new Carte(couleur: Couleur.TREFLE, valeur: Valeur.DAME);
            maMain += new Carte(couleur: Couleur.TREFLE, valeur: Valeur.DAME);

            String expected = $"Voici ta main \n 3 de {Couleur.CARREAU} \nDame de {Couleur.TREFLE} \n";
            Assert.AreEqual(maMain.ToString(), expected);
        }
        [TestMethod]
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
           /* System.ArgumentException(message)*/
            

        }


    }
}