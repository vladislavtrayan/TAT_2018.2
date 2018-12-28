using NUnit.Framework;
using System;
namespace task9
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

            Assert.AreEqual(false, WarIconChecker.RedImageChecker());

        }

        [Test()]
        [TestCase("molodoyVlad", "2012022Trayan")]
        [TestCase("1", "2012022Trayan")]
        [TestCase("molodoyVlad", "1")]
        public void WrongLogin(string login, string password)
        {
            Pages.LoginPage.Login(password, login);

            Assert.AreEqual(true, WarIconChecker.RedImageChecker());
        }
    }
}
