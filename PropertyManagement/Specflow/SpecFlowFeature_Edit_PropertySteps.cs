using System;
using TechTalk.SpecFlow;

namespace PropertyManagement
{
    [Binding]
    public class SpecFlowFeature_Edit_PropertySteps:Global.Base
    {
        [Given(@"I have logged in into the property application")]
        public void GivenIHaveLoggedInIntoThePropertyApplication()
        {
            Initialize();
        }
        
        [When(@"I edit propterty")]
        public void WhenIEditPropterty()
        {
            //Start the Edit 
            test = extent.StartTest("Editing the Property");
            //Creating a Class
            PropertyManage obj = new PropertyManage();
            //Creating Method
            obj.EditProperty();

        }

        [Then(@"I will shut down the browser")]
        public void ThenIWillShutDownTheBrowser()
        {
            TearDown();
        }
    }
}
