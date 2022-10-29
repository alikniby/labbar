// See https://aka.ms/new-console-template for more information
String firstName = "Ali";
String lastName = "Kambal";
int age = 31;
int counter = 0;

String fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

while (counter < age)
{
    Console.WriteLine("fluff");
     counter++;
    if (counter == 15)
    {
        Console.WriteLine("15 fluffs");
        break;
    }
}
    
Console.ReadLine();


