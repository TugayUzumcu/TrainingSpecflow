using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowCursus.Pages
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        //Locators

        private IWebElement nsLogo => driver.FindElement(By.ClassName(".ns-header__logoImage"));


        public void clickLogo()
        {
            nsLogo.Click();
        }
    }
}
