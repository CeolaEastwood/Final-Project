using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}


/*
1.	Create Book class.
a.	Auto-implemented properties
i.	ISBN (text)
ii.	Title (text)
iii.	AuthorInfo (Author)
iv.	PublishedOn(date)
v.	PublishedBy(text)
b.	Constructor
i.	One constructor that takes ISBN, Title and AuthorInfo. 
1.	Sets PublishedOn to current date and PublishedBy to Unknown
ii.	One constructor that takes ISBN, Title, AuthorInfo, PublishedOn and PublishedBy
iii.	When using multiple constructors, use “constructor chaining” 
c.	Methods
i.	Display()
1.	Method takes no arguments
2.	Method displays book info. See sample below:
Book 'Harry Potter Book 1' was written by Joanne Rowling and published on 1/1/1997
*/
