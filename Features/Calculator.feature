Feature: Calculator Feature
  In order to perform basic arithmetic operations
  As a user
  I want to be able to add/substract/divide/multiply two numbers

Simple calculator for adding two numbers

@calculator @smoke @bvt @regression
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Subtract two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are subtracted
	Then the result should be 20

Scenario: Multiply two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are multiplied
	Then the result should be 3500

Scenario: Divide two numbers
	Given the first number is 50
	And the second number is 2
	When the two numbers are divided
	Then the result should be 25