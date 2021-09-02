using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace LaunchBrowser
{
    public abstract class SetupConfigTest : CategoriesTest
    {
        protected IWebDriver driver;

        [SetUp]

        public virtual void TestSetUp() 
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public virtual void ShutDown()
        {
            driver.Quit();
        }
    }
}
