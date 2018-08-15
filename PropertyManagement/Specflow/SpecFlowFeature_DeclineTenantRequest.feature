Feature: SpecFlowFeature_DeclineTenantRequest


@declinetenantrequest
Scenario: Check if user can decline tenant request
	Given I logged into the property community keys project
	When I decline the tenant request
	Then I will be able to shut down the browser
