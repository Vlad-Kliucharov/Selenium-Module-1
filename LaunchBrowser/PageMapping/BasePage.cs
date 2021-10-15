using LaunchBrowser.PageElements;
using OpenQA.Selenium;
using System.Configuration;

namespace LaunchBrowser.PageMapping
{
    public class BasePage
    {
        public static IWebDriver _driver;
        public MainMenu Menu => new MainMenu(_driver);
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
