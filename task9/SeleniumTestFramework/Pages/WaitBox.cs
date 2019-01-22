using OpenQA.Selenium;

namespace SeleniumTestFramework.Pages
{
    /// <summary>
    /// WaitBox elements
    /// </summary>
    public class WaitBox
    {
        /// <summary> Accept button for this form </summary>
        private readonly IWebElement _acceptButton = Browser.Driver.FindElement(By.ClassName("CommandExButton"));

        /// <summary>
        /// Click the accept button
        /// </summary>
        public void ClickOnButton ()
        {
            _acceptButton.Click();
        }
    }
}
