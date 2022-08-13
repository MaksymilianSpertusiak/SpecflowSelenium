using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TestAutomation.Helpers;
using OpenQA.Selenium.Chrome;

namespace TestAutomation.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private ScenarioContext _scenarioContext;
        private IWebDriver driver;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Settings.InitializeSettings();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _scenarioContext["driver"] = driver = DriverContext.SelectDriver(Settings.browser);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Dispose();
            _scenarioContext.Clear();
        }
    }
}
