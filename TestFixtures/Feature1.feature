Feature: Login Feature

A short summary of the feature


Scenario: Successfull Login with Valid credentials
	Given Launch URL
	When I enter valid user name and password
	Then I should be navigated to Dashboard Page
