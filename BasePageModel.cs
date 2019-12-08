using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Stylelabs.MQA.WebTesting.PageElements
{
    public class BasePageModel
    {
        private IWebDriver _driver;

        public IWebElement Find(By by)
        {
            return _driver.FindElement(by);
        }

        public void Hover(IWebElement btn)
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(btn).Build().Perform();
        }

        public void SetText(IWebElement txt, string text)
        {
            txt.SendKeys(text);
        }
    }
}