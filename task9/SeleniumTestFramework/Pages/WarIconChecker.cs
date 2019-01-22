using OpenQA.Selenium;

namespace SeleniumTestFramework.Pages
{
    /// <summary>
    /// Provides information if warning icon
    /// is displayed on page
    /// </summary>
    public static class WarIconChecker
    {
        /// <summary>
        /// Scan the page for war icon
        /// </summary>
        public static bool IsRedImage()
        {
            try
            {
                return (Browser.Driver.FindElement(By.CssSelector("span.warIcon")).Displayed);
            }
            catch
            {
                return false;
            }
        }
    }
}
