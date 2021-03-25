Feature: SpecFlowFeature


@mytag
Scenario Outline: Nederlandse Spoorwegen
	Given de gebruiker is op de ns website
	When gebruiker voert <vertrekpunt> in
	And gebruiker vult zijn <bestemming> in
	And gebruiker klik op plannen om een reis uit te kiezen
	Then de gebruiker heeft de prijs van de reis gevonden

	Examples: 
	| vertrekpunt | bestemming |
	| Amsterdam   | Utrecht    |


@mytag
Scenario Outline: Nederlandse Spoorwegen volgende dag boeken
	Given de gebruiker is op de ns website
	When gebruiker voert <vertrekpunt> in
	And gebruiker vult zijn <bestemming> in
	And gebruiker vult in de <datum>

	Examples: 
	| vertrekpunt | bestemming | datum    |
	| Amsterdam   | Utrecht    | 30 maart 2021 |