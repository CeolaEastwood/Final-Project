/*using System;

class BLah {
  public static void Main (string[] args) {

  //creating "new" Employees

//Employee 1
//Testing Class with default parameters
  Employee unknown = new Employee();
  unknown.Intro();

//Employee 2
//Testing Class with parameters 
  Employee Robert = new Employee ("Robert", "Downey", "12321", 12, 100);
  Robert.Intro();


//Employee 3
//Testing Class with parameters
  Employee John = new Employee ("John", "Smith", "S0089", 38, 50000);
  John.Intro();
  
//Testing IncreaseSalary Method & RemoveEmployee Method
  John.IncreaseSalary(-.02);
  John.RemoveEmployee();


//Employee 4
//Testing IncreaseSalary Method and RemoveEmployee Method (twice)
  Employee Maria = new Employee ("Maria", "Lambert", "S0100", 26, 80000);

  Maria.Intro();
  Maria.IncreaseSalary(.07);
  Maria.RemoveEmployee();
  Maria.RemoveEmployee();



  }
}
using System;
class Employee{
//Lab10 

//Creating Fields for Employee Info
  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private bool employmentstatus;



//CREATING PROPERTIES

//Creating Auto Implemented properties
  public string FirstName{get; set;}
  public string LastName{get; set;}
  public string Id{get; set;}
  public bool EmploymentStatus{get; set;}

//Creating Properites With Validation
  public int Age{
    get{ return age;}
    set{
      if (value>=18)
        age = value;

      else {
        age = 18;
        
      }    
    }
  }

  public double YearlySalary{
    get{ return yearlysalary;}
    set{
      if (value >1000)
      yearlysalary = value;

      else {
        yearlysalary = 1000;
        
      }    
    }
  }

  //creating default constructor 
  public Employee ()
  {
  FirstName = "unknown";
  LastName = "unknown";
  double AGE = 0;//this has issue
  Id = "unknown";
  
  }

  //constructor with parameters
  public Employee (string FName, string LName, string ID, int AGE, double YSalary)
  {
   FirstName = FName;
   LastName = LName;
   Id= ID;
   Age = AGE;
   YearlySalary = YSalary;
   //EmploymentStatus= EStatus;
  }

  //method to create new employee object
  public void Intro()
  {
   Console.WriteLine("First name is "+FirstName);
   Console.WriteLine("Last name is "+LastName);
   Console.WriteLine("Age = "+ Age);
   Console.WriteLine("ID = " + Id);
   Console.WriteLine("Year Salary = " + YearlySalary);
   
  }

  public void IncreaseSalary(double percent)
  {
    double PayBump = YearlySalary*percent;
    double total = YearlySalary + PayBump;
      {
      if (percent <=0)
        Console.WriteLine("Invalid Input. Salary not updated");

      else
        Console.WriteLine("Yearly Salary updated to "+ total);
      }
    
  }
  
  //if they are already removed = true
  public bool RemoveEmployee()
  {
      if (EmploymentStatus){
      Console.WriteLine("Employee already inactive");
      }

      else {
      Console.WriteLine("Employee has been removed!");
      EmploymentStatus = true;
      }

    return EmploymentStatus;
  }

  


} */