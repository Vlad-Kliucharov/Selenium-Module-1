using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchBrowser.PageMapping
{
    class MainPage : BasePage
    {
        public MainPage (IWebDriver driver) : base(driver) { }
        public MainPage NavigateMainPage()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["MainPage"]);
            return new MainPage(driver);
        }
    }
}
