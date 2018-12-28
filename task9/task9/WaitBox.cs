using System;
using OpenQA.Selenium;
namespace task9
{
    public class WaitBox
    {
        public WaitBox()
        {
        }
        private IWebElement button = Browser.Driver.FindElement(By.ClassName("CommandExButton"));
        public void ClickOnButton ()
        {
            button.Click();
        }
    }
}
