/*
TO DO
1. 

DONE
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


using System;
using System.Collections.Generic;

  class author: Person {

  //Properties
  public List<Book> BookList = new List<Book>();

  //Constructor

  public author(string fname, string lname, string email) : base(fname, lname) {
    Email = email;
    Console.WriteLine("Author");
  }

  //Methods

  public void DisplayInfo () {

    Console.WriteLine("My name is " + FirstName + " " + LastName + " and you can contact me at " + Email);
  }

  public void DisplayBooks() {

    foreach (Book n in BookList)
    { 
      //BookList  = n1();
      //var a = new Book();
      n.Display();

      //Cant get this section to referance
      //Book.Display();
      //Console.WriteLine(n.Display());

      //I can get this to display but can't get the referances to pass via Display
      //Console.WriteLine("{0}{1}{2}", n.novel.Title, n.novel.ISBN, n.novel.AuthorInfo );
    }
  }

  public void AddBook (Book b){
    BookList.Add(b);
  }

  public void RemoveBook(Book b){
    Book a = BookList.Find(o=>o.ISBN == b.ISBN);
    BookList.Remove(a);
  }

}