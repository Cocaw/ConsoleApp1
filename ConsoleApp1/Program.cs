// See https://aka.ms/new-console-template for more information

/*  using System;
namespace MyFirstProgram
{
  class Program
  {
      static void Main(string[] args)
      {

          Console.ForegroundColor = ConsoleColor.DarkGreen;
          Console.BackgroundColor = ConsoleColor.Yellow;
          Console.Clear();
          Console.WriteLine("Hello Wordl!");
          Console.WriteLine("Hello William");               //Metodos y propiesdas de la clase Console. (icono de caja son metodos, icono de rayo son eventos, icono de llave son propiedades
      }
  }
}           */



/*using System;
class Program
{
    static int Main(string[] arg)
    {
        Console.WriteLine("Hello, World!");
        for (var n = 0; n < arg.Length; n++)
        {
            Console.WriteLine("arg{[0]} = {1}", n, arg[n]);
        }
        return 0;
    }
}*/




/*
class Program
{
    static void Main()
    {
        var numbers = new int[] { 1, 2, 3 };
        var sum = 0;
        for(var n = 0; n < 4; n++)
        { sum += numbers[n]; }
        Console.WriteLine(sum);
    }
}   */

/*
using System;                                //{nombres de espacio}
using System.Linq;                              //Consulta integrada en el Lenguaje  deberia definir de esta manera al metodo agregado
    class Program
{ 
    static void Main()
{
    var numbers = new int[] { 1, 2, 3, 4, 5 };
    var sum = numbers.Aggregate(
        0,
        (total, num) =>
        {
            Console.WriteLine("total = {0}, num = {1}", total, num);   //Multiples Declaraciones
            return total + num;                                   // Palabra clave para intruccion lambda "return"
        }
    );
    Console.WriteLine(sum);
}
}
*/



/*       using System;
class Program
{
   static void Main()
   {
       Console.WriteLine("Main caller. Press ENTER when ready to call Add.");
       Console.ReadLine();
       var sum = Add(30, 12);          // sumas de 2 numeros

       Console.WriteLine(sum);             //resultado por consola
       Console.WriteLine("Press ENTER to exit program.");
       Console.ReadLine();
   }
   static int Add(int a, int b) {              //metodo separado llamado add para realizar esa aritmetica.
   return (a + b);
   }
}                                       compilaicon de JIT    (muestra )       */





/* F# lenguaje funcional particularmente adecuado para dominios (muestra)
namespace fscalc
    type public Calculator = 
    static member Add (a : double, bool : double) = a + b
    static member Subtract (a : double, b : doubñle) = a - b
    static member Multiply (a : double, b : doubñle) = a * b
    static member Divide (a : double, b : doubñle) = a / b
*/





/*  Class Program {
 *  static void Main()
 *  {
 *  System.Console.WriteLine("Hello, Word!");       //  Codigo de una sola linea.
 *  }
 *  }
 */



/*  using System;
Console.WriteLine("Hello, world!");
for (var n = 0; n < args.Length; n++)
{
    Console.WriteLine($"args[{n}] = {args[n]}");            //Interpolación de cadenas
}
return 0; 
*/


/* public class Point           //Point.cs                                                                Program.cs
 {                                                                           
private int _x;
private int _y;

public int X
{
get { return _x; }
set { _x = value; }
}
public int Y                                                                |       var pt = new Point { X = 30, Y = 12 };
{                                                                           |       System.Console.WriteLine(pt.ToString());
get { return _y; }
set { _y = value; } 
}

public override string ToString() {
return $"({x}, {Y}";          
}
 }                      */




/*
enum Generation { BabyBoomer, GenX, Millenial, GenZ, GenA }
class Person
{
    public int BirthYear { get; set; }

    public Generation Generation =>    //curp
        BirthYear switch                // La expresión que se usa aquí se llama expresión de cambio
        {
            (>= 1946) and (<= 1964) => Generation.BabyBoomer,
            (>= 1965) and (<= 1980) => Generation.GenX,
            (>= 1981) and (<= 1996) => Generation.Millenial,
            (>= 1997) and (<= 2012) => Generation.GenZ,
            _ => Generation.GenA
        };
}                   */

/*
// Aquí hay algunas pruebas sobre cómo trabajar con identificadores válidos en C#
//Podemos escribir comentarios en esta linea 

Console.WriteLine("Welcomoe to Bethany´s Pie Shop HRM");
Console.WriteLine("Please enter your name");

//El siguiente aceptará el nombre
string name = Console.ReadLine();
string name2 = Console.ReadLine();
string name_2 = Console.ReadLine();
// string 2Name = Console.ReadLine();                  no funciona por la sintaxis 
*/






// Creating an Integer Value            "int a = 2;int b = a + 3;"

/* int monthlyWane = 1234;
 int months = 12, bonus = 1000;
bool isActive = true;
double rating = 99.25;
*/

// byte numberOfEmployes = 300;
/*
int hoursWorked;
hoursWorked = 125;
hoursWorked = 148;
//monthlyWane = true;
*/


/*
const double interestRate = 0.07;                // declarando  la "constante "
//interestRate = 0.08;
 */


/*Creating basic string
string firstName = "Bethany";
string lastName = "Smith";

string emptyString = "";          //conjunto vacio 

Console.WriteLine("Please enter your name)
string name = Console.ReadLine();
*/


/* Using Arithmetic Operators
 double ratePerhour = 12.34;
int numberOfHoursWorked = 165;     // horas trabajadas

double currentMonthWage = ratePerHour * numberOfHoursWorked "+ bonus";    //tarifa por hora multiplicada // "agregue el bonus de liena 193"
Console.WriteLine(currentMonthWage);  //resultado mostrado en consola 2036,1 

ratePerHour +=; //= ratePerHour = ratePerHour + 3;  //operador compuesto
Console.WriteLine(ratePerHour);   // resultado por consola 15.34

*/

