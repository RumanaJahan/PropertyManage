Feature: SpecFlowFeature_Add_Property

@Add
Scenario: Check if user can add new property
	Given I have logged into the application
	When I create a new property
	Then I will close the browser
