using NUnit.Framework;
using PropertyManagement.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PropertyManagement
{
    public class Program
    {
        [TestFixture]

        class PropertyOwner : Global.Base
        {
            //Test case 1
            [Test]
            public void CreatingProperty()
            {
                //Start the Add 
                test = extent.StartTest("Adding the Property");
                //Creating a Class
                PropertyManage obj = new PropertyManage();

                //Creating Method
                obj.CreateProperty();
            }
           
            //Test case 2
            [Test]
            public void EditingProperty()
            {
                //Start the Edit 
                test = extent.StartTest("Editing the Property");
                //Creating a Class
                PropertyManage obj = new PropertyManage();
                //Creating Method
                obj.EditProperty();
            }

            // Test case 3
            [Test]
            public void DeletingProperty()
            {
                //Start the Delete
                test = extent.StartTest("Deleting the Property");

                //Creating a Class
                PropertyManage obj = new PropertyManage();

                //Creating Method
                obj.DeleteProperty();

            }


            // Test case 4
            [Test]
            public void SortingProperty()
            {
                //Start the Delete
                test = extent.StartTest("Sorting the Property");

                //Creating a Class
                PropertyManage obj = new PropertyManage();

                //Creating Method
                obj.SortProperty();

            }

            // Test case 4
            [Test]
            public void SearchingProperty()
            {
                //Start the Delete
                test = extent.StartTest("Searching the Property");

                //Creating a Class
                PropertyManage obj = new PropertyManage();

                //Creating Method
                obj.SearchProperty();

            }

            //Test case 5
            [Test]
            public void PaginationProperty()
            {
             
                //Creating a Class
                PropertyManage obj = new PropertyManage();

                //Creating Method
                obj.Pagination();
            }

            //Test case 6
            [Test]
            public void AcceptingTenantRequest()
            {
                //Creating a Class
                TenantRequest obj = new TenantRequest();

                //Creating Method
                obj.AcceptTenantRequest();
            }

            //Test case 7
            [Test]
            public void DecliningTenantRequest()
            {
                //Creating a Class
                TenantRequest obj = new TenantRequest();

                //Creating Method
                obj.DeclineTenantRequest();
            }

            //Test case 8
            [Test]
            public void ShowingAcceptedTenantRequest()
            {
                //Creating a Class
                TenantRequest obj = new TenantRequest();

                //Creating Method
                obj.ShowAcceptedTenantRequest();
            }

            //Test case 8
            [Test]
            public void ShowingDeclinedTenantRequest()
            {
                //Creating a Class
                TenantRequest obj = new TenantRequest();

                //Creating Method
                obj.ShowDeclinedTenantRequest();
            }

            //Test Case 9
            [Test]
            public void NewUserRegistration()
            {
                //Creating a Class
                Registration obj = new Registration();

                //Creating Method
                obj.UserRegistration();
            }
            
        }
    }
    }
