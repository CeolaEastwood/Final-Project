
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

using System;
using System.Collections.Generic;

  class Patron: Person {

  //properties

public List<Rental> RentalList = new List<Rental>();

public string LibraryId { get; set; } 
public virtual DateTime EndDate { get; set; } 
public virtual DateTime StartDate { get; set; } 
bool IsAccountActive { get; set; } 
float FineAmountDue { get; set; } 

//constructor
public Patron(string fname, string lname, string libraryid) : base(fname, lname) {

LibraryId =libraryid;
FineAmountDue = 0;
//IsAccountActive = true;
//StartDate = DateTime.Today;

Console.WriteLine("Patron");
  }

// Method
public void PatronDisplay(){

  Console.WriteLine("Patron ID = "+ LibraryId);
  Console.WriteLine("Patron Name = "+ FirstName +" "+ LastName);

}

public void AddToRentalCart(Book RentalBook, DateTime DateDue){
  Rental z = new Rental(RentalBook, DateDue);
  RentalList.Add(z);

    Console.WriteLine("Added to rental cart: "+ RentalBook.Title + " for Patron "+ FirstName + " " + LastName);
  }

public void RemoveFromRentalCart(Book RentalBook){
  int index = 0;
  while (index < RentalList.Count) {

      if (RentalList[index].RentalBook.ISBN == RentalBook.ISBN) 
        RentalList.RemoveAt(index);
        index += 1;
      }
      Console.WriteLine("Removed from rental cart: "+ RentalBook.Title + " for Patron "+ FirstName + " "+ LastName);
    }
  }

 