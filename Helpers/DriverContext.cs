using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomation.Helpers
{
    public static class DriverContext
    {
        public static IWebDriver SelectDriver(string browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    return new ChromeDriver(ChromeSettings.SetChromeSettings());
                default:
                    throw new NotImplementedException($"There is no implementation for {browserName} browser yet!!!");
            }

        }
    }
}
