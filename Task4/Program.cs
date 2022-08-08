Console.WriteLine("Введите первое число и нажмите Enter:");

string? numberString = Console.ReadLine();

int numberA = int.Parse(numberString);

Console.WriteLine("Введите второе число и нажмите Enter:");

string? numberStringB = Console.ReadLine();

int numberB = int.Parse(numberStringB);

Console.WriteLine("Введите третье число и нажмите Enter:");

string? numberStringC = Console.ReadLine();

int numberC = int.Parse(numberStringC);

if(numberA > numberB && numberA > numberC)
{
    Console.WriteLine("Максимальное число: " + numberA);
}
    
if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine("Максимальное число: " + numberB);
}
    
if(numberC > numberA && numberC > numberB)
{
    Console.WriteLine("Максимальное число: " + numberC);
}