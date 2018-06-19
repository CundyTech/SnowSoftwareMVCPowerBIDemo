using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace UITests
{
    /// <summary>
    /// Page Object interfaces directly with application via the Selenium webdriver.
    /// </summary>
    class ReportNavigationPageObject
    {
        [FindsBy(How = How.Id, Using = "UsersMenuItem")]
        private IWebElement _UsersReportMenuItem;

        [FindsBy(How = How.Id, Using = "VersionsMenuItem")]
        private IWebElement _VersionsReportMenuItem;

        private Uri _BaseUrl = new Uri("http://localhost:12243/");

        public static IWebDriver _Driver;

        /// <summary>
        /// Report Navigation PageObject constructor.
        /// </summary>
        /// <param name="driver"></param>
        public ReportNavigationPageObject(IWebDriver driver)
        {
            _Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Navigate to given page in browser.
        /// </summary>
        /// <param name="url"></param>
        internal void NavigateToPage(string pageName)
        {
            _Driver.Navigate().GoToUrl(GetPageUri(pageName));
        }

        /// <summary>
        /// Work out if given page is current page.
        /// </summary>
        /// <param name="p0"></param>
        /// <returns></returns>
        internal bool IsCurrentPage(string p0)
        {
            var currentPage = GetCurrentPage();
            var expectedPage = GetPageUri(p0);
            return currentPage == expectedPage;
        }

        /// <summary>
        /// Click on menu item.
        /// </summary>
        internal void ClickOnVersionsReportMenuItem()
        {
            _VersionsReportMenuItem.Click();
        }

        /// <summary>
        /// Click on menu item.
        /// </summary>
        internal void ClickOnUserReportMenuItem()
        {
            _UsersReportMenuItem.Click();
        }

        /// <summary>
        /// Get page loaded in browser.
        /// </summary>
        /// <returns></returns>
        internal Uri GetCurrentPage()
        {
            return new Uri(_Driver.Url);
        }

        /// <summary>
        /// Convert friendly page name to page uri.
        /// </summary>
        /// <param name="pageName"></param>
        /// <returns></returns>
        public Uri GetPageUri(string pageName)
        {
            Uri uri;

            if (pageName.ToLower() == "versionsreport")
            {
                uri = new Uri(_BaseUrl, "Report?reportNum=1");
            }
            else if (pageName.ToLower() == "userreport")
            {
                uri = new Uri(_BaseUrl, "Report?reportNum=2");
            }
            else if (pageName.ToLower() == "dashboard")
            {
                uri = _BaseUrl;
            }
            else
            {
                return null;
            }

            return uri;
        }
    }
}
