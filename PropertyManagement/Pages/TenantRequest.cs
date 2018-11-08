using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoItX3Lib;
using System.IO;
using NUnit.Framework;

namespace PropertyManagement
{
    internal class TenantRequest
    {
        // Creating Constructor
        public TenantRequest()
        {
            PageFactory.InitElements(Global.GlobalDefinition.driver, this);
        }

        //Owners tab
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement Owners { get; set; }
        //Tenant Request Option
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[3]")]
        private IWebElement TenantRequestLink { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/div[5]/div[1]/div[2]/div/div[1]")]
        private IWebElement Acceptbtn1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='declineRequestbutton']")]
        private IWebElement Acceptbtn2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/div[5]/div[1]/div[2]/div/div[2]")]
        private IWebElement Declinebtn1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//form[@class='ui form']/div/button")]
        private IWebElement Declinebtn2 { get; set; }
        //Skip button
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[1]")]
        private IWebElement skipbtn { get; set; }
        //Accepted Link
        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/div[4]/div[2]/a")]
        private IWebElement AcceptedLink { get; set; }
        //Declined Link
        [FindsBy(How = How.XPath, Using = "//*[@id='mainPage']/div[4]/div[3]/a")]
        private IWebElement DeclinedLink { get; set; }

        // Accept Tenant Request
        internal void AcceptTenantRequest()
        {
            Global.GlobalDefinition.driver.Manage().Window.Maximize();            
            //Explicit Wait
            Thread.Sleep(1000);
            skipbtn.Click();
            // Explicit Wait
            Thread.Sleep(1500);

            //Click on Owners tab
            Owners.Click();
            //Click Tenant Request option
            TenantRequestLink.Click();
            //Click on Accept button from Request By Tenant page
            Thread.Sleep(1000);
            Acceptbtn1.Click();
            //Click on Accept button from "Accept Tenant Request" page
            Thread.Sleep(1000);
            Acceptbtn2.Click();
            Global.SaveScreenShotClass.SaveScreenshot(Global.GlobalDefinition.driver, "TenantRequestAccepted");
        }

        //Decline Tenant Request
        internal void DeclineTenantRequest()
        {
            Global.GlobalDefinition.driver.Manage().Window.Maximize();            
            //Explicit Wait
            Thread.Sleep(1000);
            skipbtn.Click();
            // Explicit Wait
            Thread.Sleep(1000);
            //Click on Owners tab
            Owners.Click();
            //Click Tenant Request option
            TenantRequestLink.Click();
            //Click on Accept button from Request By Tenant page
            Thread.Sleep(1000);
            Declinebtn1.Click();
            //Click on Accept button from "Accept Tenant Request" page
            Thread.Sleep(1000);
            Declinebtn2.Click();
            Global.SaveScreenShotClass.SaveScreenshot(Global.GlobalDefinition.driver, "TenantRequestDeclined");
        }

        internal void ShowAcceptedTenantRequest()
        {
            Global.GlobalDefinition.driver.Manage().Window.Maximize();            
            //Explicit Wait
            Thread.Sleep(1000);
            skipbtn.Click();
            //Explicit Wait
            Thread.Sleep(1000);
            //Click on Owners tab
            Owners.Click();
            //Click Tenant Request option
            TenantRequestLink.Click();
            //Click on Accepted Link
            Thread.Sleep(1000);
            AcceptedLink.Click();
            Global.SaveScreenShotClass.SaveScreenshot(Global.GlobalDefinition.driver, "ShowAcceptedTenantRequest");
        }

        internal void ShowDeclinedTenantRequest()
        {
            Global.GlobalDefinition.driver.Manage().Window.Maximize();
            //Explicit Wait
            Thread.Sleep(1000);
            skipbtn.Click();
            // Explicit Wait
            Thread.Sleep(1000);
            //Click on Owners tab
            Owners.Click();
            //Click Tenant Request option
            TenantRequestLink.Click();
            //Click on Declined Link
            Thread.Sleep(1000);
            DeclinedLink.Click();
            Global.SaveScreenShotClass.SaveScreenshot(Global.GlobalDefinition.driver, "ShowDeclinedTenantRequest");
        }

    }
}