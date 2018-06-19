using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using SnowSoftwareMVCPowerBIDemo.Models;
using SnowSoftwareMVCPowerBIDemo.Models.Interfaces;

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
        /// This test asserts that when an unknown report type is passed, 
        /// null is returned from the DataStoreManager.
        /// </summary>
        [TestMethod]
        public void RetrieveReportData_ReturnsNull_WhenUnknownReportTypePassed()
        {
            //Arrange
            var mockedDataStoreManager = MockRepository.Mock<IDataStoreManager>();
            ReportHelper reportHelper;
            int unknownReportID = 3;

            //Act
            reportHelper = new ReportHelper(mockedDataStoreManager);
            ReportModel result = reportHelper.RetrieveReportData(unknownReportID);

            //Assert
            Assert.IsNull(result);
        }

        /// <summary>
        ///  This test asserts that when an known report type is passed, 
        ///  the correct report model is returned from the DataStoreManager.
        /// </summary>
        [TestMethod]
        public void RetrieveReportData_ReturnsReportModel_WhenKnownReportTypePassed()
        {
            //Arrange
            ReportModel reportModel = new ReportModel();
            var mockedDataStoreManager = MockRepository.Mock<IDataStoreManager>();
            mockedDataStoreManager.Stub(x=>x.RetrieveVersionReportData()).Return(reportModel);
            ReportHelper reportHelper = new ReportHelper(mockedDataStoreManager);

            //Act          
            ReportModel result = reportHelper.RetrieveReportData(1);

            //Assert
            Assert.IsTrue(reportModel == result);
        }
    }
}
