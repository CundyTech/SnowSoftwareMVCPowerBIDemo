using SnowSoftwareMVCPowerBIDemo.Models.Interfaces;

namespace SnowSoftwareMVCPowerBIDemo.Models.Helpers
{
    /// <summary>
    /// Manages the retreival of data from data store.
    /// Can be swapped out with PowerBIDataManager at a later data.
    /// </summary>
    public class DataStoreManager : IDataStoreManager
    {
        public ReportModel RetrieveUserReportData()
        {
            ReportModel model = new ReportModel
            {
                Chart1Source = "../Assets/SumOfNumCrashes.JPG",
                Chart2Source = "../Assets/UsersByDate.JPG",
                ReportSubTitle = "Total Amount of Users: 110",
                ReportTitle = "Users"
            };

            return model;
        }

        /// <summary>
        /// Retrieve Version Report Data
        /// </summary>
        /// <returns>Report Model specific to Version</returns>
        public ReportModel RetrieveVersionReportData()
        {
            ReportModel model = new ReportModel
            {
                Chart1Source = "../Assets/usersByVersionNumber.JPG",
                Chart2Source = "../Assets/UptakePercentage.JPG",
                ReportSubTitle = "Latest Version: 7.3",
                ReportTitle = "Version"
            };

            return model;
        }
    }
}