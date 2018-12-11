using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace VkLogin
{
    /// <summary>
    /// Log in Vk
    /// Find unread messages 
    /// output messages to console
    /// </summary>
    class VkLogin
    {
        IWebDriver driver;
        string email;
        string password;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            email = "email";
            password = "password";
        }

        [Test]
        public void test()
        {
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

            for (int i = 0;i < 100; i++)
            {
                Thread.Sleep(100);
                try
                {
                    if (driver.FindElement(By.Id("side_bar")).Displayed)
                    {
                        break;
                    }
                }catch 
                {
                    continue;
                }
            }

            IWebElement messageButton = driver.FindElement(By.Id("l_msg"));
            messageButton.Click();

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                try
                {
                    if (driver.FindElement(By.Id("im_dialogs")).Displayed)
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

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                try
                {
                    if (driver.FindElement(By.Id("im_dialogs")).Displayed)
                    {
                        break;
                    }
                }
                catch
                {
                    continue;
                }
            }

            IWebElement dialogElements =  driver.FindElement(By.Id("im_dialogs"));
            var messages = dialogElements.FindElements(By.ClassName("nim-dialog"));
            foreach (var i in messages)
            {
                Console.WriteLine(i.Text);
                Console.WriteLine();
            }
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}