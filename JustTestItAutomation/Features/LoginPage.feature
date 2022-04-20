Feature: LoginPage
	As a user i can login in to website

@Automate
Scenario: I can login with valid username and password and Navigate to Home page
	Given I have navigated to the application
	And I login with valid user
	|Username	|Password|
	|Sarika		|A@aa1234 |
	Then I can validate user name with "Hi, Sarika"
	