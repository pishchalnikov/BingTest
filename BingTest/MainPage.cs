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
    }
}