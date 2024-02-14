Feature: SpecFlowMenuTests
	In order to easily find needed documentation
	As a specflow user
	I want to be able to navigate to pages through main menu

Scenario: Clicking menu option from the main menu should open corresponding page
	Given I open official SpecFlow web site
	When I hover the Docs menu item from the main menu while I click SpecFlow option from the main menu
	And i enter Installation into the search field
	Then Page with Installation title should be opened