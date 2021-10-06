using LaunchBrowser.PageMapping;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace LaunchBrowser.PageElements
{
    public class MainMenu
    {
        private IWebDriver _driver;
        public MainMenu(IWebDriver driver) {
            _driver = driver;
        }
        private IWebElement ElementMenuAllArticles => _driver.FindElement(By.Id("menu-item-130"));
        public void HoverAllArticles()
        {
            Actions HoverToAllArticles = new Actions(_driver);
            HoverToAllArticles.MoveToElement(ElementMenuAllArticles).Perform();
        }
        public IWebElement OpenContacs => _driver.FindElement(By.Id("menu-item-135"));
        public ContactsPage GoToContacs()
        {
            return new ContactsPage(_driver);
        }
        public IWebElement OpenMainPage => _driver.FindElement(By.Id("menu-item-129"));
        public MainPage GoToMainPage()
        {
            return new MainPage(_driver);
        }
        public MainMenu Menu => new MainMenu(_driver);
    }
}