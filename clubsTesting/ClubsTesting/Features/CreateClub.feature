Feature: Create a Club 
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)

Link to a feature: [Calculator](ClubsTesting/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Creating a club with no members

	Given I logged into COTW
    And   I select Create Club
	And   I enter a club Name (the club name does not need $club$ as this is added in the background)
	And   I select Type of Club
	And   I do not select any Club Members
	When  I click Save
	Then  I am re directed to Active Clubs
	And   I see a toast message
	And   the club I created is selected
	And   the balance summary is NOT shown

Scenario: Searching a Member under Members 

	Given I logged into COTW 
    And   I select Create Club
	When  I type a search in the search bar for club members  
	Then  the list of members is filtered and search is shown and can be selected 
	And   I can add the member to the club  
	
Scenario: Searching Club Member under Groups

	Given I logged into COTW
    And   I select Create Club
	When  I Click on Club Groups
	And   I type a search in the search bar for club groups  
	Then  the list of Groups are filtered and search is shown and can be selected
	And   I can add the group to the club  



	