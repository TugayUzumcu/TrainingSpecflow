using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        private IWebElement nsLogo => driver.FindElement(By.XPath("//span[contains (@class, 'logoImage')]"));
        private IWebElement vertrekPuntTxtBox => driver.FindElement(By.XPath("//input[@id='location-input-FROM-POSITIONED']"));
        private IWebElement firstSuggestion => driver.FindElement(By.XPath("//span[contains (text(), 'Eindhoven Centraal')]//parent::a"));

        public void clickLogo()
        {
            nsLogo.Click();
        }
        public void insertTrackPoint(string trackpoint)
        {
            vertrekPuntTxtBox.SendKeys(trackpoint);
        }
        public void clickLocation()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains (text(), 'Eindhoven Centraal')]//parent::a")));
            firstSuggestion.Click();
        }

        public void leeg()
        {
            
        }
        
    }
}
