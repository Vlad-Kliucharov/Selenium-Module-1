using OpenQA.Selenium;
using System;


namespace LaunchBrowser.PageMapping
{
    class PageControlPage : BasePage
    {

        public PageControlPage(IWebDriver driver) : base(driver) { }
        private IWebElement controlsPage => driver.FindElement(By.XPath("//a[contains(text(),'CONTROLS PAGE')]"));

        public void clickControlsPage()
        {
            controlsPage.Click();
        }
    }
}
