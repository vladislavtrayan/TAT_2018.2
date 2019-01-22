using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestFramework
{
    /// <summary>
    /// Operates with driver
    /// </summary>
    public class Browser
    {
        public static IWebDriver Driver { get; set; }
        public static bool Initialised { get; set; }

        /// <summary>
        /// Initialise Driver
        /// </summary>
        public static void Initialise ()
        {
            Driver = new ChromeDriver();
            Initialised = true;
        }

        public static void Quit ()
        {
            Driver.Quit();
            Initialised = false;
        }
    }
}
