using ClassLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TP3classTest
{
    
    
    /// <summary>
    ///Classe de test pour FrenchLeague1PointSystemTest, destinée à contenir tous
    ///les tests unitaires FrenchLeague1PointSystemTest
    ///</summary>
    [TestClass()]
    public class FrenchLeague1PointSystemTest
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
        ///Test pour Constructeur FrenchLeague1PointSystem
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLib.dll")]
        public void FrenchLeague1PointSystemConstructorTest()
        {
            FrenchLeague1PointSystem_Accessor target = new FrenchLeague1PointSystem_Accessor();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour GetPointsFromMatch
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLib.dll")]
        public void GetPointsFromMatchTest()
        {
            FrenchLeague1PointSystem_Accessor target = new FrenchLeague1PointSystem_Accessor(); // TODO: initialisez à une valeur appropriée
            Match m = null; // TODO: initialisez à une valeur appropriée
            bool IsHome = false; // TODO: initialisez à une valeur appropriée
            PointSystem.ITotal expected = null; // TODO: initialisez à une valeur appropriée
            PointSystem.ITotal actual;
            actual = target.GetPointsFromMatch(m, IsHome);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour InitialPoints
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLib.dll")]
        public void InitialPointsTest()
        {
            FrenchLeague1PointSystem_Accessor target = new FrenchLeague1PointSystem_Accessor(); // TODO: initialisez à une valeur appropriée
            PointSystem.ITotal actual;
            actual = target.InitialPoints;
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }

        /// <summary>
        ///Test pour Instance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLib.dll")]
        public void InstanceTest()
        {
            FrenchLeague1PointSystem_Accessor actual;
            actual = FrenchLeague1PointSystem_Accessor.Instance;
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
