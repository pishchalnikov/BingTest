using OpenQA.Selenium;

namespace BingTest
{
    class HistoryPage
    {
        private IWebDriver driver;

        public HistoryPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetHistoryContainer()
        {
            return driver.FindElement(By.Id("sw_page")).Text;
        }

        public HistoryPage ClearHistory()
        {
            driver.FindElement(By.LinkText("Clear all")).Click();
            driver.FindElement(By.CssSelector("a[href*='clear']")).Click();
            return new HistoryPage(driver);
        }
    }
}
