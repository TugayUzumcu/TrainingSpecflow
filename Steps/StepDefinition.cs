using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        ReisplannerPage reisplannerPage = new ReisplannerPage(driver);

        [Given(@"de gebruiker is op de ns website")]
        public void GivenDeGebruikerIsOpDeNsWebsite()
        {
            homePage.getHeaderPlanJeReis();
        }
        [When(@"gebruiker voert (.*) in")]
        public void WhenGebruikerVoertIn(string location)
        {
            homePage.setStartPoint(location);
            homePage.clickLocation();
        }
        [When(@"gebruiker vult zijn (.*) in")]
        public void WhenGebruikerVultZijnIn(string destination)
        {
            homePage.setDestination(destination);
            homePage.clickDestination();
        }
        [When(@"gebruiker klik op plannen om een reis uit te kiezen")]
        public void WhenGebruikerKlikOpPlannenOmEenReisUitTeKiezen()
        {
            homePage.clickPlannen();
        }
        [Then(@"de gebruiker heeft de prijs van de reis gevonden")]
        public void ThenDeGebruikerHeeftDePrijsVanDeReisGevonden()
        {
            reisplannerPage.getPrice();
        }
        [When(@"gebruiker vult in de (.*)")]
        public void WhenGebruikerVultInDe(string date)
        {
            homePage.clickCalendar();
            homePage.setData(date);
        }




    }
}
