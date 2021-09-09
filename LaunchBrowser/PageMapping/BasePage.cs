using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchBrowser.PageMapping
{
    public abstract class BasePage: CategoriesTest
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver) => this.driver = driver;

        public void mainPage()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }

    }
}
