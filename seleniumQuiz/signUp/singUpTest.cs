using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace seleniumQuiz.signUp
{
    [TestClass]
    public class singUpTest : basePage
    {
        signUpPage signUpPageObj = new signUpPage();
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
        [TestMethod]
        public void signUpTest001()
        {

            signUpPageObj.createUser("kamran", "kamran5@gmail.com", "6616463584", "8", "8", "1996", "kamran", "asif", "lahore", "lahore", "India", "India", "lahore", "lahore", "lahore", "lahore");
        }
        [TestMethod]
        public void varef()
        {

            signUpPageObj.varefed();
        }
    }
}
