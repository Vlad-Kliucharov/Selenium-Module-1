using LaunchBrowser.PageMapping;
using OpenQA.Selenium;
using System.Configuration;

namespace LaunchBrowser
{
    class PageСourseWebDriver : BasePage
    {
        public PageСourseWebDriver(IWebDriver driver) : base(driver) { }

        private IWebElement SearchElements => driver.FindElement(By.XPath("//*[contains(text(),'Поиск элементов на странице')]"));

        public ControlsPage clickSearchElements()
        {
            SearchElements.Click();
            return new ControlsPage(driver);
        }
    }

}
