using LaunchBrowser.PageMapping;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace LaunchBrowser
{
    public abstract class SetupConfigTest : BasePage
    {
        public SetupConfigTest() : base(new ChromeDriver())
        {}

        [SetUp]
        public virtual void TestSetUp() 
        {
            //driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
        }

        [TearDown]
        public virtual void ShutDown()
        {
            driver.Quit();
        }
    }
}
