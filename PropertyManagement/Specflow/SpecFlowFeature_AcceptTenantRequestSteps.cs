using System;
using TechTalk.SpecFlow;

namespace PropertyManagement
{
    [Binding]
    public class SpecFlowFeature_AcceptTenantRequestSteps:Global.Base
    {
        [Given(@"I have logged into the property application")]
        public void GivenIHaveLoggedIntoThePropertyApplication()
        {
            Initialize();
        }
        
        [When(@"I accept the tenant request")]
        public void WhenIAcceptTheTenantRequest()
        {
            //Creating a Class
            TenantRequest obj = new TenantRequest();

            //Creating Method
            obj.AcceptTenantRequest();
        }
        
        [Then(@"I will shutdown the open browser")]
        public void ThenIWillShutdownTheOpenBrowser()
        {
            TearDown();
        }
    }
}
