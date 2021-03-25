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

        




    }
}
