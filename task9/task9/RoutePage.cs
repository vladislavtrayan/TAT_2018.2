using System;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace task9
{
    public class RoutePage
    {

        public void SetFrom (string str)
        {
            IWebElement from = Browser.Driver.FindElement(By.Id("viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:textDepStat"));
            from.SendKeys(str);
        }

        public string GetFrom()
        {
            IWebElement from = Browser.Driver.FindElement(By.Id("viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:textDepStat"));
            return from.Text;
        }
        public void SetTo(string str)
        {
            IWebElement to = Browser.Driver.FindElement(By.Id("viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:textArrStat"));
            to.SendKeys(str);
        }
        public void SetDate (string str)
        {
            IWebElement dateField 
            = Browser.Driver.FindElement(By.Id("viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:dob"));
            dateField.Clear();
            dateField.SendKeys(str);
        }
        public void PressOnDateTrigger ()
        {
            IWebElement dateTrigger
            = Browser.Driver.FindElement(By.ClassName("ui-datepicker-trigger"));
            dateTrigger.Click();
        }
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
            neededTime1.Click();
        }
        public bool OnlyElectronicRegistration ()
        {
            IWebElement checkBox = Browser.Driver.FindElement(By.Id("viewns_Z7_9HD6HG80NOK1E0ABJMNO3H30S1_:form1:onlyER:form1:onlyER"));
            checkBox.Click();

            if (checkBox.Enabled)
            {
                return true; 
            }
            return false;
        }
        /*public void  SetPassengersInfo (int man, int woman , int kids)
        { 

        }*/
        public void PressNext ()
        {
            //var fields = Browser.Driver.FindElement(By.ClassName("fields"));
            IWebElement button = Browser.Driver.FindElement(By.ClassName("commandExButton"));
            button.Click();
        }
        public void PressBreak ()
        {
            //var fields = Browser.Driver.FindElement(By.ClassName("fields"));
            IWebElement button = Browser.Driver.FindElement(By.ClassName("commandExRedButton"));
            button.Click();
        }
    }
}
    