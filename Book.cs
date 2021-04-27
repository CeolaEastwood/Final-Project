
/*
TO DO
1. DateTime questions = DateTime.Today.Year?
2. “constructor chaining” 
3. blank constructer
4. I think only one method?
5. Check date format as well/validation?


1. DONE 
create book class.

DONE
a.	Auto-implemented properties
i.	ISBN (text)
ii.	Title (text)
iii.	AuthorInfo (Author)
iv.	PublishedOn(date)
v.	PublishedBy(text)

Mstly DONe
b.	Constructor
i.	One constructor that takes ISBN, Title and AuthorInfo. 
  1.	Sets PublishedOn to current date and PublishedBy to Unknown (no parameter?)
ii.	One constructor that takes ISBN, Title, AuthorInfo, PublishedOn and PublishedBy
iii.	When using multiple constructors, use “constructor chaining” 

Probaly Done
c.	Methods (means only one method..)
i.	Display() 
  1.	Method takes no arguments
  2.	Method displays book info. See sample below:
Book 'Harry Potter Book 1' was written by Joanne Rowling and published on 1/1/1997
*/


using System;
using System.Collections.Generic;

class Book {

      //Auto-implemented properties
    
      public string Title { get; set; }
      public string ISBN { get; set; }
      public string AuthorInfo { get; set; } 
      public virtual DateTime PublishedOn { get; set; }
      public string PublishedBy { get; set; }
    

    //Constructors

  public Book() {    
    Title="Unknown";
    ISBN="Unknown";
    PublishedBy="Unknown";
    PublishedOn = DateTime.Today;
  }


//contructer chaining here?

  public Book (string title, string isbn, string authorinfo){  
    Title = title;
    ISBN = isbn;
    AuthorInfo = authorinfo;
    //PublishedBy="Unknown";
    //PublishedOn = DateTime.Today;
  }

  public Book (string title, string isbn, string authorinfo, DateTime published_on, string published_by) {
    Title = title;
    ISBN = isbn;
    AuthorInfo = authorinfo;
    PublishedOn=published_on;
    PublishedBy=published_by;
  }

  //Methods

  public void Display() { //Not sure if this should be static?
    Console.WriteLine ("Book: " + Title + " was written by " + AuthorInfo + " was published on " + PublishedOn);
  }


  //public BlankDisplay()


}