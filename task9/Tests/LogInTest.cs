using NUnit.Framework;
using System;
using SeleniumTestFramework;
using SeleniumTestFramework.Pages;

namespace Tests
{
    [TestFixture()]
    public class LoginTest
    {
        [SetUp]
        public void SetUp ()
        {
            Browser.Initialise();
            Browser.Driver.Navigate().GoToUrl("https://poezd.rw.by/wps/portal/home/login_main");
            Browser.Driver.Manage().Window.Maximize();
            Browser.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [TearDown]
        public void TearDown ()
        {
            Browser.Driver.Quit();
        }
        [Test()]
        [TestCase("molodayaVika", "2012022Trayan")]
        public void CorrectLogin(string login, string password)
        {
            Pages.LoginPage.Login(password,login);

            Assert.True(Browser.Driver.Url.Contains("/rp/buyTicket"));

        }

        [Test()]
        [TestCase("molodoyVlad", "molodoyVlad")]
        [TestCase(" ", "2012022Trayan")]
        [TestCase("molod0yVlad", "")]
        public void WrongLogin(string login, string password)
        {
            Pages.LoginPage.Login(password, login);

            Assert.IsFalse(Browser.Driver.Url.Contains("/rp/buyTicket"));
        }
    }
}
