using OpenQA.Selenium;

namespace Dev9
{
    /// <summary>
    /// Operates with login page
    /// </summary>
    public class LoginPage
    {
        IWebDriver driver;
        public string Email { get; set; }
        public string Password { get; set; }
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        /// <summary>
        /// Enter data into textboxes
        /// Press login button to enter service 
        /// </summary>
        public void Login ()
        {
            IWebElement emailTextBox = driver.FindElement(By.Id("email"));
            IWebElement passWordTextBox = driver.FindElement(By.Id("pass"));
            IWebElement loginButton = driver.FindElement(By.Id("login_button"));

            emailTextBox.Clear();
            passWordTextBox.Clear();

            emailTextBox.SendKeys(Email);
            passWordTextBox.SendKeys(Password);
            loginButton.Click();
        }
    }
}
