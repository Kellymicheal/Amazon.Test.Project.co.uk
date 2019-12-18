Feature: CustomerCanSearchForItemOfTheirChoice
	In order to buy an item of my choice
	As a customer
	I want the ability to search for an item of my choice 


Scenario Outline:Customer can searchn for an item of their choice. 
	Given I navigate to amazon homepage 
	When I enter "<product>" to searchfield
	And i click on Submitbutton
	Then new "<product>" should displayed 


Scenarios:
 | product         |
 | trousers        |
 | bicycle carrier |