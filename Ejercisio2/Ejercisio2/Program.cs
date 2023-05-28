// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/*

// EJERCICIOS  C#

Console.WriteLine("Enter your first name");                 //Eje 1_ 

string name = Console.ReadLine();

Console.WriteLine("Hello " + name);
*/




/*
//03. variable int                       

int age = 45; 

// 04.
string input = Console.ReadLine();

// 05.
bool isActive = false;


//06.
decimal price = 100.0m;

//07.
const double profitMargin = 0.17;

//08.
string greeting = "Hello";


//09.
int a = 3;
int b = 5;
int c = a + b;



//10.
int a = 1;
a += 3;


//11.
char aChar = 'b';


//12.
char aChar = 'a';
bool isWhiteSpace = char.IsWhiteSpace(aChar);


//13.



//14.
long myLargeValue = 123456789;
int intValue = (int)myLargeValue;


//15
var a = 10;


*/

//EJERCICIO N° 2  Resumen de lo aprendido 
//suma de variables 
/*Console.WriteLine("Enter a first value:");
string stringValue1 = Console.ReadLine();

Console.WriteLine("Enter a second value:");
string stringValue2 = Console.ReadLine();

int intValue1 = int.Parse(stringValue1);
int intValue2 = int.Parse(stringValue2);

int var sum = intValue1 + intValue2;
*/



/* "2° parte de las lista de ejercicios 
 
//16.  
bool validAge = age > 18;


//17.
bool validAge = (age <= 65);


//18.
bool validAge = (age >= 18 && age <= 65); 


//19.
if (age > 18)
{
    Console.WriteLine("You are eligible");
    Console.WriteLine("Congratulations");
}

//20.
if (age > 18)
{
    Console.WriteLine("You are eligible");
    Console.WriteLine("Congratulations");
}
else
{
    Console.WriteLine("You aren't eligible");
    Console.WriteLine("Sorry");
}

//21.
int age = 18; // Ejemplo de valor de edad

if (age == 18)
{
    Console.WriteLine("You are eligible");
    Console.WriteLine("Congratulations");
}

//EJERCICIO N°3 RESUMEN de todo lo aprendido en el Modulo
Console.WriteLine("Enter a first number:");
string stringValue1 = Console.ReadLine();

Console.WriteLine("Enter a second number:");
string stringValue2 = Console.ReadLine();

int intValue1 = int.Parse(stringValue1);
int intValue2 = int.Parse(stringValue2);

if (intValue1 == intValue2)
{
    Console.WriteLine("The values are equal!");
}
else if (intValue1 < intValue2)
{
    Console.WriteLine("The first value is smaller!");
}
else
{
    Console.WriteLine("The second value is smaller!");
}

*/

/*
//Ejemplo de cadena interactiva

using System;

Console.WriteLine("Choose the action you want to do: ");
Console.WriteLine("1. Add employee");
Console.WriteLine("2. Update employee");
Console.WriteLine("3. Delete employee");
Console.WriteLine("99. Exit application");
string selectedAction = Console.ReadLine();

while (selectedAction != "99" )
{
    switch (selectedAction)
    {
        case "1":
            Console.WriteLine("Adding new employe...");
            break;
        case "2": Console.WriteLine("Updating employee...");
            break;
        case "3": Console.WriteLine("Deleting employee...");
            break;
        case "4": Console.WriteLine("Invalid input");
            break;

    }
    Console.WriteLine("Choose the action you want to do: ");
    Console.WriteLine("1. Add employee");
    Console.WriteLine("2. Update employee");
    Console.WriteLine("3. Delete employee");
    Console.WriteLine("99. Exit application");
    selectedAction = Console.ReadLine();
}
Console.WriteLine("Closing application");
*/



/*//Ej 23."While"

int i = 1;

while (i <= 10)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine(i); // muestra el valor de i, que es 11 después de salir del while loop
*/




/*//Ejercicio 4 Resumen "Loops"                 //en la consola me funciono en la pagina no.
Console.Write("Ingrese un número entero positivo: ");

int sum = 0;

string stringValue = Console.ReadLine();

int startValue = int.Parse(stringValue);

for (int i = startValue; i > 0; i--)
{
    sum += i;
}

Console.WriteLine("La suma es:" + sum);
*/


/* //Ej 24. "for"
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
*/

/* //Ej 25. "Methods"
 public static int SubtractTwoNumbers(int a, int b)
{
  int result =  a - b;
    return a - b;
} 
 */

/* //Ej 26 "Methods invocation"
 int sum = AddNumbers(5, 2);

 */


/* // "EJERCICIO N°5  METHODS"
 //Program.cs    
Console.WriteLine("The result is " + Utilities.MultiplyTwoNumbers(3, 6));
Console.ReadLine();

 // Utilieties.cs
public class Utilities 
{
    public static int MultiplyTwoNumbers(int a, int b)
    {
        return a * b;
    }
}

 */

/* //Ej. 27 "Utility class"
 //Utilities.cs
public class Utilities
{
    public static int SubtractTwoNumbers(int a, int b)
    {
        return a - b;
    }
}
//Program.cs
class Program
{
    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 5;
        int sum = Utilities.SubtractTwoNumbers(num1, num2);

        Console.WriteLine("The result of subtracting from {1} is {2}.", num2, num1, sum);
        Console.ReadLine();
    }
}

 */

/* //Ej. 28 "Method Overloading"
 public class Utilities
{
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    public static int AddNumbers(int a, int b, int c)
    {
        return a + b + c;
    }
}

 */


/*  //Ej. 29 "Optional Parameters"
 public class Utilities
{
    public static int CalculateYearlyWage(int monthlyWage, int months = 12)
    {
        return monthlyWage * months;
    }
}

 */

/*  //Ej.30 "Named Argument"
 //Program.cs


using System;

class Program
{
    static void Main(string[] args)
    {
        int yearlyWage = Utilities.CalculateYearlyWage(months: 12, monthlyWage: 1000);

        Console.WriteLine($"Yearly wage: {yearlyWage}");
    }
}

// Utilities.cs

public class Utilities
{
    public static int CalculateYearlyWage(int monthlyWage, int months)
    {
        return monthlyWage * months;
    }
}

 */

/* //Ej. 31 "Ejercicio 6 resumen  Methods and their parameters"
 //Program.cs

int yearlyWage = Utilities.CalculateYearlyWage(1000);

Console.WriteLine("The yearly wage is " + yearlyWage);

Console.ReadLine();
 //Utilities.cs
public class Utilities
{
    public static int CalculateYearlyWage(int monthlyWage, bool giveBonus = true)
    {
        if (giveBonus)
        {
            return monthlyWage * 12 + 1000;
        }
        else
        {
            return monthlyWage * 12;
        }
    }
}

 */

/* // 31 "Expression bodied"
 public static void UsingExpressionBodiedSyntax()
{
	int amount = 1234;
	int months = 12;
	int bonus = 500;

	int yearlyWageForEmployee1 = CalculateYearlyWageExpressionBodied(monthlyWage, months, bonus);
	Console.WriteLine($"Yearly wage for employee 1 (Bethany): {yearlyWageForEmployee1}");
}


public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numberOfMonthsWorked, int bonus) => monthlyWage * numberOfMonthsWorked + bonus;

 */
//Cierre de Modulo5







//Modulo 6


/*    //Ej. 31 "string lowercase"
string b = "Welcome to thIs AweSomE CouRse!";
string a = b.ToLower();
*/

/*    //Ej. 32 "String Contains"
public class Utilities
{
    public bool CheckContains(string input)
    {
        if (input.Contains("Goodbye"))
        {
            return true;
        }
        
        bool containsGoodbye = false;
        
        return containsGoodbye;
    }
}
 
 */


/*  //Ej. 33 "String Plus"
 public class Utilities
{
    public static string ConcatUsingPlus(string a, string b)
    {
        string c = a + " " + b;
        return c;
    }
}
*/


/*   //Ej. 34 "String Interpolation"
 public class Utilities
{
    public static string CreateGreeting(string employeeName, int age)
    {
        string greeting = $"Hello {employeeName}, you are {age} years";
        return greeting;
    }
}

 */

/*   //EJERCICIO N°7  "Remove vowels"
 //Utilities
public class Utilities
{
    public static string RemoveVowels(string input)
    {
        string vowels = "aeiouy";
        string result = "";

        foreach (char c in input)
        {
            if (!vowels.Contains(char.ToLower(c)))
            {
                result += c;
            }
        }

        return result;
    }
}
// Program.cs

var sampleString = "baceiouxyz";

Console.WriteLine(sampleString + " => " + Utilities.RemoveVowels(sampleString));

 */


/*   //Ej. 35 "Escape Characteres"
public class Utilities
{
    public static string AddBreak()
    {
        string result = "Hello\nEveryone";
        return result;
    }
}

 */

/*   //EJERCICIO N° 8 "String Equality"
 public class Utilities
{
    public static bool CheckIfStringsAreEqual(string a, string b)
    {
        bool areEqual = string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
        return areEqual;
    }
}

 */


/*   //Ej. 36 "String Parsing"
 *   
        Console.WriteLine("Enter the number of employees: ");
        string input = Console.ReadLine();

        int i;
        bool success = int.TryParse(input, out i);

        if (success)
        {
            Console.WriteLine("Parsed integer value: " + i);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

 */

// CIerre de ejercicios de Modulo 6





/*   //Ej. 37 "Class creation "
 using System;

public class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee name: {name} - Age: {age} - Number of hours worked: {numberOfHoursWorked}");
    }
}
 */





/*   //Ej.38 "Class methodo"
 using System;

public class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee name: {name} - Age: {age} - Number of hours worked: {numberOfHoursWorked}");
    }

    public void Work(int hours, bool resetHours)
    {
        if (resetHours)
        {
            numberOfHoursWorked = 0;
        }

        numberOfHoursWorked += hours;
    } 
 */

/*   //Ej.39 "Object creation"
 
public class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee name: {name} - Age: {age} - Number of hours worked: {numberOfHoursWorked};");
    }

    public void Work(int hours, bool resetHours)
    {
        if (resetHours)
            numberOfHoursWorked = 0;

        numberOfHoursWorked += hours;
    }
}

 */


/*   //Ej.40 "Constructor"
 using System;

public class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public Employee(string employeeName, int employeeAge, int hours)
    {
        name = employeeName;

        age = employeeAge;

        numberOfHoursWorked = hours;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee name: {name} - Age: {age} - Number of hours worked: {numberOfHoursWorked};");
    }

    public void Work(int hours, bool resetHours)
    {
        if (resetHours)
            numberOfHoursWorked = 0;

        numberOfHoursWorked += hours;
    }
}
 */


/*   //Ej. 41 "Using object"
 //Employee.cs
﻿
public class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public Employee(string employeeName, int employeeAge, int hours)
    {
        name = employeeName;
        age = employeeAge;
        numberOfHoursWorked = hours;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee name: {name} - Age: {age} - Number of hours worked: {numberOfHoursWorked};");
    }

    public void Work(int hours, bool resetHours)
    {
        if (resetHours)
            numberOfHoursWorked = 0;

        numberOfHoursWorked += hours;
    }
}

//Porgram.cs
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee("Gill", 42, 10);

        employee.Work(10, false);
        employee.Work(8, false);
        employee.Work(5, false);

        employee.DisplayEmployeeDetails();

        employee.name = "John";
    }
}

 */

/*   // Ejercicio N°9 "Create class and object"
 //Vehicle.cs
public class Vehicle
{
    public string model;
    public string color;
    public int currentMileage;

    public Vehicle()
    {
        // Default constructor
    }

    public Vehicle(int currentMileage, string model, string color)
    {
        this.currentMileage = currentMileage;
        this.model = model;
        this.color = color;
    }

    public void Drive()
    {
        currentMileage += 1;
    }

    public void Drive(int miles)
    {
        if (miles > 0)
            currentMileage += miles;
    }

    public string DisplayVehicleDetails()
    {
        return $"Model: {model} - Color: {color} - Current mileage: {currentMileage}";
    }
}

//Utilities.cs
public class Utilities
{
    public static Vehicle CreateAndUseVehicle()
    {
        Vehicle vehicle = new Vehicle(100, "BMW", "Black");
        vehicle.Drive(10);
        vehicle.color = "Red";
        return vehicle;
    }
}
 */

//Cierre de Modulo 7 




//Modulo 8
/*   //Ej.42  "Pass by ref"
 //Employee.cs
using System;

public class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public Employee(string employeeName, int employeeAge, int hours)
    {
        name = employeeName;
        age = employeeAge;
        numberOfHoursWorked = hours;
    }

    public int CalculateBonusAndTax(int bonus, ref int tax)
    {
        if (numberOfHoursWorked > 10)
            bonus *= 2;

        if (bonus >= 200)
        {
            tax = bonus / 10;
        }

        Console.WriteLine($"The employee got a bonus of {bonus} and the tax is {tax}");
        return bonus;
    }
}


//Program.cs
public class Program
{
    public static void Main()
    {
        int defaultBonus = 1000;
        int tax = 0;

        Employee employee = new Employee("Gill", 42, 10);

        int bonus = employee.CalculateBonusAndTax(defaultBonus, ref tax);
    }
}

 */


/*   //Ej.43  "Using out"
//Employee.cs
using System;

public class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public Employee(string employeeName, int employeeAge, int hours)
    {
        name = employeeName;
        age = employeeAge;
        numberOfHoursWorked = hours;
    }

    public int CalculateBonusAndTax(int bonus, out int tax)
    {
        tax = 0;

        if (numberOfHoursWorked > 10)
            bonus *= 2;

        if (bonus >= 200)
        {
            tax = bonus / 10;
        }

        Console.WriteLine($"The employee got a bonus of {bonus} and the tax is {tax}");
        return bonus;
    }
}

//Program.cs
public class Program
{
    public static void Main()
    {
        int defaultBonus = 1000;
        int tax;

        Employee employee = new Employee("Gill", 42, 10);

        int bonus = employee.CalculateBonusAndTax(defaultBonus, out tax);

        Console.WriteLine($"The calculated tax value is: {tax}");

        Console.ReadLine();
    }
}

 */

/*   //Ej.44 "StringBuldier"
 using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Welcome ");
        stringBuilder.Append("to ");
        stringBuilder.AppendLine("Bethany's Pie Shop!");
        stringBuilder.Append("Please log in!");

        Console.WriteLine(stringBuilder.ToString());
    }
}
 */

/*   //Ej.45 " Enum1"
 public enum Colors
{
    Red,
    Green,
    Blue
}

 */

/*   //Ej.46 "Enum2"
  public enum  Colors
{
  Red=5,
  Green=8,
  Blue=10;
}

 */

/*                    //Ejercicio N10"Enumerations"
//VehicleType.cs
public enum VehicleType
{
  Car,
  Van,
  Truck;
}
//Vehicles.cs
public class Vehicle
{
    public int currentMileage;
    public string model;
    public string color;

    public Vehicle()
    {
    }

    public Vehicle(int currentMileage, string model, string color)
    {
        this.currentMileage = currentMileage;
        this.model = model;
        this.color = color;
    }

    public void Drive()
    {
        currentMileage++;
    }

    public void Drive(int miles)
    {
        if (miles > 0)
            currentMileage += miles;
    }

    public string DisplayVehicleDetails()
    {
        return $"Model: {model} - Color: {color} - Current mileage: {currentMileage}";
    }
}
//Utilities.cs

public class Utilities
{
    public static Vehicle CreateAndUseVehicle()
    {
        Vehicle vehicle = new Vehicle(100, "BMW", "Black");

        vehicle.Drive(10);

        vehicle.color = "Red";

        return vehicle;
    }
}
 */

/*   //Ej.47"Struct"
//Program.cs
class Program
{
    static void Main()
    {
        ToDo newToDo;
        newToDo.description = "Buy milk";
        newToDo.done = false;

        // Resto del código...
    }
}
 //ToDo.cs
public struct ToDo
{
    public string description;
    public bool done;
}

 */

/*         EJERCICIO N° 11"struc"
 //Produc.cs
public struct Product
{
    public double basePrice;
    public string name;

    public double CalculateSalePrice()
    {
        return basePrice * 1.17;
    }
}
//Utilities.cs
public class Utilities
{
    public static double GetSalePrice()
    {
        Product product = new Product();
        product.name = "Milk";
        product.basePrice = 1.25;
        
        return product.CalculateSalePrice();
    }
}
 
 */

/*    EJERCICIO N° 12 "nameespace"
 //Truck.cs
namespace Shop.Large
{
    public class Truck
    {
        // Clase Truck
    }
}
//Van.cs
namespace Shop.Medium
{
    public class Van
    {
        // Clase Van
    }
}
//Suv.cs
namespace Shop.Medium
{
    public class Suv
    {
        // Clase Suv
    }
}
//CityCar.cs
namespace Shop.Small
{
    public class CityCar
    {
        // Clase CityCar
    }
}
//Program
 using Shop.Large;
using Shop.Medium;
using Shop.Small;

class Program
{
    static void Main()
    {
        Truck truck = new Truck();
        Van van = new Van();
        Suv suv = new Suv();
        CityCar cityCar = new CityCar();

        // Resto del código...
    }
}
 */                             //Cierre de Modulo 8



// Modulo 9
/*      //Ej.48 "Namespace"
 //Employee.cs
using System;

namespace Pluralsight.EmployeeApp
{
    public class Employee
    {
        public string name;
        public int age;
        public int numberOfHoursWorked = 0;

        public Employee(string employeeName, int employeeAge, int hours)
        {
            name = employeeName;
            age = employeeAge;
            numberOfHoursWorked = hours;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee name: {name} - Age: {age} - Number of hours worked: {numberOfHoursWorked}");
        }

        public void Work(int hours, bool resetHours)
        {
            if (resetHours)
                numberOfHoursWorked = 0;

            numberOfHoursWorked += hours;
        }
    }
}
//Pogram.cs
using System;
using Pluralsight.EmployeeApp;

namespace Pluralsight.EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John Doe", 25, 40);

            employee.DisplayEmployeeDetails();

            employee.Work(10, false);

            employee.DisplayEmployeeDetails();

            Console.ReadKey();
        }
    }
}

 */

/*        //Ej.49 "Static"
 //Employee.cs
using System;

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public static double bonusPercentage = 0.15;

    public static void UpdateBonusPercentage(double newPercentage)
    {
        bonusPercentage = newPercentage;
    }
}
//Porgram.cs
class Program
{
    static void Main()
    {
        Employee.UpdateBonusPercentage(0.17);

        Console.WriteLine(Employee.bonusPercentage);
    }
}
 */

/*                  //Ejercicio N°13 "Static"
//Vehicle.cs
public class Vehicle
{
    public static int maxSpeed = 100;

    public static void IncreaseMaxSpeed(int amount)
    {
        maxSpeed += amount;
    }
}
//Utilities.cs
public class Utilities
{
    public static int ChangeMaxSpeed()
    {
        int newMaxSpeed = 0;
        int increaseAmount = 10;

        Vehicle.IncreaseMaxSpeed(increaseAmount);
        newMaxSpeed = Vehicle.maxSpeed;

        return newMaxSpeed;
    }
}
 */

/*        Ej.50 "null"
//Employee.cs
public class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public Employee(string employeeName, int employeeAge, int hours)
    {
        name = employeeName;
        age = employeeAge;
        numberOfHoursWorked = hours;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee name: {name} - Age: {age} - Number of hours worked: {numberOfHoursWorked};");
    }

    public void Work(int hours, bool resetHours)
    {
        if (resetHours)
            numberOfHoursWorked = 0;

        numberOfHoursWorked += hours;
    }
}

//Program.cs
class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Gill", 42, 10);
        employee = null;
    }
}
 */



// Cierre modulo 9

/*       Ej.52 "Sample array"
 int[] myValues = new int[5];
 */


/*       Ej.53 "Array initialization"
 int[] intValues = new int[] { 5, 15, 25, 35, 45 };

 */

/*       Ej. 54 "Accesing elements in is array"


string [] greetings = new string[] { "Hello", "Goodbye", "Farewell", "Welcome"};
string selectedGreeting = greetings[2];

 */

/*        Ej.55 "Array looping"
 int[] myValues = new int[] { 5, 15, 25, 35, 45 };

for (int i = 0; i < myValues.Length; i++)
{
    Console.WriteLine(myValues[i]);
} 
 */

/*        Ej.56 "object array"
//Program.cs

class Program
{
    static void Main(string[] args)
    {
        Vehicle v1 = new Vehicle(10, "BMW", "Red");
        Vehicle v2 = new Vehicle(45, "Toyota", "Blue");
        Vehicle v3 = new Vehicle(987, "Renault", "Black");
        Vehicle v4 = new Vehicle(45643, "Volkswagen", "Green");
        Vehicle v5 = new Vehicle(0, "Fiat", "Red");

        Vehicle[] vehicles = new Vehicle[5];
        vehicles[0] = v1;
        vehicles[1] = v2;
        vehicles[2] = v3;
        vehicles[3] = v4;
        vehicles[4] = v5;

    }
}

//Vehicle.cs
public class Vehicle
{
    public int currentMileage;
    public string model;
    public string color;

    public Vehicle()
    {
    }

    public Vehicle(int currentMileage, string model, string color)
    {
        this.currentMileage = currentMileage;
        this.model = model;
        this.color = color;
    }

    public void Drive()
    {
        currentMileage++;
    }

    public void Drive(int miles)
    {
        if (miles > 0)
            currentMileage += miles;
    }

    public string DisplayVehicleDetails()
    {
        return $"Model: {model} - Color: {color} - Current mileage: {currentMileage}";
    }
}

 
 */

/*        //Ej.57 "Array sort"
//Program.cs

class Program
{
    static void Main(string[] args)
    {
        int[] unsortedValues = new int[] { 44, 46, 1, 6664, 123, 999 };

        Array.Sort(unsortedValues);

        Console.WriteLine("Sorted Values:");
        foreach (int value in unsortedValues)
        {
            Console.WriteLine(value);
        }
    }
}

 
 */

/*            //Ej.58 "Array lenght"

int[] myValues = new int[] { 5, 15, 25, 35, 45 };

int length = myValues.Length;

 
 */

/*        //EJERCICIO N°15 "Array"
public class Utilities
{
    public static int CalculateSumOfArrayElements(int[] array)
    {
        int sum = 0;
        
        foreach (int element in array)
        {
            sum += element;
        }
        
        return sum;
    }
}

 */

/*        //Ej.59 "List creation"
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myValues = new List<int>();

        myValues.Add(5);
        myValues.Add(15);
        myValues.Add(25);
        myValues.Add(35);
        myValues.Add(45);

    }
}
 */

/*        //Ej.60 "List Contains"
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myValues = new List<int> { 5, 15, 25, 35, 45, 55, 65 };

        bool containsValue = myValues.Contains(75);

        Console.WriteLine("Contains value 75: " + containsValue);
    }
}
 */

/*        //Ej.61 "List length"
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myValues = new List<int> { 5, 15, 25, 35, 45, 55, 65 };

        int length = myValues.Count;

        Console.WriteLine("Length of myValues: " + length);
    }
} 
 */


/*         //Ej.62 "List insert"
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> myValues = new List<int> { 5, 15, 35, 45, 55, 65 };

        myValues.Insert(2, 25);

        Console.WriteLine("Updated myValues:");
        foreach (int value in myValues)
        {
            Console.WriteLine(value);
        }
    }
}
 */

/*        //Ej.63 "List of objects"
 //Program.cs
class Program
{
    static void Main(string[] args)
    {
        Vehicle v1 = new Vehicle(10, "BMW", "Red");
        Vehicle v2 = new Vehicle(45, "Toyota", "Blue");
        Vehicle v3 = new Vehicle(987, "Renault", "Black");
        Vehicle v4 = new Vehicle(45643, "Volkswagen", "Green");
        Vehicle v5 = new Vehicle(0, "Fiat", "Red");

        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(v1);
        vehicles.Add(v2);
        vehicles.Add(v3);
        vehicles.Add(v4);
        vehicles.Add(v5);

    }
}
 //Vehicle
public class Vehicle
{
    public int currentMileage;
    public string model;
    public string color;

    public Vehicle()
    {
    }

    public Vehicle(int currentMileage, string model, string color)
    {
        this.currentMileage = currentMileage;
        this.model = model;
        this.color = color;
    }

    public void Drive()
    {
        currentMileage++;
    }

    public void Drive(int miles)
    {
        if (miles > 0)
            currentMileage += miles;
    }

    public string DisplayVehicleDetails()
    {
        return $"Model: {model} - Color: {color} - Current mileage: {currentMileage}";
    }
}
 */

/*        //EJERCICIO N°15 "LISTS"
 //Utilities.cs
public static class Utilities
{
    public static int CalculateSumOfMilesDriven(List<Vehicle> vehicles)
    {
        int sum = 0;

        for (int i = 0; i < vehicles.Count; i++)
        {
            sum += vehicles[i].currentMileage;
        }
        return sum;
    }

}
//Program.cs
class Program
{
    static void Main(string[] args)
    {
        Vehicle v1 = new Vehicle(10, "BMW", "Red");
        Vehicle v2 = new Vehicle(45, "Toyota", "Blue");
        Vehicle v3 = new Vehicle(987, "Renault", "Black");
        Vehicle v4 = new Vehicle(45643, "Volkswagen", "Green");
        Vehicle v5 = new Vehicle(0, "Fiat", "Red");

        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(v1);
        vehicles.Add(v2);
        vehicles.Add(v3);
        vehicles.Add(v4);
        vehicles.Add(v5);

        int sum = Utilities.CalculateSumOfMilesDriven(vehicles);

        Console.WriteLine("Sum of miles driven is " + sum);
    }
}
 
 */

                    //Cierre de Modulo 10