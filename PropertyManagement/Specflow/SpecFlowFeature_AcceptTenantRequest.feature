Feature: SpecFlowFeature_AcceptTenantRequest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@accepttenantrequest
Scenario: Check if user can accept tenant request
	Given I have logged into the property application
	When I accept the tenant request
	Then I will shutdown the open browser
