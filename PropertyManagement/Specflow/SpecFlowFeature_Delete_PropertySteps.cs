using System;
using TechTalk.SpecFlow;

namespace PropertyManagement.Specflow
{
    [Binding]
    public class SpecFlowFeature_Delete_PropertySteps:Global.Base
    {
        [Given(@"I have logged in the property web application")]
        public void GivenIHaveLoggedInThePropertyWebApplication()
        {
            Initialize();
        }
        
        [When(@"I delete a property")]
        public void WhenIDeleteAProperty()
        {
            //Start the Delete
            test = extent.StartTest("Deleting the Property");

            //Creating a Class
            PropertyManage obj = new PropertyManage();

            //Creating Method
            obj.DeleteProperty();
        }
        
        [Then(@"I can close the browser")]
        public void ThenICanCloseTheBrowser()
        {
            TearDown();
        }
    }
}
