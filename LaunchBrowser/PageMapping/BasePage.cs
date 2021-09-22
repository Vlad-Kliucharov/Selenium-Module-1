using OpenQA.Selenium;

namespace LaunchBrowser.PageMapping
{

    public class MainMenu
        {
            private IWebDriver _driver;
            public MainMenu(IWebDriver driver)
            {
                _driver = driver;
            }
            public void PageMain()
            {
                _driver.Navigate().GoToUrl("https://yesk.com.ua/");
            }
            public void PageAboutMe()
            {
                _driver.Navigate().GoToUrl("https://yesk.com.ua/705ea-about/");
            }
            public void PageArticles()
            {
                _driver.Navigate().GoToUrl("https://yesk.com.ua/705ea-blog/");
            }
            public void PageContacts()
            {
                _driver.Navigate().GoToUrl("https://yesk.com.ua/705ea-contact/");
            }
            public void PageStudying()
            {
                _driver.Navigate().GoToUrl("https://yesk.com.ua/automation-learning/");
            }
        }
    public class BasePage
    {
        protected IWebDriver driver;

        private MainMenu _menu;
        public MainMenu Menu => _menu;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            _menu = new MainMenu(driver);
        }
    }
}
