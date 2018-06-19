using SnowSoftwareMVCPowerBIDemo.Models.Interfaces;
using System;

namespace SnowSoftwareMVCPowerBIDemo.Models.Helpers
{
    /// <summary>
    /// ReportHelper.
    /// Any report logic is done here before retrieving report data.
    /// </summary>
    public class ReportHelper : IReportHelper
    {
        /// <summary>
        /// Type of report
        /// </summary>
        public enum ReportNum
        {
            VersionReport = 1,
            UserReport = 2,
        }

        /// <summary>
        /// Report Helper Constructor.
        /// Needs IDataStoreManager for construction.
        /// </summary>
        IDataStoreManager _DataStoreManager;
        public ReportHelper(IDataStoreManager dataStoreManager)
        {
            _DataStoreManager = dataStoreManager ?? throw new ArgumentNullException("dataStoreManager cannot be null");
        }

        /// <summary>
        /// Uses injected DataStoreManager to get report data.
        /// </summary>
        /// <param name="reportData"></param>
        /// <returns></returns>
        public ReportModel RetrieveReportData(int reportNum)
        {
            switch ((ReportNum)reportNum)
            {
                case ReportNum.VersionReport:
                    return _DataStoreManager.RetrieveVersionReportData();

                case ReportNum.UserReport:
                    return _DataStoreManager.RetrieveUserReportData();

                default:
                    return null;
            }
        }
    }
}