using System.Collections.Generic;
using OpenQA.Selenium;

namespace Dev9
{
    /// <summary>
    /// Operates with message page
    /// </summary>
    public class MessagePage
    {
        IWebDriver driver;
        public List<IWebElement> Messages { get; set; };

        public MessagePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        /// <summary>
        /// find messages button by id
        /// press on it
        /// </summary>
        public void SwitchToMessagePage ()
        {
            IWebElement messageButton = driver.FindElement(By.Id("l_msg"));
            messageButton.Click();
        }
        /// <summary>
        /// find unread messages button by id
        /// press on it
        /// </summary>
        public void SelectUnreadMessages ()
        {
            IWebElement unreadMesseges = driver.FindElement(By.Id("ui_rmenu_unread"));
            unreadMesseges.Click();
        }
        /// <summary>
        /// Find dialogs by id
        /// write all the messages into list
        /// </summary>
        public void FindMessages ()
        {
            IWebElement dialogElements = driver.FindElement(By.Id("im_dialogs"));
            var dialogs = dialogElements.FindElements(By.ClassName("nim-dialog--cw"));
            foreach (var i in dialogs)
            {
                Messages.Add(i);
            }
        }
    }
}
