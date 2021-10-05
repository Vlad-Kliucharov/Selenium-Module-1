using LaunchBrowser.PageElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Configuration;

namespace LaunchBrowser.PageMapping
{
    public class MainPage : BasePage
    {
        public MainPage (IWebDriver driver) : base(driver) { }
        private IWebElement ElementMenuAllArticles => driver.FindElement(By.Id("menu-item-130"));
        private IWebElement GoToSubMenuCourseWebriver => driver.FindElement(By.Id("menu-item-470"));
        public WebDriverPage ClickOnCourseWebriver()
        {
            Actions HoverToAllArticles = new Actions(driver);
            HoverToAllArticles.MoveToElement(ElementMenuAllArticles).MoveToElement(GoToSubMenuCourseWebriver).Click().Build().Perform();
            return new WebDriverPage(driver);
        }
        public WebDriverPage OpenCourseWebriver()
        {
            GoToSubMenuCourseWebriver.Click();
            return new WebDriverPage(driver);
        }
    }
}
