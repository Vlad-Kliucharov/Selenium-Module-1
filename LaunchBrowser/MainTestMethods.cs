using NUnit.Framework;

namespace LaunchBrowser
{
    [TestFixture]
    class MainTestMethods : SetupConfigurations
    {
        [TestCase(TestName = "Check 'ImplicitWait' on 'Control Page' for percentage")]
        [Category(Categories.Regression)]
        public void ExecutionOfTestMethods()
        {
            //var rows = ctrPage.Table.GetRows();
            OpenHomePage().ClickOnCourseWebriver().ClickSearchElements().OpenControlsPage();
        }

        [TestCase(TestName = "Check-Box and Radio button validations on 'Control Page'")]
        [Category(Categories.Validation)]
        public void ContorPageValidation()
        {
            //TODO: Use Menu.MainPage();
            OpenHomePage().ClickOnCourseWebriver().ClickSearchElements().OpenControlsPage().AssertsForCheckBox().AssertsForRadioBattons().WaitForLoader();
        }
    }
}
