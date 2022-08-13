using OpenQA.Selenium;

namespace TestAutomation.Pages
{
    public class HomePage : BasePage
    {
        private readonly By mainHeaderLocator = By.CssSelector("h1"); 
        public HomePage(IWebDriver driver) : base(driver) { }

        public void WaitForHomepage()
        {
            WaitForElement(mainHeaderLocator);
        }

        public string GetMainHeaderContent()
        {
            var mainHeader = WaitForElementToBeVisible(mainHeaderLocator);
            return mainHeader.Text;
        }

    }
}
