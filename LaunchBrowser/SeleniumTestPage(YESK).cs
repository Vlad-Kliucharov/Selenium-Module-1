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
            IWebElement searchElement = driver.FindElement(By.XPath("//*[contains(text(),'Поиск элементов на странице')]"));
            searchElement.Click();
            IWebElement goToArticle = driver.FindElement(By.XPath("//*[contains(text(),'CONTROLS PAGE')]"));
            goToArticle.Click();
            IWebElement selectButtonQA = driver.FindElement(By.Name("qa"));
            selectButtonQA.Click();
            IWebElement selectButtonBA = driver.FindElement(By.Name("ba"));
            selectButtonBA.Click();
            IWebElement selectRadioLess1 = driver.FindElement(By.Id("lessone"));
            selectRadioLess1.Click();
            IWebElement selectMore5 = driver.FindElement(By.Id("morefive"));
            selectMore5.Click();
        }
    }
}