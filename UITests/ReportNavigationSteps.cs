using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace UITests
{
    [Binding]
    public class ReportNavigationSteps
    {
        private IWebDriver _Driver;
        private ReportNavigationPageObject _PageObject;

        /// <summary>
        /// Create instance of FireFox browser to run test on.
        /// </summary>
        [BeforeScenario()]
        public void Setup()
        {
            //Get path "\bin\Debug" of firefox binary location.
            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            _Driver = new FirefoxDriver(path.Substring(6));
            _PageObject = new ReportNavigationPageObject(_Driver);
        }

        /// <summary>
        /// Closes browser after test has run.
        /// </summary>
        [AfterScenario()]
        public void TearDown()
        {
            _Driver.Quit();
        }

        [Given(@"I am on the \(""(.*)""\) page")]
        public void GivenIAmOnThePage(string p0)
        {
            _PageObject.NavigateToPage(p0);
        }

        [Then(@"the site should navigate to the \(""(.*)""\) page")]
        public void ThenTheSiteShouldNavigateToThePage(string p0)
        {
            Assert.IsTrue(_PageObject.IsCurrentPage(p0));
        }

        [When(@"I press click on the VersionsReport menu item")]
        public void WhenIPressClickOnTheVersionsReportMenuItem()
        {
            _PageObject.ClickOnVersionsReportMenuItem();
        }
                
        [When(@"I press click on the UserReport menu item")]
        public void WhenIPressClickOnTheUserReportMenuItem()
        {
            _PageObject.ClickOnUserReportMenuItem();
        }

    }
}
