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