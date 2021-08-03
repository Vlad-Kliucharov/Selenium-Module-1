using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LaunchBrowser
{
    [TestFixture]

    class YeskSite
    {
        [Test]
        public void YeskTasks()
        {

            stirng queryBa = 'QA Engineer';

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://yesk.com.ua/webdriver-csharp/");

            IWebElement searchElement = driver.FindElement(By.XPath("//*[contains(text(),'Поиск элементов на странице')]")).Click();

            IWebElement goToArticle = driver.FindElement(By.XPath("//*[contains(text(),'CONTROLS PAGE')]")).Click();

            IWebElement selectButtonQA = driver.FindElement(By.Name("qa")).Click();

            IWebElement selectButtonBA = driver.FindElement(By.Name("ba")).Click();

            IWebElement selectRadioLess1 = driver.FindElement(By.Id("lessone")).Click();

            IWebElement selectMore5 = driver.FindElement(By.Id("morefive")).Click();
        }
    }
}