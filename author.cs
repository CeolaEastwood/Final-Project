using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}



/*
2.	Create Author class and inherit from Person.
a.	Properties
i.	Books (List of “Book” object) (declare as private)
b.	Constructors
i.	Use the same as person class and call the base
c.	Methods
i.	DisplayInfo
1.	Method will not take parameters
2.	Method will not return a value
3.	Method will display the firstname, lastname and email
ii.	DisplayBooks
1.	Method will not take parameters
2.	Method will not return a value
3.	Method will loop through the Books list using foreach and call the Display method of Book class
iii.	AddBook
1.	Method takes 1 parameter of type Book
2.	Method will add the book to the Books list
3.	Method will set the book’s AuthorInfo (firstname and lastname) to the author’s firstname and lastname
iv.	RemoveBook
1.	Method takes 1 parameter of type text (ISBN)
2.	Method will find the book using the Find method (matching the ISBN to the book’s ISBN)
3.	Then Method will Remove the book from the List.
*/