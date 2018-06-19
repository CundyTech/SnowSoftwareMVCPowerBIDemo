Feature: ReportNavigation
	When I click on the report navigation menu item
	I expect the page to navigate to the report page.

@NavigateToVersionsReport
Scenario: Navigate To Versions Report Page From Dashboard Page
	Given I am on the ("dashboard") page
	When I press click on the VersionsReport menu item
	Then the site should navigate to the ("versionsreport") page

	@NavigateToUserReport
Scenario: Navigate To User Report Page From Dashboard Page
	Given I am on the ("dashboard") page
	When I press click on the UserReport menu item
	Then the site should navigate to the ("userreport") page