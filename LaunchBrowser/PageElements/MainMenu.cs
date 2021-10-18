using LaunchBrowser.PageMapping;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace LaunchBrowser.PageElements
{
    public class MainMenu
    {
        private IWebDriver _driver;
        public MainMenu(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement AllArticlesElementMenu => _driver.FindElement(By.Id("menu-item-130"));
        private IWebElement CourseWebriverElementMenu => _driver.FindElement(By.Id("menu-item-470"));

        private void HoverAllArticles()
        {
            Actions HoverToAllArticles = new Actions(_driver);
            HoverToAllArticles.MoveToElement(AllArticlesElementMenu).Perform();
        }
        public WebDriverPage GoToCourseWebriverPage()
        {
            HoverAllArticles();
            CourseWebriverElementMenu.Click();
            return new WebDriverPage(_driver);
        }
    }
}