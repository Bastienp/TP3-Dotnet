using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TP3classTest
{
    
    
    /// <summary>
    ///Classe de test pour FrenchLeague1PointSystem_PointTotalTest, destinée à contenir tous
    ///les tests unitaires FrenchLeague1PointSystem_PointTotalTest
    ///</summary>
    [TestClass()]
    public class FrenchLeague1PointSystem_PointTotalTest
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
        ///Test pour Constructeur PointTotal
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLib.dll")]
        public void FrenchLeague1PointSystem_PointTotalConstructorTest()
        {
            FrenchLeague1PointSystem_Accessor.PointTotal target = new FrenchLeague1PointSystem_Accessor.PointTotal();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Constructeur PointTotal
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLib.dll")]
        public void FrenchLeague1PointSystem_PointTotalConstructorTest1()
        {
            Match m = null; // TODO: initialisez à une valeur appropriée
            bool home = false; // TODO: initialisez à une valeur appropriée
            FrenchLeague1PointSystem_Accessor.PointTotal target = new FrenchLeague1PointSystem_Accessor.PointTotal(m, home);
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test1 pour CompareTo
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLib.dll")]
        public void CompareToTest1()
        {
            Match m1 = new Match(new Club("Bordeaux"), new Club("Marseille"));
            m1.AwayGoals = 1;
            m1.HomeGoals = 3;
            FrenchLeague1PointSystem frenchRules = FrenchLeague1PointSystem.Instance;
            PointSystem.ITotal pointTotal1 = frenchRules.GetPointsFromMatch(m1, true);

            Match m2 = new Match(new Club("Paris"), new Club("Lens"));
            m2.AwayGoals = 2;
            m2.HomeGoals = 1;
            PointSystem.ITotal pointTotal2 = frenchRules.GetPointsFromMatch(m2, true); 

            Assert.AreEqual(1, pointTotal1.CompareTo(pointTotal2)); //Home de M1 gagne (+1 points) Home de M2 perd (+0 points), donc la différence est égale ) 1.
        }


        /// <summary>
        ///Test2 pour CompareTo
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLib.dll")]
        public void CompareToTest2()
        {
            Match m1 = new Match(new Club("Bordeaux"), new Club("Marseille"));
            m1.AwayGoals = 1;
            m1.HomeGoals = 3;
            FrenchLeague1PointSystem frenchRules = FrenchLeague1PointSystem.Instance;
            PointSystem.ITotal pointTotal1 = frenchRules.GetPointsFromMatch(m1, true);

            Match m2 = new Match(new Club("Paris"), new Club("Lens"));
            m2.AwayGoals = 2;
            m2.HomeGoals = 4;
            PointSystem.ITotal pointTotal2 = frenchRules.GetPointsFromMatch(m2, true);

            Assert.AreEqual(0, pointTotal1.CompareTo(pointTotal2)); //Egalité de points et égalité de goalaverage, la différence est donc de 0.
        }



     

        /// <summary>
        ///Test pour Increment
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLib.dll")]
        public void IncrementTest()
        {
            FrenchLeague1PointSystem frenchRules = FrenchLeague1PointSystem.Instance;


            
            Match m1 = new Match(new Club("Bordeaux"), new Club("Marseille"));
            m1.AwayGoals = 1;
            m1.HomeGoals = 3;
            PointSystem.ITotal pointTotal1 = frenchRules.GetPointsFromMatch(m1, true); //1

            Match m2 = new Match(new Club("Paris"), new Club("Lens"));
            m2.AwayGoals = 2;
            m2.HomeGoals = 3;
            PointSystem.ITotal pointTotal2 = frenchRules.GetPointsFromMatch(m2, true); //1


            pointTotal1.Increment(pointTotal2); //2



            Match m3 = new Match(new Club("test"), new Club("test1"));
            m2.AwayGoals = 2;
            m2.HomeGoals = 2;
            PointSystem.ITotal pointTotal3 = frenchRules.GetPointsFromMatch(m3, true); //0 ==> Crée pour comparer avec 0.*/

           

            Assert.AreEqual(2, pointTotal1.CompareTo(pointTotal3)); //CompareTo = pointTotal1 - pointTotal2 = 2 - 0 = 2




            
        }

        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLib.dll")]
        public void ToStringTest()
        {
            FrenchLeague1PointSystem_Accessor.PointTotal target = new FrenchLeague1PointSystem_Accessor.PointTotal(); // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
