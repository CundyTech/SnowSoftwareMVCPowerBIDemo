namespace SnowSoftwareMVCPowerBIDemo.Models
{
    /// <summary>
    /// Model that represents the content of a report page.
    /// </summary>
    public class ReportModel
    {
        /// <summary>
        /// Datasource of Top Chart 
        /// </summary>
        public string Chart1Source { get; set; }

        /// <summary>
        /// Datasource of Bottom Chart
        /// </summary>
        public string Chart2Source { get; set; }

        /// <summary>
        ///  Datasource of Report Subtitle
        /// </summary>
        public string ReportSubTitle { get; set; }

        /// <summary>
        ///  Datasource of Report Title
        /// </summary>
        public string ReportTitle { get; set; }
    }
}