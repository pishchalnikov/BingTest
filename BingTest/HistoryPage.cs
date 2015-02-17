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
    }
}
