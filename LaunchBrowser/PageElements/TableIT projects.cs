using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchBrowser.PageElements
{
    public class TableIT_projects
    {
        private IWebDriver _driver;

        public TableIT_projects(IWebDriver driver) => _driver = driver;

        public List<itProjectTableRows> GetRows()
        {
            var tableRows = _driver.FindElements(By.XPath("//th[text()='Name']//following::tr"));

            List<itProjectTableRows> itProjectTable = new List<itProjectTableRows>();

            for (int i = 0; i < tableRows.Count; i++)
            {
                itProjectTableRows add = new itProjectTableRows();
                add.name = tableRows[i].FindElement(By.XPath(".//td[1]"));
                add.budget = tableRows[i].FindElement(By.XPath(".//td[2]"));
                if (!(string.IsNullOrEmpty(add.name.Text) && string.IsNullOrEmpty(add.budget.Text)))
                {
                    itProjectTable.Add(add);
                }
            }
            return itProjectTable;
        }
    }
    public class itProjectTableRows
    {
        public IWebElement name { get; set; }
        public IWebElement budget { get; set; }
        public int budgetNumber => Convert.ToInt32(budget.Text);
    }
}
