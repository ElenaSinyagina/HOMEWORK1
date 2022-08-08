// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число и нажмите Enter:");

string? numberString = Console.ReadLine();

int numberA = int.Parse(numberString);

Console.WriteLine("Введите второе число и нажмите Enter:");

string? numberStringB = Console.ReadLine();

int numberB = int.Parse(numberStringB);

if(numberA > numberB)
{
    Console.WriteLine("Большее число " + numberA + ", меньшее число " + numberB);
}

else
{
    Console.WriteLine("Большее число " + numberB + ", меньшее число " + numberA);
}