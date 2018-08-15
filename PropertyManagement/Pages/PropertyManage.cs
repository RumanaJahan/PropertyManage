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
    internal class PropertyManage
    {
        // Creating Constructor
        public PropertyManage()
        {
                PageFactory.InitElements(Global.GlobalDefinition.driver,this);
        }
               
        //Owners tab
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement Owners { get; set; }
        //Properties option
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[1]")]
        private IWebElement Properties { get; set; }
        //Add New Property Button
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/div/div[1]/div/div[2]/div/div[2]/a[2]")]
        private IWebElement AddPropertybtn { get; set; }
        // Elements for Sort Property
        // SortBydropdown
        [FindsBy(How = How.XPath, Using = "//div[@class='ui dropdown selection']")]
        private IWebElement SortByDropdown { get; set; }
        //SortbyName
        [FindsBy(How = How.CssSelector, Using = "#main-content>section>div:nth-child(1)>div>div.highlighted>div>div:nth-child(1)>div>div>div.menu.transition.visible>div:nth-child(1)")]
        private IWebElement SortByName { get; set; }
        //SortbyName(Desc)
        [FindsBy(How = How.CssSelector, Using = "#main-content>section>div:nth-child(1)>div>div.highlighted>div>div:nth-child(1)>div>div>div.menu.transition.visible>div:nth-child(2)")]
        private IWebElement SortByNameDesc { get; set; }
        //SortbyLatestdate
        [FindsBy(How = How.CssSelector, Using = "#main-content>section>div:nth-child(1)>div>div.highlighted>div>div:nth-child(1)>div>div>div.menu.transition.visible>div:nth-child(3)")]
        private IWebElement SortByLatestDate { get; set; }
        //SortbyEarliestdate
        [FindsBy(How = How.CssSelector, Using = "#main-content>section>div:nth-child(1)>div>div.highlighted>div>div:nth-child(1)>div>div>div.menu.transition.visible>div:nth-child(4)")]
        private IWebElement SortByEarliestDate { get; set; }
        //Element for Search Property
        //Searchbox
        [FindsBy(How = How.Name, Using = "SearchString")]
        private IWebElement Searchbox { get; set; }
        //Searchbutton
        [FindsBy(How = How.XPath, Using = "//*[@id='icon-submitt']")]
        private IWebElement Searchbtn { get; set; }
        // Elements for Add New Property Page
        // ************PropertyDetails***************
        //Property Name
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[2]/div[1]/div[1]/input")]
        private IWebElement PropertyName { get; set; }
        //Property type drop down
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[2]/div[2]/div")]
        private IWebElement PropertyTypeDropdown{ get; set; }
        //Property type dropdown value
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[2]/div[2]/div/div[2]/div[2]")]
        private IWebElement PropertyTypedropdownvalue { get; set; }
        //Description
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[3]/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }
        //Street Number(Used Own Xpath)
        [FindsBy(How = How.XPath, Using = "//div[@class='six wide field']/div/input[@id='street_number']")]
        private IWebElement StreetNo { get; set; }
        //Street Name(Used Own Xpath)
        [FindsBy(How = How.XPath, Using = "//div[@class='ten wide field']/div/input[@id='route']")]
        private IWebElement StreetName { get; set; }
        //Suburb
        [FindsBy(How = How.XPath, Using = "//div[@class='field']/div/input[@id='route']")]
        private IWebElement Suburb { get; set; }
        //City
        [FindsBy(How = How.XPath, Using = "//div[@class='field']/div/input[@id='street_number']")]
        private IWebElement City { get; set; }
        //PostCode
        [FindsBy(How = How.XPath, Using = "//div[@class='three fields']/div[3]/div/input[@id='street_number']")]
        private IWebElement Postcode { get; set; }          
        //Region
        [FindsBy(How = How.XPath, Using = "//*[@id='region']")]
        private IWebElement Region { get; set; }
        //Target Rent
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[4]/div/div[1]/div[1]/input")]
        private IWebElement TargetRent { get; set; }
        //Rent type drop down
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[4]/div[2]/div/div[2]/div")]
        private IWebElement RentTypeDropdown { get; set; }
        //Rent type dropdown value 
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[4]/div/div[2]/div/div[2]/div[2]")]
        private IWebElement RentTypeDropdownvalue { get; set; }
        //Land Area
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[5]/div[1]/div/input")]
        private IWebElement LandArea { get; set; }
        //Floor Area
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[5]/div[2]/div/input")]
        private IWebElement FloorArea { get; set; }
        //Bedrooms
        [FindsBy(How = How.CssSelector, Using = "#property-details>div:nth-child(7)>div:nth-child(1)>div.ui.input.full.width>input[type='text']")]
        private IWebElement Bedrooms { get; set; }
        //Bathrooms
        [FindsBy(How = How.CssSelector, Using = "#property-details>div:nth-child(7)>div:nth-child(2)>div.ui.input.full.width>input[type='text']")]
        private IWebElement Bathrooms { get; set; }
        // Carparks
        [FindsBy(How = How.CssSelector, Using = "#property-details>div:nth-child(8)>div:nth-child(1)>div.ui.input.full.width>input[type='text']")]
        private IWebElement Carparks { get; set; }
        //Year built
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[7]/div[2]/div[1]/input")]
        private IWebElement YearBuilt { get; set; }
        //ChooseFile button
        [FindsBy(How = How.XPath, Using = "//*[@id='file-upload']")]
        private IWebElement FileUploadbtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[9]/div")]
        private IWebElement photo { get; set; }
        //Next Button on Property Details page
        [FindsBy(How = How.XPath, Using = "//*[@id='property-details']/div[10]/div/button[1]")]
        private IWebElement NextbtnProptertyDetails { get; set; }  
        // ************Financial Details***************
        //Purchase Price
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[1]/div[1]/input")]
        private IWebElement purchaseprice { get; set; }
        //Mortgage
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[2]/div[1]/input")]
        private IWebElement Mortgage { get; set; }
        //HomeValue
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[3]/div[1]/input")]
        private IWebElement HomeValue { get; set; }
        //HomeValueType
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[4]/div")]
        private IWebElement HomeValueType { get; set; }
        //HomeValueTypeSelection
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[1]/div[4]/div/div[2]/div[2]")]
        private IWebElement HomeValueTypeSelection { get; set; }               
        //AddRepayment
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[4]/div/a")]
        private IWebElement AddRePayment { get; set; }
        //RepaymentAmount
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[3]/div/div[1]/div[1]/input")]
        private IWebElement RePaymentAmount { get; set; }
        //RepaymentFrequency
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[3]/div/div[2]/select")]
        private IWebElement RepaymentFrequency { get; set; }
        //StartDateCalender
        [FindsBy(How = How.XPath, Using = "//*[@id='payment-start-date']")]
        private IWebElement RePaymentStartdate { get; set; }
        //SelectStartdate
        [FindsBy(How = How.XPath, Using = "div/ul/li[1]/div/div[1]/table/tbody/tr[4]/td[7]")]
        private IWebElement SelectStartDate { get; set; }
        //EndDateCalender
        [FindsBy(How = How.XPath, Using = "//*[@id='payment-end-date']")]
        private IWebElement RePaymentEnddate { get; set; }
        //NextMonthEndDate
        [FindsBy(How = How.XPath, Using = "div/ul/li[1]/div/div[1]/table/thead/tr[1]/th[3]/span")]
        private IWebElement NextMonthEndDate { get; set; }
        //SelectEndDate
        [FindsBy(How = How.XPath, Using = "div/ul/li[1]/div/div[1]/table/tbody/tr[3]/td[4]")]
        private IWebElement SelectEndDate { get; set; }
        //AddExpense
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[7]/div/a")]
        private IWebElement AddExpense { get; set; }
        //ExpenseAmount
        [FindsBy(How = How.XPath, Using = "//div[@class='four wide column']/div/input[@id='Text1']")]
        private IWebElement ExpenseAmount { get; set; }
        //ExpenseDescription
        [FindsBy(How = How.XPath, Using = "//div[@class='seven wide column']/div/input[@id='Text1']")]
        private IWebElement ExpenseDescription { get; set; }
        //ExpenseDateCalender
        [FindsBy(How = How.XPath, Using = "//*[@id='expense-date']")]
        private IWebElement ExpenseDateCalender { get; set; } 
        [FindsBy(How = How.XPath, Using = "//*[@id='financeSection']/div[8]/button[3]")]
        private IWebElement NextbtnFinanceDetails { get; set; }
        // ************Tenant Details***************
        //TenantEmail
        [FindsBy(How = How.XPath, Using = "//*[@id='email']")]  
        private IWebElement TenantEmail { get; set; }  
        //IsMainTenant
        [FindsBy(How = How.XPath, Using = "//*[@id='tenantSection']/div[1]/div[2]/div")]
        private IWebElement IsMainTenant { get; set; }
        //IsMainTenantYes
        [FindsBy(How = How.XPath, Using = "//*[@id='tenantSection']/div[1]/div[2]/div/div[2]/div[1]")]
        private IWebElement IsMainTenantSelectYes { get; set; }
        //IsMainTenantNo
        [FindsBy(How = How.XPath, Using = "//*[@id='tenantSection']/div[1]/div[2]/div/div[2]/div[2]")]
        private IWebElement IsMainTenantSelectNo { get; set; }
        //TenantFirstName
        [FindsBy(How = How.XPath, Using = "//*[@id='fname']")]
        private IWebElement TenantFirstName { get; set; }
        //TenantLastName
        [FindsBy(How = How.XPath, Using = "//*[@id='lname']")]
        private IWebElement TenantLastName { get; set; }
        //TenantStartDate
        [FindsBy(How = How.XPath, Using = "//*[@id='sdate']")]
        private IWebElement TenantStartDate { get; set; }
        //TenantEndDate
        [FindsBy(How = How.XPath, Using = "//*[@id='edate']")]
        private IWebElement TenantEndDate { get; set; }
        //TenantRentAmount
        [FindsBy(How = How.XPath, Using = "//*[@id='ramount']")]
        private IWebElement TenantRentAmount { get; set; }
        //PaymentFrequencydropdown
        [FindsBy(How = How.XPath, Using = "/*[@id='tenantSection']/div[1]/div[8]/div")]
        private IWebElement PaymentFrequencydropdown { get; set; }
        //PaymentFrequencydropdownmonth
        [FindsBy(How = How.XPath, Using = "//*[@id='tenantSection']/div[1]/div[8]/div/div[2]/div[3]")]
        private IWebElement PaymentFrequencydropdownMonth { get; set; }
        //TenantPaymentStartdate
        [FindsBy(How = How.XPath, Using = "//*[@id='psdate']")]
        private IWebElement TenantPaymentStartdate { get; set; }
        //PaymentDueDayDropdown
        [FindsBy(How = How.XPath, Using = "/*[@id='tenantSection']/div[1]/div[10]/div")]
        private IWebElement PaymentDueDayDropdown { get; set; }
        //PaymentDueDayDropdownvalue
        [FindsBy(How = How.XPath, Using = "//*[@id='tenantSection']/div[1]/div[10]/div/div[2]/div[3]")]
        private IWebElement PaymentDueDayDropdownvalue { get; set; }
        //AddNewLiability
        [FindsBy(How = How.XPath, Using = ".//*[@id='tenantSection']/div[4]/a")]
        private IWebElement AddNewLiability { get; set; }
        //LiabilityNameDropDown
        [FindsBy(How = How.XPath, Using = "//*[@id='LiabilityDetail']/div/div/div[1]/select")]
        private IWebElement LiabilityNameDropdown { get; set; }
        //Select Insurance as Liability Name
        [FindsBy(How = How.XPath, Using = ".//*[@id='LiabilityDetail']/div/div/div[1]/select/option[2]")]
        private IWebElement LiabilityNameDropdownInsurance { get; set; }
        //LiabilityAmount
        [FindsBy(How = How.XPath, Using = "//*[@id='LiabilityDetail']/div/div/div[2]/div/input")]
        private IWebElement LiabilityAmount { get; set; }
        //SaveButton
        [FindsBy(How = How.XPath, Using = "//*[@id='saveProperty']")]
        private IWebElement SavePropertyButton { get; set; } 
        //Elements for Edit Property
        //MenuLink
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/section/div[1]/div/div[3]/div/div[1]/div/div/div[2]/div[1]/div[3]/div/i")]
        private IWebElement menulink { get; set; }
        //Edit Button
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/section/div[1]/div/div[3]/div/div[1]/div/div/div[2]/div[1]/div[3]/div/div/div[4]")]
        private IWebElement EditBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/section/div[3]/div[2]/form/div[1]/div[1]/div/input")]
        private IWebElement EditPropertyName { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/section/div[3]/div[2]/form/div[2]/div[2]/div/textarea")]
        private IWebElement EditDescription { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/section/div[3]/div[2]/form/div[6]/div[1]/div/input")]
        private IWebElement EditCar { get; set; }
        //ChooseFiles button
        [FindsBy(How = How.XPath, Using = "//*[@id='fileUpload']")]
        private IWebElement ChooseFilesbtn { get; set; }
        //EditSave Button
        [FindsBy(How = How.XPath, Using = "//div[@class='field text-center']/button[@class='ui positive button']")]
        private IWebElement EditSaveBtn { get; set; }
        //Element for Delete Property        
        //Delete Button
        [FindsBy(How = How.CssSelector, Using = "#main-content>section>div:nth-child(1)>div>div:nth-child(7)>div>div:nth-child(1)>div>div>div.ui.bottom.aligned.content>div.ui.grid>div.ui.one.wide.column>div>div>div:nth-child(5)")]
        private IWebElement Delete { get; set; }
        //Delete Confirm Button
        [FindsBy(How = How.CssSelector, Using = "#main-content>section>div:nth-child(4)>div>div.panel-body>div.prop-actions>button.btn.btn-success")]
        private IWebElement DeleteConfirmbtn { get; set; }
        // Elements for Pagination
        //NextPage
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/section/div[1]/div/div[4]/div/ul/li[8]/a")]
        private IWebElement NextPagePagination { get; set; }
        //PreviousPage
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/section/div[1]/div/div[4]/div/ul/li[1]/a")]
        private IWebElement PreviousPagePagination { get; set; }
        //PaginationNumber
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/section/div[1]/div/div[4]/div/ul/li[3]/a")]
        private IWebElement PaginationNumber { get; set; }
        //LastPage
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/section/div[1]/div/div[4]/div/ul/li[10]/a")]
        private IWebElement LastPagePagination { get; set; }
        //FirstPage
        [FindsBy(How = How.XPath, Using = "//*[@id='main-content']/section/div[1]/div/div[4]/div/ul/li[10]/a")]
        private IWebElement FirstPagePagination { get; set; }
        //Skip button
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[1]")]
        private IWebElement skipbtn { get; set; }



        // Create a new Property
        internal void CreateProperty()
        {
         
          Global.ExcelLib.PopulateInCollection(Config.PropertyManagementResource.ExcelPath,"Property");
          //Explicit Wait
          Thread.Sleep(1000);
          //Click on Owners tab
          Owners.Click();
          //Click Properties option
          Properties.Click();
          //Click on Add New Property button
          AddPropertybtn.Click();
          Thread.Sleep(500);
          // ************PropertyDetails***************
          //Enter Property Name
          PropertyName.SendKeys(Global.ExcelLib.ReadData(2,"PropertyName"));
          Thread.Sleep(500);
          //Click on Property type dropdown
          PropertyTypeDropdown.Click();
          //Select the value from property type dropdown
          PropertyTypedropdownvalue.Click();
          //Enter Description
          Description.SendKeys(Global.ExcelLib.ReadData(2,"Description"));
          //Enter Street Number
          StreetNo.SendKeys(Global.ExcelLib.ReadData(2,"StreetNumber"));
          //Enter Street Name
          StreetName.SendKeys(Global.ExcelLib.ReadData(2,"StreetName"));
          //Enter Suburb
          Suburb.SendKeys(Global.ExcelLib.ReadData(2,"Suburb"));
          //Enter City
          City.SendKeys(Global.ExcelLib.ReadData(2,"City"));
          //Enter Postcode
          Postcode.SendKeys(Global.ExcelLib.ReadData(2,"PostCode"));
          //Enter Region
          Region.SendKeys(Global.ExcelLib.ReadData(2, "Region"));
          //Enter Target Rent
          TargetRent.SendKeys(Global.ExcelLib.ReadData(2, "TargetRent"));
          Thread.Sleep(1000);
          //Click on Rent drop down 
          //RentTypeDropdown.Click();
          //Select value from Rent dropdown
          // RentTypeDropdownvalue.Click();
          //Enter Land Area
          LandArea.SendKeys(Global.ExcelLib.ReadData(2, "LandArea"));
          //Enter Floor Area
          FloorArea.SendKeys(Global.ExcelLib.ReadData(2, "FloorArea"));
          //Enter Bedroom
          Bedrooms.SendKeys(Global.ExcelLib.ReadData(2,"BedRooms"));
          //Enter Bathroom
          Bathrooms.SendKeys(Global.ExcelLib.ReadData(2,"BathRooms"));
          //Enter CarParks
          Carparks.SendKeys(Global.ExcelLib.ReadData(2,"CarParks"));
          Thread.Sleep(1000);
          //Enter Year built
          YearBuilt.SendKeys(Global.ExcelLib.ReadData(2,"YearBuilt"));
          // File Upload Approach1: Send Keys
          /*
          FileUploadbtn.SendKeys(@"C:\Users\Shahabuddin\Desktop\Rumana\testiamge.jpg");
          Thread.Sleep(1000);
          photo.Click();
          */
          // File Upload Approach2: AutoIt- Handles windows that do not belong to browser
          photo.Click();
          FileUploadbtn.Click();           
          AutoItX3 AutoIt = new AutoItX3();
          AutoIt.ControlFocus("Open","", "Edit1");
          Thread.Sleep(2000);
          AutoIt.ControlSetText("Open","","Edit1", @"C:\Users\Shahabuddin\Desktop\Rumana\house2_image.jpg");
          Thread.Sleep(1000);
          AutoIt.ControlClick("Open","","Button1");
                      
          //Click on Next button
          NextbtnProptertyDetails.Click();
          // ************Financialdetails***************
          //Enter Purchase Price
          purchaseprice.SendKeys(Global.ExcelLib.ReadData(2, "PurchasePrice"));
          //Enter Mortgage
          Mortgage.SendKeys(Global.ExcelLib.ReadData(2, "Mortgage"));
          //HomeValue
          HomeValue.SendKeys(Global.ExcelLib.ReadData(2, "HomeValue"));
          //Click on Home Value Type drop down
          HomeValueType.Click();
          //Select Home Value type
          HomeValueTypeSelection.Click();
          //Click on Add Repayment button
          AddRePayment.Click();
          //Enter Amount
          RePaymentAmount.SendKeys(Global.ExcelLib.ReadData(2,"RepaymentAmount"));
          //Enter RepaymentStartDate
          RePaymentStartdate.Clear();
          RePaymentStartdate.SendKeys("26/05/2018");
          Thread.Sleep(500);
          //Enter RepaymentEndDate
          RePaymentEnddate.Clear();
          RePaymentEnddate.SendKeys("29/06/2018");
          Thread.Sleep(500);
          //Click on Add Expense link
          AddExpense.Click();
          //Enter Expense Amount
          ExpenseAmount.SendKeys(Global.ExcelLib.ReadData(2,"ExpenseAmount"));
          // Enter Expense Description
          ExpenseDescription.SendKeys(Global.ExcelLib.ReadData(2,"ExpenseDescription"));
          //Enter date for ExpenseDate
          //ExpenseDateCalender.Clear();
          ExpenseDateCalender.SendKeys("30/06/2018");
          Thread.Sleep(500);
          //Click on Next button
          NextbtnFinanceDetails.Click();
          // ************Tenantdetails***************
          //Enter TenantEmail
          TenantEmail.SendKeys(Global.ExcelLib.ReadData(2,"TenantEmail"));
          //Click on IsmainTenant
          IsMainTenant.Click();
          //Select IsmainTenant
          IsMainTenantSelectYes.Click();
          //Enter Tenant FirstName
          TenantFirstName.SendKeys(Global.ExcelLib.ReadData(2, "TenantFirstName"));
          //Enter Tenant LastName
          TenantLastName.SendKeys(Global.ExcelLib.ReadData(2, "TenantLastName"));
          //Enter Tenant StartDate
          TenantStartDate.Clear();
          TenantStartDate.SendKeys("20/06/2018");
          //Enter Tenant EndDate
          TenantEndDate.Clear();
          TenantEndDate.SendKeys("30/09/2018");
          //Enter TenantRentAmount
          TenantRentAmount.SendKeys(Global.ExcelLib.ReadData(2, "TenantRentAmount"));
          Thread.Sleep(1000);
          //Click on PaymentfrequencyDropdown
          //PaymentFrequencydropdown.Click();
          //Select Monthly from PaymentFrequencyDropdown
          //PaymentFrequencydropdownMonth.Click();
          //TenantPaymentStartdate
          TenantPaymentStartdate.Clear();
          TenantPaymentStartdate.SendKeys("10/07/2018");
          Thread.Sleep(1000);
          //Click on PaymentDueDay drop down
          //PaymentDueDayDropdown.Click();
          //Select PaymentDueDay value
          //PaymentDueDayDropdownvalue.Click();
          //Click on AddNewLiabilityLink
          AddNewLiability.Click();
          //Click on LiabilityNameDropDown
          // LiabilityNameDropdown.Click();
          //Select Liability Name Dropdown value
          //LiabilityNameDropdownInsurance.Click();
          //Enter LiabilityAmount
          //LiabilityAmount.SendKeys(Global.ExcelLib.ReadData(2,"LiabilityAmount"));
          try
          {
              Assert.IsTrue(SavePropertyButton.Displayed);
          }
          catch (Exception e)
          {
              Console.Write(e);
          }
          //Click on Save button
          SavePropertyButton.Click();
          //Add Property Verification
          //Click on Owners tab
          Owners.Click();
          //Click Properties option
          Properties.Click();
          string msg1 = Global.GlobalDefinition.driver.FindElement(By.XPath("//*[@id='main-content']/section/div[1]/div/div[3]/div/div[1]/div/div/div[2]/div[1]/div[1]/a/h3")).Text;
          string Actmsg = Global.ExcelLib.ReadData(2, "CreatePropertyVerification");
          Thread.Sleep(2000);
          if(msg1==Actmsg)
          { 
          Global.Base.test.Log(LogStatus.Pass, "Test Passed, Record has been created successfully");
          Global.SaveScreenShotClass.SaveScreenshot(Global.GlobalDefinition.driver, "PropertyListAdded");
          }
          else
          {
           Global.Base.test.Log(LogStatus.Pass, "Test Failed, Record has not created");
          }
           
        }

        //Edit a Property
        internal void EditProperty()
        { 
         
          Global.ExcelLib.PopulateInCollection(Config.PropertyManagementResource.ExcelPath, "Property");
          //Explicit Wait
          Thread.Sleep(1000);
          //Click on Owners tab
          Owners.Click();
          //Click Properties option
          Properties.Click();
          // Explicit Wait
          Thread.Sleep(1000);
          // Click on the menu
          menulink.Click();
          // Explicit Wait
          Thread.Sleep(1000);
          //Click on Edit Button
          EditBtn.Click();
          Thread.Sleep(500);
          //Modify Property Name
          EditPropertyName.Clear();
          EditPropertyName.SendKeys(Global.ExcelLib.ReadData(2,"PropertyName_Modified"));
          EditDescription.Clear();
          EditDescription.SendKeys(Global.ExcelLib.ReadData(2,"Description_Modified"));
          Thread.Sleep(1000);
          EditCar.SendKeys(Global.ExcelLib.ReadData(2, "Car_Modified"));
          Thread.Sleep(1000);
          // Approach 1 to upload file
          ChooseFilesbtn.SendKeys(@"C:\Users\Shahabuddin\Desktop\Rumana\house1_image.png");
          Thread.Sleep(1000);
          /*
          //File Upload Approach2: AutoIt- Handles windows that do not belong to browser
          FileUploadbtn.Click();
          AutoItX3 AutoIt = new AutoItX3();
          AutoIt.ControlFocus("Open", "", "Edit1");
          Thread.Sleep(2000);
          AutoIt.ControlSetText("Open", "", "Edit1", @"C:\Users\Shahabuddin\Desktop\Rumana\Afraz.jpg");
          Thread.Sleep(1000);
          AutoIt.ControlClick("Open", "", "Button1");
          */
          EditSaveBtn.Click();
          //Verification
          //Click on Owners tab
          Owners.Click();
          //Click Properties option
          Properties.Click();
          string msg2 = Global.GlobalDefinition.driver.FindElement(By.XPath("//*[@id='main-content']/section/div[1]/div/div[3]/div/div[1]/div[2]/div[1]/div[1]/a/h3")).Text;
          string Actmsg2 = Global.ExcelLib.ReadData(2,"EditPropertyVerification");
          Thread.Sleep(2000);
          if (msg2 == Actmsg2)
          {
            Thread.Sleep(200);
            Global.Base.test.Log(LogStatus.Pass, "Test Passed, Record has been updated successfully");
            Global.SaveScreenShotClass.SaveScreenshot(Global.GlobalDefinition.driver, "PropertyListEdited");
          }

          else
          {
             Thread.Sleep(200);
             Global.Base.test.Log(LogStatus.Pass, "Test Failed, Record has not updated");
          } 

        }
        // Detete a Property
        internal void DeleteProperty()
        {
            //Click on Owners tab
            Owners.Click();
            //Click Properties option
            Properties.Click();
            Thread.Sleep(1000);
            menulink.Click();
            Thread.Sleep(1000);
            //Click on Delete button
            Delete.Click();
            Thread.Sleep(1000);
            DeleteConfirmbtn.Click();
            string delhouse = Global.GlobalDefinition.driver.FindElement(By.XPath("//*[@id='main-content']/section/div[1]/div/div[3]/div/div[1]/div/div/div[2]/div[1]/div[1]/a/h3")).Text;
            if (File.Exists(delhouse))
            {
                Thread.Sleep(200);
                Global.Base.test.Log(LogStatus.Fail, "Test Failed, Record has not deleted");
                
            }
            else
            {
                Thread.Sleep(200);
                Global.Base.test.Log(LogStatus.Pass, "Test Passed, Record has been deleted successfully");
                Global.SaveScreenShotClass.SaveScreenshot(Global.GlobalDefinition.driver, "PropertyListDeleted");
            }
        }

        // Sort Property
        internal void SortProperty()
        {
            //Click on Owners tab
            Owners.Click();
            //Click Properties option
            Properties.Click();
            //Click on Sortbydropdown
            SortByDropdown.Click();
            Thread.Sleep(500);
            //Click on SortByName
            SortByName.Click();
            Thread.Sleep(500);
            //Click on Sortbydropdown
            SortByDropdown.Click();
            Thread.Sleep(1000);
            //Click on SortByNameDesc
            SortByNameDesc.Click();
            Thread.Sleep(500);
            //Click on Sortbydropdown
            SortByDropdown.Click();
            Thread.Sleep(500);
            //Click on SortByLatestdate
            SortByLatestDate.Click();
            Thread.Sleep(500);
            //Click on Sortbydropdown
            SortByDropdown.Click();
            Thread.Sleep(500);
            //Click on SortByEarliestdate
            SortByEarliestDate.Click();
            Thread.Sleep(500);
        }

        // Search a Property
        internal void SearchProperty()
        {
            //Click on Owners tab
            Owners.Click();
            //Click Properties option
            Properties.Click();
            Thread.Sleep(1000);
            Searchbox.SendKeys("Rumana");
            Searchbtn.Click();
        }
        // Pagination
        internal void Pagination()
        {
            //Click on Owners tab
            Owners.Click();
            //Click Properties option
            Properties.Click();
            Thread.Sleep(1000);
            //Click on Next Page
            NextPagePagination.Click();
            Thread.Sleep(1000);
            //Click on Previous Page
            PreviousPagePagination.Click();
            Thread.Sleep(1000);
            //Click on a Page number
            PaginationNumber.Click();
            Thread.Sleep(1000);
            //Click on Last Page
            LastPagePagination.Click();
            Thread.Sleep(1000);
            //Click on First Page
            FirstPagePagination.Click();

        }

       
    }
}
