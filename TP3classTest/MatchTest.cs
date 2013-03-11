using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TP3classTest
{
    
    
    /// <summary>
    ///Classe de test pour MatchTest, destinée à contenir tous
    ///les tests unitaires MatchTest
    ///</summary>
    [TestClass()]
    public class MatchTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour GetGoals Home
        ///</summary>
        [TestMethod()]
        public void GetGoalsTestHome()
        {
            Match target = new Match(new Club("Bordeaux"), new Club("Marseille"));
            target.HomeGoals = 1;
            Assert.AreEqual(1, target.GetGoals(true));
        }

        /// <summary>
        ///Test pour GetGoals Away
        ///</summary>
        [TestMethod()]
        public void GetGoalsTestAway()
        {
            Match target = new Match(new Club("Bordeaux"), new Club("Marseille"));
            target.AwayGoals = 2;
            Assert.AreEqual(2, target.GetGoals(false));
        }
        /// <summary>
        ///Test pour GetGoals Away and home
        ///</summary>
        [TestMethod()]
        public void GetGoalsTestAwayAndHome()
        {
            Match target = new Match(new Club("Bordeaux"), new Club("Marseille"));
            target.AwayGoals = 2;
            target.HomeGoals = 1;
            Assert.AreEqual(2, target.GetGoals(false));
            Assert.AreEqual(1, target.GetGoals(true));

        }


        /// <summary>
        ///Test pour Away
        ///</summary>
        [TestMethod()]
        public void AwayTest()
        {
            Match target = new Match(new Club ("Bordeaux"), new Club ("Marseille"));
            Assert.AreEqual("Marseille", target.Away.ToString());
        }

        /// <summary>
        ///Test pour AwayGoals
        ///</summary>
        [TestMethod()]
        public void AwayGoalsTest()
        {
            Match target = new Match(new Club("Bordeaux"), new Club("Marseille"));
            target.AwayGoals = 3;
            Assert.AreEqual(3, target.AwayGoals);
        }

        /// <summary>
        ///Test pour Home
        ///</summary>
        [TestMethod()]
        public void HomeTest()
        {
            Match target = new Match(new Club("Bordeaux"), new Club("Marseille"));
            Assert.AreEqual("Bordeaux", target.Home.ToString());
        }

        /// <summary>
        ///Test pour HomeGoals
        ///</summary>
        [TestMethod()]
        public void HomeGoalsTest()
        {
            Match target = new Match(new Club("Bordeaux"), new Club("Marseille"));
            target.HomeGoals = 3;
            Assert.AreEqual(3, target.HomeGoals);
        }

        /// <summary>
        ///Test pour IsAwayForfeit
        ///</summary>
        [TestMethod()]
        public void IsAwayForfeitTest()
        {
            Match target = new Match(new Club("Bordeaux"), new Club("Marseille"));
            target.IsAwayForfeit = true;
            Assert.IsTrue(target.IsAwayForfeit);
           
        }

        /// <summary>
        ///Test pour IsDraw
        ///</summary>
        [TestMethod()]
        public void IsDrawTest()
        {
            Match target = new Match(new Club("Bordeaux"), new Club("Marseille"));
            target.HomeGoals = 2;
            target.AwayGoals = 2;
            Assert.IsTrue(target.IsDraw);
        }
        

        /// <summary>
        ///Test pour IsHomeForfeit
        ///</summary>
        [TestMethod()]
        public void IsHomeForfeitTest()
        {
            Match target = new Match(new Club("Bordeaux"), new Club("Marseille"));
            target.IsHomeForfeit = true;
            Assert.IsTrue(target.IsHomeForfeit);
        }
    }
}
