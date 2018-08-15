using PropertyManagement.Config;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;


namespace PropertyManagement.Global
{
    public class Base
    {
        #region To access Path from Resource file
        public static int Browser = Int32.Parse(Config.PropertyManagementResource.Browser);
        public static string ExcelPath = Config.PropertyManagementResource.ExcelPath;
        public static string ExtentReportPath = Config.PropertyManagementResource.ExtentReportPath;
        public static string XmlReportPath = Config.PropertyManagementResource.ExtentReportXMLPath;
        public static string ScreenshotPath = Config.PropertyManagementResource.ScreenShotPath;
        #endregion

        // To access the reports
        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        #endregion


        #region Setup
        [SetUp]
        public void Initialize()
        {
            switch (Browser)
            {
                case 1:
                    GlobalDefinition.driver = new FirefoxDriver();
                    break;
                case 2:
                    GlobalDefinition.driver = new ChromeDriver();
                    break;
            }

            #region initialise Report

            //Initialise Report
            extent = new ExtentReports(ExtentReportPath, true, DisplayOrder.NewestFirst);
    
            //Load report config file
            extent.LoadConfig(PropertyManagementResource.ExtentReportXMLPath);
            #endregion

            //Creating object for Login class to access Loginstep method
            if (PropertyManagementResource.IsLogin == "true")
            {
              Login loginobj = new Login();
              loginobj.LoginSteps();
             }

           else
           {
                Registration regobj = new Registration();
                regobj.UserRegistration();
           }

        }
        #endregion

        #region TearDown
        [TearDown]
        public void TearDown()
        {
            test.Log(LogStatus.Info, "Browser Closed");
            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(GlobalDefinition.driver, "TearDownReport");

            //end test. (Reports)
            extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            extent.Flush();

            // Close the driver :           
            GlobalDefinition.driver.Close();
        }
        #endregion

    }
}
