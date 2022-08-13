using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomation.Helpers
{
    public static class ChromeSettings
    {
        public static ChromeOptions SetChromeSettings()
        {
            var options = new ChromeOptions();
            options.AddArgument("--window-size=1920,1080");
            return options;
        }
    }
}
