using LaunchBrowser.PageMapping;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchBrowser
{
    class PageСourseWebDriver 
    {
        private IWebDriver _driver;

        public PageСourseWebDriver(IWebDriver driver) => _driver = driver;

        private IWebElement SearchElements => _driver.FindElement(By.XPath("//*[contains(text(),'Поиск элементов на странице')]"));

        public PageControlPage clickSearchElements()
        {
            SearchElements.Click();
            return new PageControlPage(_driver);
        }
    }

}
