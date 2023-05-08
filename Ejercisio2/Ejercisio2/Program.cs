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
 
 */