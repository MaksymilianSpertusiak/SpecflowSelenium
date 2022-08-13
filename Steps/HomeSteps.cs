using TechTalk.SpecFlow;
using TestAutomation.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Spertusiak.Steps
{
    [Binding]
    public sealed class HomeSteps
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly HomePage homePage;

        public HomeSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            homePage = new HomePage((IWebDriver)_scenarioContext["driver"]);
        }

        [Then(@"Main header equals (.*)")]
        public void ThenMainHeaderEquals(string expectedValue)
        {
            Assert.AreEqual(expectedValue, homePage.GetMainHeaderContent(), $"Main header isn't equal to {expectedValue}.");
        }

    }
}
