Feature: SpecFlowFeature_Delete_Property
	

@Delete
Scenario: Check if user can delete property
	Given I have logged in the property web application
	When I delete a property
	Then I can close the browser
