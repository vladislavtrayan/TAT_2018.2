using OpenQA.Selenium;


namespace SeleniumTestFramework.Pages
{
    /// <summary>
    /// Route page elements
    /// </summary>
    public class RoutePage
    {
        private readonly IWebElement _departureField = Browser.Driver.FindElement(By.Id("viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:textDepStat"));
        private readonly IWebElement _destinationField = Browser.Driver.FindElement(By.Id("viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:textArrStat"));
        private readonly IWebElement _dateField = Browser.Driver.FindElement(By.Id("viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:dob"));
        private readonly IWebElement _dateTriggerButton = Browser.Driver.FindElement(By.ClassName("ui-datepicker-trigger"));
        private readonly IWebElement _onlyElectronicRegistration = Browser.Driver.FindElement(By.Id("viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:onlyER:form1:onlyER"));
        private readonly IWebElement _nextButton = Browser.Driver.FindElement(By.ClassName("commandExButton"));
        private readonly IWebElement _breakButton = Browser.Driver.FindElement(By.ClassName("commandExRedButton"));


        /// <summary>
        /// Fill departure box
        /// </summary>
        /// <param name="str"></param>
        public void SetFrom (string str)
        {
            _departureField.SendKeys(str);
        }

        /// <summary>
        /// Return information from departure box
        /// </summary>
        /// <returns></returns>
        public string GetFrom()
        {
            return _departureField.Text;
        }

        /// <summary>
        /// Fill the destination box
        /// </summary>
        /// <param name="str"></param>
        public void SetTo(string str)
        {
            _destinationField.SendKeys(str);
        }

        /// <summary>
        /// Fill the date box
        /// </summary>
        /// <param name="str"></param>
        public void SetDate (string str)
        {
            _dateField.Clear();
            _dateField.SendKeys(str);
        }

        /// <summary>
        /// Click on date trigger
        /// </summary>
        public void PressOnDateTrigger ()
        {
            _dateTriggerButton.Click();
        }

        /// <summary>
        /// Choose departure time from / to
        /// </summary>
        /// <param name="time1">departure time - from </param>
        /// <param name="time2">departure time - to </param>
        public void ChooseTime (int time1 , int time2)
        {
            string str1 = "";
            string str2 = "";
            str1 += time1;
            str2 += time2;
            var timeTrigger
            = Browser.Driver.FindElement(By.ClassName("time"));
            IWebElement firstTime = timeTrigger.FindElement(By.Id("0"));
            firstTime.Click();
            IWebElement neededTime1 = timeTrigger.FindElement(By.Id(str1));
            neededTime1.Click();
            IWebElement neededTime2 = timeTrigger.FindElement(By.Id(str2));
            neededTime2.Click();
        }

        /// <summary>
        /// Click on only electronic registration button
        /// </summary>
        /// <returns>return the actual position of button</returns>
        public bool OnlyElectronicRegistration ()
        {
            _onlyElectronicRegistration.Click();

            if (_onlyElectronicRegistration.Enabled)
            {
                return true; 
            }
            return false;
        }

        /// <summary>
        /// Click "next" button
        /// </summary>
        public void PressNext ()
        {
            _nextButton.Click();
        }

        /// <summary>
        /// Click "break" button
        /// </summary>
        public void PressBreak ()
        {
            _breakButton.Click();
        }
    }
}
    