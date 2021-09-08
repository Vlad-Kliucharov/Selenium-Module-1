using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchBrowser.PageMapping
{
    class BasePage
    {
        private IWebDriver _driver;

        public BasePage(IWebDriver driver) => _driver = driver;

        public void mainPage()
        {
            _driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }

    }
}
