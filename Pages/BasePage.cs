using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestAutomation.Pages
{
    public class BasePage
    {
        protected IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void OpenUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        protected IWebElement WaitForElement(By locator)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            return wait.Until(_driver => _driver.FindElement(locator));
        }

        protected IWebElement WaitForElementToBeVisible(By locator)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        protected IWebElement WaitForElementToBeClickable(By locator)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        protected bool IsVisible(By locator)
        {
            try
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
                return element.Displayed;
            }
            catch
            {
                return false;
            }
        }

        protected void WaitForReadyState()
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(20)).Until(d =>
            ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }

    }
}
