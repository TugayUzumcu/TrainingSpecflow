using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowCursus.Pages
{
    class ReisplannerPage : BasePage
    {

        public ReisplannerPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement ticketPriceTxt => driver.FindElement(By.XPath("(//span[contains (text(), '9,50')])[2]"));

        public void getPrice()
        {
            string ticketprice = ticketPriceTxt.Text;
            Assert.AreEqual(ticketprice, "€9,50");
        }
    }
}
