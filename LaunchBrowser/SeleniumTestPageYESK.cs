using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace LaunchBrowser
{
    [TestFixture]

    class YeskSite
    {
        [Test]
        public void SeleniumTestPageYESK()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://yesk.com.ua/webdriver-csharp/");

            IWebElement searchElement = driver.FindElement(By.XPath("//*[contains(text(),'Поиск элементов на странице')]"));
            searchElement.Click();

            IWebElement goToArticle = driver.FindElement(By.XPath("//*[contains(text(),'CONTROLS PAGE')]"));
            goToArticle.Click();

            IWebElement selectButtonQA = driver.FindElement(By.Name("qa"));
            Assert.AreEqual(false, selectButtonQA.Selected, "Check box 'QA Engineer' is selected – Assert Failed");
            selectButtonQA.Click();
            Assert.AreEqual(true, selectButtonQA.Selected, "Check box 'QA Engineer' is not selected – Assert Failed");

            IWebElement unCheckBoxNet = driver.FindElement(By.Name("dev"));
            Assert.AreEqual(false, unCheckBoxNet.Selected, "Check box  '.NET Developer' is selected – Assert Failed");

            IWebElement selectButtonBA = driver.FindElement(By.Name("ba"));
            Assert.AreEqual(false, selectButtonBA.Selected, "Check box 'Business analyst' is selected – Assert Failed");
            selectButtonBA.Click();
            Assert.AreEqual(true, selectButtonBA.Selected, "Check box 'Business analyst' is not selected – Assert Failed");

            IWebElement unCheckBoxPM = driver.FindElement(By.Name("pm"));
            Assert.AreEqual(false, unCheckBoxPM.Selected, "Check box 'Project Manager' is selected – Assert Failed");

            IWebElement selectRadioLess1 = driver.FindElement(By.Id("lessone"));
            Assert.AreEqual(false, selectRadioLess1.Selected, "Radio button 'Less than 1' is selected – Assert Failed");
            selectRadioLess1.Click();
            Assert.AreEqual(true, selectRadioLess1.Selected, "Radio button 'Less than 1' is not selected – Assert Failed");

            IWebElement selectMore5 = driver.FindElement(By.Id("morefive"));
            Assert.AreEqual(false, selectMore5.Selected, "Radio button 'More than 5' is selected – Assert Failed");
            selectMore5.Click();
            Assert.AreEqual(true, selectMore5.Selected, "Radio button 'More than 5' is not selected – Assert Failed");
        }
    }
}