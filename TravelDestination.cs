using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Stylelabs.MQA.WebTesting.PageElements
{
    [Binding]
    [TestFixture]

    public class TravelDestination : BasePageModel
    {
        #region
        [FindsBy(How = How.CssSelector, Using = "clear - btn - input gcw - storeable text gcw - origin gcw - required gcw - distinct - locations")]
        public IWebElement txtOrigin { get; set; }

        [FindsBy(How = How.CssSelector, Using = "clear-btn-input gcw-storeable text gcw-destination gcw-required gcw-distinct-locations")]
        public IWebElement txtDestination { get; set; }

        [FindsBy(How = How.Id, Using = "package-departing-hp-package")]
        public IWebElement lblDeparting { get; set; }

        [FindsBy(How = How.CssSelector, Using = "datepicker-cal-date start")]
        public IWebElement btnStartDate { get; set; }        

        [FindsBy(How = How.Id, Using = "package-returning-hp-package")]
        public IWebElement lblReturning { get; set; }

        [FindsBy(How = How.CssSelector, Using = "datepicker-day-number notranslate")]
        public IWebElement btnEndDate { get; set; }

        [FindsBy(How = How.CssSelector, Using = "trigger-utility menu-trigger btn-utility btn-secondary dropdown-toggle theme-standard pin-left menu-arrow gcw-component gcw-traveler-amount-select gcw-component-initialized")]
        public IWebElement btnTraveler { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='traveler - selector - hp - package']/div/ul/li/div/div/div[1]/div[2]/div[2]/button/span[1]/svg/path[1]")]
        public IWebElement btnReduceAdultNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='traveler - selector - hp - package']/div/ul/li/div/div/div[1]/div[3]/div[1]/div[4]/button/span[1]/svg")]
        public IWebElement btnIncreaseChildNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='traveler - selector - hp - package']/div/ul/li/div/div/div[1]/div[3]/div[2]/label[1]/select")]
        public IWebElement btnAge { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='traveler - selector - hp - package']/div/ul/li/div/div/div[1]/div[3]/div[2]/label[1]/select/option")]
        public IList<IWebElement> lblAge { get; set; }

        [FindsBy(How = How.Id, Using = "search-button-hp-package")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='searchWizard']/div[2]/div[1]/div/div[2]/div[1]/button")]
        public IWebElement btnsearchWizard { get; set; }

        string checkOrigin;
        #endregion

        #region
        public void SetOrigin(string origin)
        {
            SetText(txtOrigin, origin);
            txtOrigin.SendKeys(Keys.Tab);
            checkOrigin = origin;
        }

        public void SetDestination(string destination)
        {
            SetText(txtDestination, destination);
            txtOrigin.SendKeys(Keys.Tab);
        }

        public void ClickDeparting()
        {
            lblDeparting.Click();
        }

        public void SelectStartDate()
        {
            btnStartDate.Click();
        }

        public void ClickReturning()
        {
            lblReturning.Click();
        }

        public void SelectEndDate()
        {
            btnEndDate.Click();
        }

        public void ClickTraveler()
        {
            btnTraveler.Click();
        }

        public void ClickReduceAdultNumber()
        {
            btnReduceAdultNumber.Click();
        }

        public void ClickBtnIncreaseChildNumber()
        {
            btnIncreaseChildNumber.Click();
        }

        public void ClickAge()
        {
            btnAge.Click();
        }

        public void SelectAge(int age)
        {
            lblAge[age].Click();
        }

        public void ClickSearch()
        {
            btnSearch.Click();
        }

        public void CheckResult()
        {
            bool contain = btnsearchWizard.Text.Contains(checkOrigin);
            Assert.IsTrue(contain);
        }
        #endregion
    }
}
