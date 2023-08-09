Feature: EditClubName

A short summary of the feature



Scenario: Renaming an existing club with no member 

	
	Given I logged into COTW 
    And   I select Create Club
	And   I enter a club Name (the club name does not need $club$ as this is added in the background)
	And   I select Type of Club
	And   I do not select any Club Members
	When  I click Save
	Then  I am re directed to Active Clubs
	And   I see a toast message
	And   the club I created is selected
	And   I click Edit
	And   I change the Club name
	When  I Click on Club Groups
	And   I type a search in the search bar for club groups  
	Then  the list of Groups are filtered and search is shown and can be selected
	And   I can add the group to the club  
	Then  the list of Groups are filtered and search is shown and can be selected
	And   I can add the group to the club  
	When  I click Save
	Then  I am re directed to Active Clubs
	And   I see a toast message that club name is saved
	And   the club I edited is selected with the new name
	And   the balance summary is shown
	And   the members I added are shown in the summary