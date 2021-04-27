/*
TO DO
1. Fix DateTime?

In main.cs, test the following:

DONE maybe
•	Create 2 authors (without creating books inside Authors)
a.	Call DisplayInfo for Author 1
b.	Call DisplayInfo for Author 2

NOPE
•	Create 6 books
a.	Use first constructor for the first 3 and second constructor for the other 3 books
b.	Books 1,3,5 should be set to have AuthorInfo as  Author 1
c.	Books 2,4,6 should be set to have AuthorInfo as  Author 2

SET UP IS mostly DONE
•	Connecting Books to Author
a.	Add books 1, 3, 5 to Author 1.
b.	Display books of Author 1

c.	Add books 2,4,6 to Author 2.
d.	Display books of Author 2

e.	Remove book #1 from Author #1
f.	Display books of Author 1.

part 2

In Program.cs, test the following:
•	Create 5 patrons
•	Add book 1 to Patron 1’s rentalcart by calling the AddToRentalCart method
•	Remove book 3 from Patron 1’s rentalcart by calling the RemoveFromRentalCart method
•	Display patron info

*/

using System;
using System.Collections.Generic;


class MainClass { 

  public static void Main (string[] args) {

  //Creating 6 Books

  Book b1 = new Book ("Something Wicked This Way Comes", "ISBN-0380729407", "Ray Bradbury" );
  Book b3 = new Book ("The Martian Chronicles", "ISBN-9781451678192", "Ray Bradbury" );
  Book b5 = new Book ("The October Country: Stories", "ISBN-034532448X", "Ray Bradbury" );
  Book b2 = new Book ("The Ghost Brigades", "ISBN-B001QS9TSE", "John Scalzi", Convert.ToDateTime("04/10/2010"), "TorBooks" );
  Book b4 = new Book ("Old Man's War", "ISBN-B000SEIK2S", "John Scalzi", Convert.ToDateTime("04/01/2007"), "TorBooks" );
  Book b6 = new Book ("The Last Colony", "ISBN-B000YJ85BI", "John Scalzi", Convert.ToDateTime("04/17/2012"), "TorBooks" );


   //Author 1
  author Ray = new author("Ray", "Bradbury", "R_B@gmail.com");
  Ray.DisplayInfo();
  Ray.AddBook(b1);
  Ray.AddBook(b3);
  Ray.AddBook(b5);
  Ray.DisplayBooks();
  Ray.RemoveBook(b1); 
  Ray.DisplayBooks();
  
  
  //Author 2
  author John = new author("John", "Scalzi", "j_s@gmail.com");
  John.DisplayInfo();
  John.AddBook(b2);
  John.AddBook(b4);
  John.AddBook(b6);
  John.DisplayBooks();

 
  }  
}
