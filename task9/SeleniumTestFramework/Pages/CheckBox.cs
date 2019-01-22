using OpenQA.Selenium;

namespace SeleniumTestFramework.Pages
{
    /// <summary>
    /// Check box elements
    /// </summary>
    public class CheckBox
    {
        /// <summary>
        /// Check box button
        /// </summary>
        private readonly IWebElement _checkBoxButton = Browser.Driver.FindElement(By.ClassName("selectBooleanCheckbox"));

        /// <summary>
        /// Click on the check box button
        /// </summary>
        public void ClickOnButton()
        {
            _checkBoxButton.Click();
        }
    }
}
