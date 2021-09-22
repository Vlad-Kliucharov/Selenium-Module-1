using OpenQA.Selenium;


namespace LaunchBrowser.PageMapping
{
    class ControlsPage : BasePage
    {
        public ControlsPage(IWebDriver driver) : base(driver) { }
        private IWebElement controlsPage => driver.FindElement(By.XPath("//a[contains(text(),'CONTROLS PAGE')]"));

        public void clickControlsPage()
        {
            controlsPage.Click();
        }
    }
}
