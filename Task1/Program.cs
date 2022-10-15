/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/ 

Console.WriteLine("Напишите 2 числа");
string A = Console.ReadLine();
string B = Console.ReadLine();
int numberA = int.Parse(A);
int numberB = int.Parse(B);
int max = 0;
if (numberA > numberB)
{
    max = numberA;
    Console.WriteLine($"Максимальное число {max}");
}
else
{
    max = numberB;
    Console.WriteLine($"Максимальное число {max}");
}