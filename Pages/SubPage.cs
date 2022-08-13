using OpenQA.Selenium;

namespace TestAutomation.Pages
{
    public class SubPage : BasePage
    {
        private readonly string headerXpath = "//h2";
        private readonly string validationErrorContainerXpath = "//div[@class='alert alert-danger alert-dismissable']";
        public SubPage(IWebDriver driver) : base(driver) { }

        public bool IsSubpageVisible(string subpageName)
        {
            return IsVisible(By.XPath($"{headerXpath}[normalize-space(.)='{subpageName}']"));
        }

        public void ClickButton(string buttonName)
        {
            WaitForElementToBeClickable(By.XPath($"//input[@value='{buttonName}']")).Click();
        }

        public bool IsValidationErrorVisible(string errorMessage)
        {
            return IsVisible(By.XPath($"{validationErrorContainerXpath}[contains(text(), '{errorMessage}')]"));
        }

        public void PopulateField(string fieldName, string value)
        {
            WaitForElementToBeClickable(By.XPath($"//*[@name='{fieldName}']")).SendKeys(value);
        }
    }
}
