using System;
using TechTalk.SpecFlow;

namespace PropertyManagement.Specflow
{
    [Binding]
    public class SpecFlowFeature_DeclineTenantRequestSteps:Global.Base
    {
        [Given(@"I logged into the property community keys project")]
        public void GivenILoggedIntoThePropertyCommunityKeysProject()
        {
            Initialize();
        }
        
        [When(@"I decline the tenant request")]
        public void WhenIDeclineTheTenantRequest()
        {
            //Creating a Class
            TenantRequest obj = new TenantRequest();

            //Creating Method
            obj.DeclineTenantRequest();
        }
        
        [Then(@"I will be able to shut down the browser")]
        public void ThenIWillBeAbleToShutDownTheBrowser()
        {
            TearDown();
        }
    }
}
