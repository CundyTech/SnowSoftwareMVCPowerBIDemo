namespace SnowSoftwareMVCPowerBIDemo.Models.Interfaces
{
    /// <summary>
    /// ReportHelper.
    /// Any report logic is done here before retrieving report data.
    /// </summary>
    public interface IReportHelper
    {
        /// <summary>
        /// Uses injected DataStoreManager to get retrieve data.
        /// </summary>
        /// <param name="reportData"></param>
        /// <returns></returns>
        ReportModel RetrieveReportData(int reportNum);
    }
}