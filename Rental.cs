
/* I think this is done
1. Create Rental class
•	Properties
a.	Book (Book object)
b.	DateRented (Date)
c.	DateDue (Date)
•	Constructor
a.	One constructor that takes 3 parameters
•	Methods
a.	None
*/

using System;
using System.Collections.Generic;

class Rental {

//Properties
public string RentalBook { get; set; } 
public virtual DateTime DateRented { get; set; }
public virtual DateTime DateDue{ get; set; }

//Constructor

public Book (string rentalbook, DateTime daterented, DateTime datedue{  

    RentalBook = rentalbook;
    DateRented = daterented;
    DateDue = datedue;
  }