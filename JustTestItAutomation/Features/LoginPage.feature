Feature: LoginPage
	As a user i can login in to website

@Automate @positive
Scenario: I can login with valid username and password and Navigate to Home page
	Given I have navigated to the application
	And I login with valid user
	|Username	|Password|
	|Sarika		|A@aa1234 |
	Then I can validate user name with "Hi, Sarika"

@Automate @negative
Scenario: I can not login with invalid username and password
	Given I have navigated to the application
	And I login with valid user
	|Username	|Password|
	|CCCCC		|C@cc1234 |
	Then I can not login and get message "Invalid username/password"
	