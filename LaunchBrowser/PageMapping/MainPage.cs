using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace LaunchBrowser.PageMapping
{
    public class MainPage : BasePage
    {
        public MainPage (IWebDriver driver) : base(driver) { }
        private IWebElement ElementMenuAllArticles => _driver.FindElement(By.Id("menu-item-130"));
        private IWebElement GoToSubMenuCourseWebriver => _driver.FindElement(By.Id("menu-item-470"));
        public WebDriverPage ClickOnCourseWebriver()
        {
            Actions HoverToAllArticles = new Actions(_driver);
            HoverToAllArticles.MoveToElement(ElementMenuAllArticles).MoveToElement(GoToSubMenuCourseWebriver).Click().Build().Perform();
            return new WebDriverPage(_driver);
        }
        public WebDriverPage OpenCourseWebriver()
        {
            GoToSubMenuCourseWebriver.Click();
            return new WebDriverPage(_driver);
        }
    }
}
