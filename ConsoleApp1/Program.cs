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



using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Main caller. Press ENTER when ready to call Add.");
        Console.ReadLine();
        var sum = Add(30, 12);

        Console.WriteLine(sum);
        Console.WriteLine("Press ENTER to exit program.");
        Console.ReadLine();
    }
    static int Add(int a, int b) {
    return (a + b);
    }
}