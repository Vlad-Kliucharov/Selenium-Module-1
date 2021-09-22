using OpenQA.Selenium;

namespace LaunchBrowser.PageMapping
{
    class ContactsPage : BasePage
    {
        public ContactsPage(IWebDriver driver) : base(driver) {}

        public void pageContactsPage()
        {
            Menu.PageContacts();
        } 
    }
}
