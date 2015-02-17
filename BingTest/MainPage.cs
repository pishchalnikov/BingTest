using OpenQA.Selenium;

namespace BingTest
{
    class MainPage
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public SearchPage Search(string text)
        {
            driver.FindElement(By.Id("sb_form_q")).SendKeys(text);
            driver.FindElement(By.Id("sb_form_go")).Click();
            return new SearchPage(driver);
        }

        public MainPage Main()
        {
            driver.FindElement(By.ClassName("b_logoArea")).Click();
            return new MainPage(driver);
        }

        public HistoryPage History()
        {
            driver.FindElement(By.CssSelector("a[href*='history']")).Click();
            return new HistoryPage(driver);
        }
    }
}