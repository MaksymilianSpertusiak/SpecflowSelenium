using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Helpers
{
    public class Settings
    {
        public static string homeUrl { get; set; }
        public static string browser { get; set; }

        public static void InitializeSettings()
        {
            homeUrl = System.Configuration.ConfigurationManager.AppSettings["baseUrl"];
            browser = System.Configuration.ConfigurationManager.AppSettings["browser"];
        }
    }
}
