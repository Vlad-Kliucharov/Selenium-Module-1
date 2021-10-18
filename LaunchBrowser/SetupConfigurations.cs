using LaunchBrowser.PageMapping;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace LaunchBrowser
{
    public abstract class SetupConfigurations : BasePage
    {
        public SetupConfigurations() : base(new ChromeDriver()) { }

        [SetUp]
        public virtual void TestSetUp()
        {
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }

        public MainPage OpenHomePage()
        {
            _driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["MainPage"]);
            return new MainPage(_driver);
        }

        [TearDown]
        public virtual void ShutDown()
        {
            _driver.Quit();
        }
    }
}
