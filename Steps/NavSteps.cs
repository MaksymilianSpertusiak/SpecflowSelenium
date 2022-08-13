using TechTalk.SpecFlow;
using TestAutomation.Pages;
using OpenQA.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace Spertusiak.Steps
{
    [Binding]
    public sealed class NavSteps
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly NavbarPage navbarPage;

        public NavSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            navbarPage = new NavbarPage((IWebDriver)_scenarioContext["driver"]);
        }

        [Then(@"Following navbar elements are visible")]
        public void ThenCheckNavbarElements(Table table)
        {
            foreach (var row in table.Rows)
            {
                Assert.IsTrue(navbarPage.IsNavbarElementVisible(row["ElementName"]), $"Navbar element: {row["ElementName"]} isn't visible!!!");
            }
        }

        [When(@"Click (.*) button from navbar")]
        public void WhenClickButtonFromNavbar(string buttonName)
        {
            navbarPage.ClickNavbarButton(buttonName);
        }



    }
}
