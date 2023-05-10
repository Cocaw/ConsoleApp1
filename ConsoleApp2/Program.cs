/*
int age = 23;

    bool a = age == 23;
Console.WriteLine("Age is 23" + a);


bool b = age > 23; 
Console.WriteLine("Age is greater than 23: " + b);

bool c = (age > 18) && (age <= 65);
Console.WriteLine("Age is between 18 and 65: " + c);


int age1 = 16;
int age2 = 64;
bool d = (age1 > 18) && (age2 < 65);
Console.WriteLine("Age is greater than 18 AND age2 is Less than 65: " + d);

bool e = (age1 > 18) || (age2 < 65);
Console.WriteLine("Age is greater than 18 OR age2 is less than 65: " + e);
*/

/*
Console.WriteLine("Enter the age of the new candidate: ");
int age = int.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("Too young to apply");
    Console.WriteLine("Send email to candidate");
}
else if (age > 65)
{
    Console.WriteLine("Sorry, the selected age is too old");
    Console.WriteLine("Send email to candidate.");
}
else
{
    Console.WriteLine("Great, you can now start with the application!");
}


DateTime today = DateTime.Now;
bool endOfMounthPaymentStarted = false;

if (today.Date.Day == 20)
{
    Console.WriteLine("Please start end-of-month employee payments");
}
else if(today.Date.Day >= 25 && !endOfMounthPaymentStarted)
{
    Console.WriteLine("Payments will be late!");
}
//else isn´t required!

*/


// Creating a while loop / "Creando un bucle while"
/*Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());
int i = 0;

while (i < max)
{
    Console.WriteLine(i);
    i++;
//

int i = 10;

while (i > 0) 
{
    Console.WriteLine(i);
    i --;
}
Console.WriteLine("Loop finished!");

*/



/*// Creating a nested loop / "Creacion un bucle anidado"


int i = 0;
int j = 0;

while (i < 10)
{
    while (j < 10)
    {
        Console.WriteLine("i: " + i + " j: " + j);
        j++;
    }
    j = 0;
    i++;
}
//while (true)
//{
//    Console.WriteLine(DateTime.Now);
//}



//string selectedAction = "";

//do
//{
//    Console.WriteLine("Choose the action you want to do: ");
//    Console.WriteLine("1. Add employee");
//    Console.WriteLine("2. Update employee");
//    Console.WriteLine("3. Delete employee");
//    Console.WriteLine("99. Exit application");
//    selectedAction = Console.ReadLine();

//    switch (selectedAction)
//    {
//        case "1":
//            Console.WriteLine("Adding new employee...");
//            break;
//        case "2":
//            Console.WriteLine("Updating employee...");
//            break;
//        case "3":
//            Console.WriteLine("Deleting employee...");
//            break;
//        default:
//            Console.WriteLine("Invalid input");
//            break;
//    }

//} while (selectedAction != "99");

//Console.WriteLine("Closing application");

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}


//for (int i = 0, j = 10; i < 10 && j > 0; i++, j--)
//{
//    Console.WriteLine("i: " + i + "   j: " + j);
//}

//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());


//for (int i = 0; i < max; i++)
//{
//    if (i == 15)
//    {
//        Console.WriteLine("Bingo! " + i + " was found!");
//        continue;
//        //break;
//    }
//    Console.WriteLine(i);
//}


Console.ReadLine();
*/
