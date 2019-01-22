using OpenQA.Selenium;


namespace SeleniumTestFramework.Pages
{
    /// <summary>
    /// Login page elements
    /// </summary>
    public class LoginPage
    {
        /// <summary>
        /// LogIn Table
        /// </summary>
        private readonly IWebElement _loginTable = Browser.Driver.FindElement(By.Id("login"));

        /// <summary>
        /// LogIn button
        /// </summary>
        private readonly IWebElement _submitButton = Browser.Driver.FindElement(By.ClassName("commandExButton"));

        /// <summary>
        /// Enter the login fields and click the login button
        /// </summary>
        /// <param name="password"></param>
        /// <param name="login"></param>
        public void Login (string password,string login)
        {
            IWebElement loginField = _loginTable.FindElement(By.Id("login"));
            IWebElement passwordField = _loginTable.FindElement(By.Id("password"));
            loginField.SendKeys(login);
            passwordField.SendKeys(password);
            _submitButton.Click();
        }

    }
}
