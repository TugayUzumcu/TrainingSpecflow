using OpenQA.Selenium;
using SpecflowCursus.DriverGenerator;
using SpecflowCursus.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowCursus.Steps
{
    [Binding]
    public class StepDefinition : Hooks
    {
        static IWebDriver driver = driverGenerator.getDriver();
        HomePage homePage = new HomePage(driver);

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            homePage.clickLogo();
        }
        [When("user inserts tracking point")]
        public void WhenUserInsertsTrackingPoint()
        {
            homePage.insertTrackPoint("Eindhoven");
        }
        [When("user clicks on the first suggestion")]
        public void WhenUserClicksOnTheFirstSuggestion()
        {
            homePage.clickLocation();
        }

    }
}
