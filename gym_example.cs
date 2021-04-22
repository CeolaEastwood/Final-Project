/*using System;

class GymMember{

  private string id;
  private string firstname;
  private string lastname;
  private DateTime dateOfBirth;
  private DateTime dateOfJoining;
  private int height;
  private int weight;
  private DateTime lastAccessed;
  private string emailAddress;
  private int points;

  //Properties
  public string FirstName {get; set;}
  public string LastName {get; set;}
  public DateTime DateOfJoining {get; set;}

  public string Id{
    get{return id;}
    set{
        if (value.Length == 5){
          id = value;
        }        
        else{
          Console.WriteLine("Rejected id");
        }
    }
  }

 public int Height{
    get{return height;}
    set{
        if (value>0)
        {
          height = value;
        }        
        else{
          Console.WriteLine("Rejected height");
        }
    }
  }

  public int Weight{
    get{return weight;}
    set{
        if (value>0)
        {
          weight = value;
        }        
        else{
          Console.WriteLine("Rejected weight");
        }
    }
  }
//Constructors
  public GymMember()
  {    
    FirstName="Unknown";
    LastName="Unknown";
    points = 10;
  } */