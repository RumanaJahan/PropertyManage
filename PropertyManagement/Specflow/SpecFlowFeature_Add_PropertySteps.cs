using System;
using TechTalk.SpecFlow;

namespace PropertyManagement.Specflow
{
    [Binding]
    public class SpecFlowFeature_Add_PropertySteps:Global.Base
    {
        [Given(@"I have logged into the application")]
        public void GivenIHaveLoggedIntoTheApplication()
        {
            Initialize();
        }
        
        [When(@"I create a new property")]
        public void WhenICreateANewProperty()
        {
            //Start the Add 
            test = extent.StartTest("adding the Property");
            //Creating a Class
            PropertyManage obj = new PropertyManage();

            //Creating Method
            obj.CreateProperty();
        }
        
        [Then(@"I will close the browser")]
        public void ThenIWillCloseTheBrowser()
        {
            TearDown();
        }
    }
}
