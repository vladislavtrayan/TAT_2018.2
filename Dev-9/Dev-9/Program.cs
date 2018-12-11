using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;


namespace Dev9
{
    class MainClass
    {
        public static void  Main(string[] args)
        {
            IWebDriver driver;
            string email;
            string password;

            driver = new FirefoxDriver();
            email = "login";
            password = "password";

            driver.Url = "https://vk.com/login";
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                try
                {
                    if (driver.FindElement(By.Id("login_button")).Displayed)
                    {
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }
            driver.Manage().Window.Maximize();

            IWebElement emailTextBox = driver.FindElement(By.Id("email"));
            IWebElement passWordTextBox = driver.FindElement(By.Id("pass"));
            IWebElement loginButton = driver.FindElement(By.Id("login_button"));

            emailTextBox.Clear();
            passWordTextBox.Clear();

            emailTextBox.SendKeys(email);
            passWordTextBox.SendKeys(password);
            loginButton.Click();

            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(100);
                try
                {
                    if (driver.FindElement(By.Id("side_bar")).Displayed)
                    {
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }

            IWebElement messageButton = driver.FindElement(By.Id("l_msg"));
            messageButton.Click();

            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(100);
                try
                {
                    if (driver.FindElement(By.Id("ui_rmenu_unread")).Displayed)
                    {
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }

            IWebElement unreadMesseges = driver.FindElement(By.Id("ui_rmenu_unread"));
            unreadMesseges.Click();

            IWebElement dialogElements = driver.FindElement(By.Id("im_dialogs"));
            var messages = dialogElements.FindElements(By.ClassName("nim-dialog--cw"));
            foreach (var i in messages)
            {
                Console.WriteLine("From : " + i.FindElement(By.ClassName("nim-dialog--name")).Text);
                Console.WriteLine("Message : " 
                                  + i.FindElement(By.ClassName("nim-dialog--text-preview")).Text 
                                  + '\n');
            }
            driver.Close();
        }

    }
}
