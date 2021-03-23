using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        private IWebElement cookie => driver.FindElement(By.XPath("//button[contains (text(), 'Akkoord')]"));

        [BeforeScenario]
        public void beforeScenario()
        {
            driver.Navigate().GoToUrl("http://www.ns.nl");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[contains (text(), 'Akkoord')]")));
            cookie.Click();
            //driver.FindElement(By.XPath("//button[contains (text(), 'Akkoord')]")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [AfterScenario]
        public void afterScenario()
        {

        }
    }
}
