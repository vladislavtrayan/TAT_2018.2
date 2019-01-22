using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Dev9
{
    /// <summary>
    /// Log in VK
    /// Find unread messages
    /// OutPut them in console
    /// </summary>
    class MainClass
    {
        public static void  Main(string[] args)
        {
            IWebDriver driver;
            string email;
            string password;

            driver = new ChromeDriver();
            email = "login";
            password = "password";

            driver.Url = "https://vk.com/login";
            driver.Manage().Window.Maximize();

            LoginPage loginPage = new LoginPage(driver);
            loginPage.Email = email;
            loginPage.Password = password;
            loginPage.Login();

            MessagePage messagePage = new MessagePage(driver);
            messagePage.SwitchToMessagePage();
            messagePage.SelectUnreadMessages();
            messagePage.FindMessages();

            List<IWebElement> messages = new List<IWebElement>();

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
