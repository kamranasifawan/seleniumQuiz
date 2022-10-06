using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace seleniumQuiz.login
{
    [TestClass]
    public class logInTest : basePage
    {
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
        }
        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
        }
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
        }
        [ClassCleanup()]
        public static void ClassCleanup()
        {
        }
        [TestInitialize()]
        public void TestInit()
        {
            basePage browser = new basePage();
            IWebDriver driver1 = browser.openBrowser("Chrome");
            driver = driver1;
            OpenUrl("https://www.automationexercise.com/");
        }
        [TestCleanup()]
        public void TestCleanUp()
        {
            Thread.Sleep(5000);
            basePage.CloseDriver();
        }
        logIn logInObj = new logIn();
        [TestMethod]
        public void userLogInTestMethod()
        {
            logInObj.userLogIn("kamran1@gmail.com", "6616463584");
        }
        [TestMethod]
        public void logoutTestMethod2()
        {
            logInObj.userLogIn("kamran1@gmail.com", "6616463584");
            logInObj.logout();
        }
    }
}
