using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumQuiz.login
{
    internal class logIn : basePage
    {
        By loginButton = By.XPath("//*[text()=' Signup / Login']");
        By userEmail = By.XPath("//input[@data-qa='login-email']");
        By userPassword = By.XPath("//input[@data-qa='login-password']");
        By logInToAccountButton = By.XPath("//button[@data-qa='login-button']");
        By logOutTheUser = By.XPath("//i[@class='fa fa-lock']");

        public void userLogIn(string emailOfUser, string passwordOfUser)
        {
            Click(loginButton);
            Write(userEmail, emailOfUser);
            Write(userPassword, passwordOfUser);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@".\\Screenshot4.png", ScreenshotImageFormat.Png);
            Click(logInToAccountButton);
           
        }
        public void logout()
        {
            Click(logOutTheUser);
        }
    }
}
