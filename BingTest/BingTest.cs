using System;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace BingTest
{
    public class BingTest
    {
        private FirefoxDriver driver;

        [SetUp]
        public void SetUo()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("http://www.bing.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
		
		[Test]
        public void SearchTest()
        {
            MainPage main = new MainPage(driver);
            SearchPage search = main.Search("test");
            Assert.IsTrue(search.GetFirstLine().Contains("test"));
        }

        [Test]
        public void SearchHistory()
        {
            MainPage main = new MainPage(driver);
            SearchPage search = main.Search("test");
            main.Main();
            HistoryPage history = main.History();
            Assert.IsTrue(history.GetHistoryContainer().Contains("test"));
        }

        [Test]
        public void HistoryClear() 
        {
            MainPage main = new MainPage(driver);
            SearchPage search = main.Search("test");
            main.Main();
            HistoryPage history = main.History();
            history.ClearHistory();
            Assert.IsTrue(history.GetHistoryContainer().Contains("You've cleared all your search history."));
        }
    }
}