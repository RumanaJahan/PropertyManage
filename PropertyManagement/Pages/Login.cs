using Excel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PropertyManagement.Global
{
    internal class Login
    {
        //This is a test for git
        //Create a Constructor
        public Login()
        {
            PageFactory.InitElements(Global.GlobalDefinition.driver, this);
        }

        //Define the UserName textBox
        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement Username { set; get; }
        //Define the Password textBox
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement Password { set; get; }
        //Define the Login Button
        [FindsBy(How = How.XPath, Using = "//*[@id='sign_in']/div[1]/div[4]/button")]
        private IWebElement LoginBtn { set; get; }
        //Skip button
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[1]")]
        private IWebElement skipbtn { get; set; }

        internal void LoginSteps()
        {
            //Start the Login
            Global.Base.test = Global.Base.extent.StartTest("Property Owner Login");     
            //Populate in collection
            Global.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "LoginPage");
            //Navigate to Url
            Global.GlobalDefinition.driver.Navigate().GoToUrl(Global.ExcelLib.ReadData(2, "Url"));
            Global.GlobalDefinition.wait(500);
            //Enter Username 
            Username.SendKeys(Global.ExcelLib.ReadData(2, "UserName"));
            //Enter Password 
            Password.SendKeys(Global.ExcelLib.ReadData(2, "Password"));
            Thread.Sleep(500);
            //Checking login button is displayed with assert
            try
            {
                Assert.IsTrue(LoginBtn.Displayed);
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            //Click on login Button
            LoginBtn.Click();
            Thread.Sleep(1000);
            // Checking Page Title with assert
            try
            {
                string pageTitle = Global.GlobalDefinition.driver.Title;
                Assert.AreEqual("Properties | Property Community","Properties | Property Community", pageTitle);
                //Assert.That(pageTitle,Does.Match("Dashboard"));
            }
            catch(Exception e)
            {
                Console.Write(e);
            }

             /*
            //Verification
            string message = Global.GlobalDefinition.driver.FindElement(By.XPath("//*[@id='main-content']/section/div[1]/h2")).Text;
            string ActualMessage = Global.ExcelLib.ReadData(2, "LoginVerification");
            //Explicit Wait
            Thread.Sleep(2000);         
            if (message == ActualMessage)
            {
               Global.Base.test.Log(LogStatus.Pass, "Property Owner Login Successfull");
               Global.SaveScreenShotClass.SaveScreenshot(Global.GlobalDefinition.driver, "Dashboard");
             }
            else
            {
                Global.Base.test.Log(LogStatus.Fail, "Property Owner Login Unsuccessfull");
            }
            */


            Global.GlobalDefinition.driver.Manage().Window.Maximize();
            //Explicit Wait
            Thread.Sleep(1000);
            skipbtn.Click();
        }

        }
    }

