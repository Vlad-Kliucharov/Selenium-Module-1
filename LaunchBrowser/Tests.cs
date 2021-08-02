using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomateWiki
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void WikipediaSearchTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            IWebElement searchField = driver.FindElement(By.Id("searchInput"));
            searchField.SendKeys("Selenium");
            IWebElement searchButton = driver.FindElement(By.XPath("//i[text()='Search']"));
            searchButton.Click();
        }
    }
}
