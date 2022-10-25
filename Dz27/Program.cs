
/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


Console.WriteLine("Напишите число: ");
int number = int.Parse(Console.ReadLine());

int Summ(int number)
{
int count = Convert.ToString(number).Length;
int newnumber = 0;
int result = 0;
for (int i = 0; i < count; i++)
{
    newnumber = number - (number%10);
    result = result + (number - newnumber);
    number = number / 10;
}
return result;
}

int attall = Summ(number);
Console.WriteLine(attall);