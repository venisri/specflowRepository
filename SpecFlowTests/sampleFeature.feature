﻿Feature: sampleFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	@smokeTest
Scenario: Book a flight based on destination

Given I'm on the Transavia Home page
And I have entered a 'From' and 'To' destination
When I press on the search button
Then the results should only display flights for the concerning destination

@RegressionTest
Scenario: Book a flight based on destination and date

Given I'm on the Transavia Home page
And I have entered a 'From' and 'To' destination
And I have also entered a depart and return date
When I press on the search button
Then all available flights should appear for the concerning destination within the specified date

@negativeTest
Scenario: Field "To" cannot be empty

Given I'm on the Transavia Home page
And I have entered a departure airport
When I press on the search button
Then a warning message should appear saying that the field "To" is mandatory

@negativeTest
Scenario: 'Depart on' field should be filled by default

Given I'm on the Transavia Home page
When the user reaches the 'Depart on' field
Then the field should be prefilled with the date of tomorrow
And it should be possible to adjust the date

@UITest
Scenario: 'Return on' checkbox should replace date with text

Given I'm on the Transavia Home page
When I uncheck the 'Return on' checkbox
Then the 'Return on' date field should be filled with the text 'Single flight'

@RegressionTest
Scenario: Search flight based on flight number

Given I'm on the Transavia Flight status page
And I have entered a valid flight number
When I press on the search button
Then the information of the concerning flight shoudl appear

