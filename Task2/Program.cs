/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.WriteLine("Напишите 3 числа");
string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();
int numberA = int.Parse(a);
int numberB = int.Parse(b);
int numberC = int.Parse(c);
int max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.WriteLine(max);