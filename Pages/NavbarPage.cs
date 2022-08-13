using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestAutomation.Pages
{
    public class NavbarPage : BasePage
    {
        private readonly string navbarButtonXpath = "//div[@class='site-nav']/ul/li/a";
        public NavbarPage(IWebDriver driver) : base(driver) { }

        public void ClickNavbarButton(string buttonName)
        {
            WaitForReadyState();
            var button = WaitForElementToBeClickable(By.XPath($"{navbarButtonXpath}[normalize-space(.)='{buttonName}']"));
            button.Click();
        }

        public bool IsNavbarElementVisible(string buttonName)
        {
            return IsVisible(By.XPath($"{navbarButtonXpath}[normalize-space(.)='{buttonName}']"));
        }
    }
}
