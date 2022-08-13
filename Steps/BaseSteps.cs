using TechTalk.SpecFlow;
using TestAutomation.Pages;
using TestAutomation.Helpers;
using OpenQA.Selenium;

namespace Spertusiak.Steps
{
    [Binding]
    public sealed class BaseSteps
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly BasePage basePage;
        private readonly HomePage homePage;

        public BaseSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            basePage = new BasePage((IWebDriver)_scenarioContext["driver"]);
            homePage = new HomePage((IWebDriver)_scenarioContext["driver"]);
        }

        [Given(@"Open application homepage")]
        public void GivenOpenAppHomepage()
        {
            basePage.OpenUrl(Settings.homeUrl);
        }

        [Given(@"Open website using url: (.*)")]
        public void GivenOpenUrl(string url)
        {
            basePage.OpenUrl(url);
        }

        [Then(@"Application homepage is opened")]
        public void ThenApplicationHomepageIsOpened()
        {
            homePage.WaitForHomepage();
        }

    }
}
