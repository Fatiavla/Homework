/*
Задача 64: 
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/



int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}

void Recursion(int number, int count)
{
     if (count > number) return; 
    Recursion(number, count + 1);
    Console.Write(count + ", ");
}

int userNumber = GetNumber("Введите число: ");
Console.WriteLine();
int count = 1;
Recursion(userNumber, count);
