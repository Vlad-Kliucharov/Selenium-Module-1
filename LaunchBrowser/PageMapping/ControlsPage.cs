using LaunchBrowser.PageElements;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace LaunchBrowser.PageMapping
{
    public class ControlsPage : BasePage
    {
        public ControlsPage(IWebDriver driver) : base(driver) { }
        private IWebElement GoToControlsPage => driver.FindElement(By.XPath("//a[contains(text(),'CONTROLS PAGE')]"));
        public ControlsPage OpenControlsPage()
        {
            GoToControlsPage.Click();
            return new ControlsPage(driver);
        }
        public void TableRawsValue()
        {
            var itTableResult = new TableITprojects(driver);
            itTableResult.FilterValueItTable();
        }
        private IWebElement QACheckBox => driver.FindElement(By.Name("qa"));
        private IWebElement DEVCheckBox => driver.FindElement(By.Name("dev"));
        private IWebElement BACheckBox => driver.FindElement(By.Name("ba"));
        private IWebElement PMCheckBox => driver.FindElement(By.Name("pm"));
        public ControlsPage AssertsForCheckBox()
        {
            Assert.AreEqual(false, QACheckBox.Selected, "Check box 'QA Engineer' is selected – Assert Failed");
            QACheckBox.Click();
            Assert.AreEqual(true, QACheckBox.Selected, "Check box 'QA Engineer' is not selected – Assert Failed");

            Assert.AreEqual(false, DEVCheckBox.Selected, "Check box  '.NET Developer' is selected – Assert Failed");

            Assert.AreEqual(false, BACheckBox.Selected, "Check box 'Business analyst' is selected – Assert Failed");
            BACheckBox.Click();
            Assert.AreEqual(true, BACheckBox.Selected, "Check box 'Business analyst' is not selected – Assert Failed");

            Assert.AreEqual(false, PMCheckBox.Selected, "Check box 'Project Manager' is selected – Assert Failed");

            return new ControlsPage(driver);
        }
        private IWebElement LessoneRadioButton => driver.FindElement(By.Id("lessone"));
        private IWebElement MorefiveRadioButton => driver.FindElement(By.Id("morefive"));
        public ControlsPage AssertsForRadioBattons()
        {
            Assert.AreEqual(false, LessoneRadioButton.Selected, "Radio button 'Less than 1' is selected – Assert Failed");
            LessoneRadioButton.Click();
            Assert.AreEqual(true, LessoneRadioButton.Selected, "Radio button 'Less than 1' is not selected – Assert Failed");

            Assert.AreEqual(false, MorefiveRadioButton.Selected, "Radio button 'More than 5' is selected – Assert Failed");
            MorefiveRadioButton.Click();
            Assert.AreEqual(true, MorefiveRadioButton.Selected, "Radio button 'More than 5' is not selected – Assert Failed");

            return new ControlsPage(driver);
        }
        private IWebElement CheckProgressBar => driver.FindElement(By.ClassName("elementor-counter-number"));
        public ControlsPage WaitForLoader()
        {
            WebDriverWait waitLoadPersantage = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitLoadPersantage.Until(ExpectedConditions.TextToBePresentInElement(CheckProgressBar, "100"));

            return new ControlsPage(driver);
        }
    }
}
