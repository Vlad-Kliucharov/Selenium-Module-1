using OpenQA.Selenium;
using System;


namespace LaunchBrowser.PageMapping
{
    class PageControlPage
    {
        private IWebDriver _driver;
        public PageControlPage(IWebDriver driver) => _driver = driver;
        private IWebElement controlsPage => _driver.FindElement(By.XPath("//a[contains(text(),'CONTROLS PAGE')]"));

        public void clickControlsPage()
        {
            controlsPage.Click();
        }
    }
}
