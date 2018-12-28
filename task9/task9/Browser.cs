using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace task9
{
    public class Browser
    {
        public Browser()
        {
        }
        public static IWebDriver Driver { get; set; }
        public static bool Initialised { get; set; }

        public static void Initialise ()
        {
            Driver = new FirefoxDriver("/home/vladislav/Projects/task9/task9");
            Initialised = true;
         }
        public static void Quit ()
        {
            Driver.Quit();
            Initialised = false;
        }
    }
}
