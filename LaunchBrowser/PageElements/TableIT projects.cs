using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LaunchBrowser.PageElements
{
    public class TableITprojects
    {
        private IWebDriver _driver;
        public TableITprojects(IWebDriver driver)
        {
            _driver = driver;
        }
        public List<itProjectTableRows> GetRows()
        {
            List<itProjectTableRows> itProjectTable = new List<itProjectTableRows>();

            var tableRows = _driver.FindElements(By.XPath("//th[text()='Name']//following::tr"));

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

        public List<itProjectTableRows> CheckBudgetsItTable()
        {
            var table = GetRows();

            var companyNameFacebook = "Facebook";
            var companyNameZoom = "Zoom";
            var checkFaceBName = table.Find(c => c.name.Text == companyNameFacebook);
            var maxBudget = table.Max(x => x.budgetNumber);
            var checkZoomVal = table.Find(z => z.name.Text == companyNameZoom);

            if (checkFaceBName == null)
            {
                throw new NotFoundException($"Can't find '{companyNameFacebook}' company shareholders table!");
            }

            if (checkZoomVal == null)
            {
                throw new NotFoundException($"Can't find '{companyNameZoom}' company shareholders table!");
            }

            Assert.That(checkFaceBName.budgetNumber, Is.EqualTo(maxBudget));
            Assert.That(checkZoomVal.budgetNumber, Is.EqualTo(11900));

            return table;
        }
    }
    public class itProjectTableRows
    {
        public IWebElement name { get; set; }
        public IWebElement budget { get; set; }
        public int budgetNumber => Convert.ToInt32(budget.Text);
    }
}
