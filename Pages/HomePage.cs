using NUnit.Framework;
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

        private IWebElement planJeReisTxt => driver.FindElement(By.ClassName("headingXL"));
        private IWebElement locationPositionInput => driver.FindElement(By.XPath("//span[contains (text(), 'van')]//following-sibling::input"));
        private IWebElement destinationInput => driver.FindElement(By.XPath("//span[contains (text(), 'naar')]//following-sibling::input"));
        private IWebElement locationDropDown => driver.FindElement(By.XPath("//*[contains (text(), 'Amsterdam Airport')]"));
        private IWebElement destinationDropDown => driver.FindElement(By.XPath("//*[contains (text(), 'Utrecht Centraal')]"));
        private IWebElement plannenButton => driver.FindElement(By.XPath("//span[contains (text(), 'Plannen')]"));
        private IWebElement calendarBtn => driver.FindElement(By.XPath("//*[contains (@class, 'date-planner')]"));
        private string calendarPickBtn = "//button[contains (@aria-label, 'datePick')]";

        public void getHeaderPlanJeReis()
        {
            Assert.IsTrue(planJeReisTxt.Displayed);
        }
        public void setStartPoint(string location)
        {
            locationPositionInput.SendKeys(location);
        }
        public void setDestination(string destination)
        {
            destinationInput.SendKeys(destination);
        }
        public void clickLocation()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains (text(), 'Amsterdam Airport')]")));
            locationDropDown.Click();
        }
        public void clickDestination()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains (text(), 'Utrecht Centraal')]")));
            destinationDropDown.Click();
        }
        public void clickPlannen()
        {
            plannenButton.Click();
        }
       
        public void clickCalendar()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains (@class, 'date-planner')]")));
            calendarBtn.Click();
        }
        public void setData(string data)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[contains (@class, 'date-planner')]")));
            IWebElement calenderUpdated = driver.FindElement(By.XPath(calendarPickBtn.Replace("'datePick'", $"'{data}'")));
            calenderUpdated.Click();

        }

    }
        
}
