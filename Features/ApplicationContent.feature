Feature: ApplicationContent

@regression
Scenario: HomepageContent
	Given Open application homepage
	Then Application homepage is opened
	And Main header equals Maksymilian Spertusiak
	Then Following navbar elements are visible
		| ElementName |
		| Home        |
		| Życiorys    |
		| Usługi      |
		| Kontakt     |

@regression
Scenario: SubpageContent
	Given Open application homepage
	Then Application homepage is opened
	When Click Życiorys button from navbar
	Then Życiorys subpage is opened
	When Click Usługi button from navbar
	Then Usługi subpage is opened
	When Click Kontakt button from navbar
	Then Kontakt subpage is opened