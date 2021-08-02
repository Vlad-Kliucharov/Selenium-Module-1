using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace LaunchBrowser
{
    [TestFixture]
    class YeskSite
    {
        [Test]
        public void YeskTasks()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://yesk.com.ua/webdriver-csharp/");
            IWebElement searchElement = driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/div/div/div/section[6]/div/div/div[2]/div/div/div/div/h2/a"));
            searchElement.Click();
            IWebElement goToArticle = driver.FindElement(By.XPath("//*[contains(text(),'CONTROLS PAGE')]"));
            goToArticle.Click();
            IWebElement selectButtonBA = driver.FindElement(By.Name("ba"));
            selectButtonBA.Click();
        }
    }
}
