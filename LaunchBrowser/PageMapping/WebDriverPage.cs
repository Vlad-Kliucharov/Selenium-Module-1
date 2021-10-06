using LaunchBrowser.PageMapping;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace LaunchBrowser
{
    public class WebDriverPage : BasePage
    {
        public WebDriverPage(IWebDriver driver) : base(driver) { }
        private IWebElement SearchElements => driver.FindElement(By.XPath("//*[contains(text(),'Поиск элементов на странице')]"));
        private IWebElement HoverQAAULabel => driver.FindElement(By.ClassName("qaautomation"));
        public void HoverOnQaautomationLable()
        {
            Actions HoverToAllArticles = new Actions(driver);
            HoverToAllArticles.MoveToElement(HoverQAAULabel).Perform();
        }
        public ControlsPage ClickSearchElements()
        {
            SearchElements.Click();
            return new ControlsPage(driver);
        }
    }
}
