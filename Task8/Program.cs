// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число и нажмите Enter:");

string? numberString = Console.ReadLine();
int number = int.Parse (numberString);
int numberA = 1;
Console.WriteLine("Четные числа: ");
for (int i = numberA; i <= number; i++)
{
    if(i % 2 ==0)
    {
        Console.Write(i + ",");
    }
}