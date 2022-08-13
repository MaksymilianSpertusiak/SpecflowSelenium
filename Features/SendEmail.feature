Feature: SendEmail

@regression
Scenario: ContactForm
	Given Open application homepage
	Then Application homepage is opened
	When Click Kontakt button from navbar
	Then Kontakt subpage is opened
	When Populate Contact form using following data
		| name                   | email                           | message            |
		| Maksymilian Spertusiak | test_email1234_99@test12390.com | Example Email body |
	And Click Wyślij wiadomość button
	Then "Please click on the reCAPTCHA box." validation error is displayed