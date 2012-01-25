using Ppc.GeneratePassword;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RandomCharsTest
{
    
    
    /// <summary>
    ///Это класс теста для RandomCharsTest, в котором должны
    ///находиться все модульные тесты RandomCharsTest
    ///</summary>
    [TestClass()]
    public class RandomCharsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
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

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для Generate
        ///</summary>
        [TestMethod()]
        public void GenerateTest()
        {
            int length = 0;  
            string actual;
            string str = string.Empty;
            actual = RandomChars.Generate(length);
            Assert.AreEqual<Int32>(0,actual.Length,("not equal"));

            length = 1;
            actual = RandomChars.Generate(length);
            Assert.AreEqual<Int32>(1, actual.Length, ("not equal"));

            length = 15;
            actual = RandomChars.Generate(length);
            Assert.AreEqual<Int32>(15, actual.Length, ("not equal"));

            length = 1024;
            actual = RandomChars.Generate(length);
            Assert.AreEqual<Int32>(1024, actual.Length, ("not equal"));

            length = -1;
            actual = RandomChars.Generate(length);
            Assert.AreEqual<Int32>(-1, actual.Length, ("not equal"));

            length = -10;
            actual = RandomChars.Generate(length);
            Assert.AreEqual<Int32>(-10, actual.Length, ("not equal"));


        }
    }
}
