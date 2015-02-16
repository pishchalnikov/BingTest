using OpenQA.Selenium;

namespace BingTest
{
    class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetFirstLine()
        {
            return driver.FindElement(By.CssSelector("#b_results > li:nth-child(1)")).Text;
        }
    }
}