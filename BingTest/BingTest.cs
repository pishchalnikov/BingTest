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
    }
}