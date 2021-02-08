using OpenQA.Selenium;
using SpecflowCursus.DriverGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowCursus.Steps
{
    public class Hooks
    {
        protected static Driver driverGenerator = new Driver();
        static IWebDriver driver = driverGenerator.getDriver();

        [BeforeScenario]
        public void beforeScenario()
        {
            driver.Navigate().GoToUrl("http://www.ns.nl");
        }

        [AfterScenario]
        public void afterScenario()
        {

        }
    }
}
