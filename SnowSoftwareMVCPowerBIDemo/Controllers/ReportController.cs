using SnowSoftwareMVCPowerBIDemo.Models;
using SnowSoftwareMVCPowerBIDemo.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SnowSoftwareMVCPowerBIDemo.Controllers
{
    public class ReportController : Controller
    {
        /// <summary>
        /// Main report action.
        /// Gets appropriate model given a report number and binds it with view.
        /// </summary>
        /// <param name="reportNum"></param>
        /// <returns>ActionResult</returns>
        public ActionResult Index(int reportNum)
        {
            DataStoreManager DataStoreManager = new DataStoreManager();
            ReportHelper reportHelper = new ReportHelper(DataStoreManager);
            var reportModel = reportHelper.RetrieveReportData(reportNum);

            if (reportModel != null)
            {
                ViewBag.Chart1Source = reportModel.Chart1Source;
                ViewBag.Chart2Source = reportModel.Chart2Source;
                ViewBag.SubTitle = reportModel.ReportSubTitle;
                ViewBag.ReportTitle = reportModel.ReportTitle;
            }
            
            return View(reportModel ?? null);
        }

        /// <summary>
        /// Show About page.
        /// </summary>
        /// <returns>ActionResult</returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Show Contact page.
        /// </summary>
        /// <returns>ActionResult</returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}