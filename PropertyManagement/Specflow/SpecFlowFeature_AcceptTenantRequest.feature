Feature: SpecFlowFeature_AcceptTenantRequest
	

@accepttenantrequest
Scenario: Check if user can accept tenant request
	Given I have logged into the property application
	When I accept the tenant request
	Then I will shutdown the open browser
