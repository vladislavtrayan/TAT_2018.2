using System;
using OpenQA.Selenium;

namespace task9
{
    static class WarIconChecker
    {
        static public bool RedImageChecker()
        {
            try
            {
                IWebElement nopd = Browser.Driver.FindElement(By.ClassName("nopd"));
                if (Browser.Driver.FindElement(By.CssSelector("span.warIcon")).Displayed)
                {
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
