using NUnit.Framework;
using Excel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PropertyManagement.Global;
using System;
using RelevantCodes.ExtentReports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyManagement.Global
{
    internal class Registration
    {
        public Registration()
        {
            PageFactory.InitElements(GlobalDefinition.driver, this);
        }


        //Initialize or finding the elements

        // SignUp Link
        //Finding the firstname textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='sign_in']/div[3]/a")]
        private IWebElement SignupLink { get; set; }
               
        //Finding the firstname textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='FirstName']")]
        private IWebElement FirstName { get; set; }

        //Finding the Lastname textbox
        [FindsBy(How = How.XPath, Using = "//*[@id='LastName']")]
        private IWebElement LastName { get; set; }

        //Finding Email textbox
        [FindsBy(How = How.XPath, Using = "//div[@class='ui stack']/div[3]/div[@class='ui left icon input']/input")]
        private IWebElement EmailAddress { get; set; }

        //Finding Password field
        [FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        private IWebElement Password { get; set; }

        //Finding Choose Account Type
        [FindsBy(How = How.XPath, Using = "//*[@id='dropdown-input']/div/div[1]")]
        private IWebElement ChooseAccount { get; set; }

        //Select Account Type
        [FindsBy(How = How.XPath, Using = "//*[@id='dropdown-input']/div/div[2]/div[1]")]
        private IWebElement PropertyOwner { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='dropdown-input']/div/div[2]/div[2]")]
        private IWebElement Tenant { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='dropdown-input']/div/div[2]/div[3]")]
        private IWebElement ServiceSupplier { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='dropdown-input']/div/div[2]/div[4]")]
        private IWebElement Guest { get; set; }

        //Terms and Conditions checkbox
        [FindsBy(How = How.XPath, Using = "//*[@id='checkAgreement']")]
        private IWebElement TermsnConditionsCheckbox { get; set; }

        //SignUp Button
        [FindsBy(How = How.XPath, Using = "//*[@id='SignupButton']")]
        private IWebElement SignupButton { get; set; }


        internal void UserRegistration()
        {
            //Start the Add address test
            Base.test = Base.extent.StartTest("User Registration");

            //Populating the Excel sheet
            Global.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "Registration");

            GlobalDefinition.wait(500);

            //Navigate to the Url
            GlobalDefinition.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "Url"));
            GlobalDefinition.wait(500);

            Global.GlobalDefinition.driver.Manage().Window.Maximize();

            //Click on Sign Up Link
            SignupLink.Click();
            GlobalDefinition.wait(500);

            //Enter Firstname
            FirstName.SendKeys(ExcelLib.ReadData(2, "FirstName"));
            GlobalDefinition.wait(500);

            //Enter lastname
            LastName.SendKeys(ExcelLib.ReadData(2, "LastName"));
            GlobalDefinition.wait(500);

            //Enter the Username
            EmailAddress.SendKeys(ExcelLib.ReadData(2, "EmailAddress"));
            GlobalDefinition.wait(500);

            //Enter the password
            Password.SendKeys(ExcelLib.ReadData(2, "Password"));
            GlobalDefinition.wait(1000);

            //Click on Choose Account
            ChooseAccount.Click();
            GlobalDefinition.wait(500);

            //Select Property Owner
            PropertyOwner.Click();
            GlobalDefinition.wait(1000);

            //Check TermsnConditionCheckbox
            TermsnConditionsCheckbox.Click();
            GlobalDefinition.wait(1000);

            // Click on SignUp Button
            SignupButton.Click();


            //Screenshot
            Global.SaveScreenShotClass.SaveScreenshot(GlobalDefinition.driver, "RegistrationPage");

            //Reports
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Registration successfull");


        }
    }
}