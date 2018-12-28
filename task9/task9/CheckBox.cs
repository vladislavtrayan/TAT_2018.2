using System;
using OpenQA.Selenium;
namespace task9
{
    public class CheckBox
    {
        public CheckBox()
        {
        }
        private IWebElement button = Browser.Driver.FindElement(By.ClassName("selectBooleanCheckbox"));
        public void ClickOnButton()
        {
            button.Click();
        }
    }
}
