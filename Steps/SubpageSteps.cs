using TechTalk.SpecFlow;
using TestAutomation.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Spertusiak.Steps
{
    [Binding]
    public sealed class SubpageSteps
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly SubPage subpage;

        public SubpageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            subpage = new SubPage((IWebDriver)_scenarioContext["driver"]);
        }

        [Then(@"(.*) subpage is opened")]
        public void ThenSubpageIsOpened(string subpageName)
        {
            Assert.IsTrue(subpage.IsSubpageVisible(subpageName), $"{subpageName} subpage isn't opened!!!");
        }

        [When(@"Click (.*) button")]
        public void WhenClickButton(string buttonName)
        {
            subpage.ClickButton(buttonName);
        }


        [Then(@"""(.*)"" validation error is displayed")]
        public void ThenValidationErrorIsDisplayed(string errorMessage)
        {
            Assert.IsTrue(subpage.IsValidationErrorVisible(errorMessage), $"Validation error: {errorMessage} isn't displayed");
        }

        [When(@"Populate Contact form using following data")]
        public void WhenPopulateContactFormUsingFollowingData(Table table)
        {
            foreach(var row in table.Rows)
            {
                foreach(var fieldName in row.Keys)
                {
                    subpage.PopulateField(fieldName, row[fieldName]);
                }
            }
        }


    }
}
