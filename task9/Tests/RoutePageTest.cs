using NUnit.Framework;
using System;
using SeleniumTestFramework;
using SeleniumTestFramework.Pages;

namespace Tests
{
    [TestFixture()]
    public class RoutePageTest
    {
        [SetUp]
        public void SetUp()
        {
            Browser.Initialise();
            Browser.Driver.Navigate().GoToUrl("https://poezd.rw.by/wps/portal/home/rp/schedule");
            Browser.Driver.Manage().Window.Maximize();
            Browser.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [TearDown]
        public void TearDown()
        {   
            Browser.Driver.Quit();
        }

        [Test()]
        [TestCase("Минск","")]
        [TestCase("", "Минск")]
        [TestCase("Володя","Иркутск")]
        [TestCase("", "")]
        public void NextPageIfNotAllFieldsAreRight(string from,string to)
        {
            Pages.RoutePage.SetFrom(from);
            Pages.RoutePage.SetTo(to);
            Pages.RoutePage.PressNext();

            Assert.IsTrue(WarIconChecker.IsRedImage());
        }

        [Test()]
        [TestCase("Минск", "Брест")]
        [TestCase("Барановичи", "Минск")]
        [TestCase("Гомель", "Борисов")]
        public void NextPageIfAllFieldsAreRight(string from, string to)
        {
            Pages.RoutePage.SetFrom(from);
            Pages.RoutePage.SetTo(to);
            Pages.RoutePage.PressNext();

            Assert.IsFalse(WarIconChecker.IsRedImage());
        }

        [Test()]
        [TestCase("13.14.2019")]
        [TestCase("32.11.2018")]
        [TestCase("12.11.1654")]
        public void NextPageIfDataIsNotRight(string data)
        {
            Pages.RoutePage.SetDate(data);
            Pages.RoutePage.PressNext();

            Assert.IsTrue(WarIconChecker.IsRedImage());
        }

        [Test()]
        public void ElectronicRegistrationOnlyIsClickable()
        {
            Assert.IsTrue(Pages.RoutePage.OnlyElectronicRegistration());
        }

        [Test()]
        public void BreakButtonIsClickable()
        {
            Pages.RoutePage.SetFrom("wewew");
            Pages.RoutePage.PressBreak();
            Assert.AreEqual("", Pages.RoutePage.GetFrom());
        }
    }
}
