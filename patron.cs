
/*
2. Create Patron class and inherit from Person
•	Auto Implemented properties
o	LibraryId (String)
o	StartDate (Date)
o	EndDate (Date)
o	IsAccountActive (True/False)
o	RentalCart (List of Rental objects)
o	FineAmountDue (number)
•	Constructor
o	One constructor that takes first name, last name and id
o	Inside the constructor
	Set FineAmountDue to 0
	Set StartDate to Today’s date
	Set IsAccountActive to true
o	(Hint) Any time you inherit, call the base class constructor
•	Methods
o	Display
	Method does not take any parameter
	Method does not return any value
	Displays a message (See example below)
Patron Id=1111 Name=Tim Smith
•	AddToRentalCart
o	Method takes a book object and due date as input
o	Method does not return a value
o	Creates a new Rental object for the Book (input) and adds to the RentalCart list.
o	Method also displays a message (see example below)
Added to rental cart Harry Potter Book 1 for Patron TimSmith
•	RemoveFromRentalCart
o	Method takes a book object as input
o	Method does not return a value
o	Method also displays a message (see example below)
Removed from rental cart Harry Potter Book 2 for Patron TimSmith
*/