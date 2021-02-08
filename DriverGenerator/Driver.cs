using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowCursus.DriverGenerator
{
    public class Driver
    {
        private IWebDriver driver;
        public IWebDriver getDriver()
        {
            if (driver == null)
            {
                createDriver();
            }
            return driver;
        }
        public void createDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

    }
}

