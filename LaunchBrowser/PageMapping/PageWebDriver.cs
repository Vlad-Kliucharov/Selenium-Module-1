using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchBrowser
{
    class PageWebDriver : SetupConfigTest
    {
        private IWebDriver _driver;

        public PageWebDriver(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement clickSearchElements => _driver.FindElement(By.XPath("//*[contains(text(),'Поиск элементов на странице')]"));

        public void SearchElements(string query)
        {
            clickSearchElements.Click();
        }
    }

}
