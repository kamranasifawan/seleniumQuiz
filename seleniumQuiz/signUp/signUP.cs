using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumQuiz.signUp
{
    public class signUpPage : basePage
    {
        By name = By.XPath("//*[@data-qa=\"signup-name\"]");
        By email = By.XPath("//*[@data-qa='signup-email']");
        By button = By.XPath("//*[text()=' Signup / Login']");
        By signUpbutton = By.XPath("//*[@data-qa='signup-button']");
        By genderButton = By.XPath("//input[@id='id_gender1']");
        By newPassword = By.XPath("//input[@id='password']");
        By birthDate = By.Id("days");
        By birthMonth = By.Id("months");
        By birthYear = By.Id("years");
        By newsLetter = By.XPath("//input[@id='newsletter']");
        By firstNameOfUser = By.XPath("//input[@id='first_name']");
        By lastNameOfUser = By.XPath("//input[@id='last_name']");
        By companyName = By.XPath("//input[@id='company']");
        By addressOne = By.XPath("//input[@id='address1']");
        By addressTwo = By.XPath("//input[@id='address2']");
        By countryName = By.Id("country");
        By stateName = By.XPath("//input[@id='state']");
        By cityName = By.XPath("//input[@id='city']");
        By zipCode = By.XPath("//input[@id='zipcode']");
        By mobileNumber = By.XPath("//input[@id='mobile_number']");
        By createAnAccountButton = By.XPath("//button[@data-qa='create-account']");
        By continueButton = By.XPath("//a[@data-qa='continue-button']");
        By GetText = By.XPath("//b[text()='kamran asif']");

        public void createUser(string userName, string userEmail, string enterPassword, string date, string month, string year, string firtName,
        string lastName, string nameOfCompany, string address1, string address2, string country, string nameOfState, string nameOfCity,
        string codeZip, string numberMobile)
        {
            IsElementPresent(button);
            Click(button);
            IsElementTextField(name);
            Write(name, userName);
            IsElementTextField(email);
            Write(email, userEmail);
            Click(signUpbutton);
            readeoButton(genderButton);
            Write(newPassword, enterPassword);
            dropDown(birthDate, date);
            dropDown(birthMonth, month);
            dropDown(birthYear, year);
            ScrollToElement(companyName);
            checkBox(newsLetter);
            Write(firstNameOfUser, firtName);
            Write(lastNameOfUser, lastName);
            Write(companyName, nameOfCompany);
            ScrollToElement(mobileNumber);
            Write(addressOne, address1);
            Write(addressTwo, address2);
            dropDown(countryName, country);

            Write(stateName, nameOfState);
            Write(cityName, nameOfCity);
            Write(zipCode, codeZip);
            Write(mobileNumber, numberMobile);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(@".\\Screenshot4.png", ScreenshotImageFormat.Png);
            Click(createAnAccountButton);
            Click(continueButton);
        }
        public void varefed()
        {

            AssertElement(GetText, "kamran asif");
        }
    }
}
