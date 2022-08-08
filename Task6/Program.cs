Console.WriteLine("Введите число и нажмите Enter:");

string? numberString = Console.ReadLine();

int number = int.Parse (numberString);

if (number % 2 == 0)
{
    Console.WriteLine ("Число четное");
}
else 
{
    Console.WriteLine ("Число не четное");
}