using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using SnowSoftwareMVCPowerBIDemo.Models;
using SnowSoftwareMVCPowerBIDemo.Models.Interfaces;
using System;

namespace UnitTests
{
    [TestClass]
    public class ReportHelper_Tests
    {
        /// <summary>
        /// This test asserts the constructor throws an exception when a null parameter is used.
        /// </summary>
        [TestMethod]
        public void Constructor_ThrowsException_WhenNullParamPassed()
        {
            //Arrange
            IDataStoreManager mockedDataStoreManager = null;
            ReportHelper reportHelper;
            bool exceptionThrow = false;
            try
            {
                //Act
                reportHelper = new ReportHelper(mockedDataStoreManager);
            }
            catch (ArgumentNullException)
            {
                exceptionThrow = true;

            }
            //Assert
            Assert.IsTrue(exceptionThrow);
        }

        /// <summary>
        /// This test asserts the constructor throws an exception when a null parameter is used.
        /// </summary>
        [TestMethod]
        public void RetrieveReportData_ReturnsNull_WhenUnknownReportTypePassed()
        {
            //Arrange
            var mockedDataStoreManager = MockRepository.GenerateMock<IDataStoreManager>();
            ReportHelper reportHelper;
            int unknownReportID = 3;
           
            //Act
            reportHelper = new ReportHelper(mockedDataStoreManager);
            ReportModel result = reportHelper.RetrieveReportData(unknownReportID);

            //Assert
            Assert.IsNull(result);
        }
    }
}
