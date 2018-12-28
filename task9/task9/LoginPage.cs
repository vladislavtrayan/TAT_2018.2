using System;
using OpenQA.Selenium;
namespace task9
{
    public class LoginPage
    {
        public LoginPage()
        {
        }

        private IWebElement loginTable = Browser.Driver.FindElement(By.Id("login"));
        private IWebElement submitButton = Browser.Driver.FindElement(By.ClassName("commandExButton"));

        public void Login (string password,string login)
        {
            IWebElement loginField = loginTable.FindElement(By.Id("login"));
            IWebElement passwordField = loginTable.FindElement(By.Id("password"));
            loginField.SendKeys(login);
            passwordField.SendKeys(password);
            submitButton.Click();
        }

    }
}
