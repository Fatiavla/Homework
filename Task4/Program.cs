/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("напишите число: ");
string NumberA = Console.ReadLine();
int N = int.Parse(NumberA);

for (int x = -N; x<=N; x++)
{  
    if(x%2==0 && x > 0)

   Console.WriteLine($"{x}");
}
