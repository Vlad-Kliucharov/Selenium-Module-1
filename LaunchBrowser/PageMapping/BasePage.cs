using LaunchBrowser.PageElements;
using OpenQA.Selenium;
using System.Configuration;

namespace LaunchBrowser.PageMapping
{
    public class BasePage
    {
        private MainMenu _mainMenu;

        protected IWebDriver driver;
        public MainMenu Menu => _mainMenu;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            _mainMenu = new MainMenu(driver);
        }
    }
}
