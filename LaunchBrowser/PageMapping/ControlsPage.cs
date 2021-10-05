using LaunchBrowser.PageElements;
using OpenQA.Selenium;


namespace LaunchBrowser.PageMapping
{
    public class ControlsPage : BasePage
    {
        public ControlsPage(IWebDriver driver) : base(driver) { }
        private IWebElement GoToControlsPage => driver.FindElement(By.XPath("//a[contains(text(),'CONTROLS PAGE')]"));
        public ControlsPage OpenontrolsPage()
        {
            GoToControlsPage.Click();
            return new ControlsPage(driver);
        }
        public void TableRawsValue()
        {
            var itTableResult = new TableITprojects(driver);
            itTableResult.FilterValueItTable();
        }
    }
}
