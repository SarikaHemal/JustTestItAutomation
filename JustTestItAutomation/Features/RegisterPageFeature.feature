Feature: RegisterPageFeature
	Check if the Register functionality is working
	as expected with different permutations and 
	combinations of data

@Automate @positive
Scenario: Check if user can Register with valid data
	Given I have navigated to the application
	Then I click Register link
	Then  I  Register with following Data
	| Email               | FirstName | LastName | Password | ConfirmPassword |
	| Aaaa.baaa@gmail.com | Aaaa       | Baaa      | A@aa1234 | A@aa1234         |
	Then I should get message "Registration is successful" 

@Automate @negative
Scenario: Check user already exists
	Given I have navigated to the application
	Then I click Register link
	Then  I  Register with following Data
	| Email               | FirstName | LastName | Password | ConfirmPassword |
	| Aaaa.baaa@gmail.com | Aaaa       | Baaa      | A@aa1234 | A@aa1234         |
	Then I should get message "User already exist-Enter valid Data" 

	
@Automate
Scenario: Check cancel button working on register page
	Given I have navigated to the application
	Then I click Register link
	Then I click cancel button
	Then I navigate to HomePage
	