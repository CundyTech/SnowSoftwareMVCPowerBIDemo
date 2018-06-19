namespace SnowSoftwareMVCPowerBIDemo.Models.Interfaces
{
    /// <summary>
    /// Manages the retreival of data from data store.
    /// </summary>
    public interface IDataStoreManager
    {
        /// <summary>
        /// Retrieve User Report Data
        /// </summary>
        /// <returns>Report Model specific to User</returns>
        ReportModel RetrieveUserReportData();

        /// <summary>
        /// Retrieve Version Report Data
        /// </summary>
        /// <returns>Report Model specific to Version</returns>
        ReportModel RetrieveVersionReportData();
    }
}