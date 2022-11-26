/*
Задача 63: Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
Решить с помощью рекурсии
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/


int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}

string Recursion(int number)
{
    if (number == 1) return number.ToString();
    else
    return Recursion (number - 1) + " " + number;
}

int userNumber = GetNumber("Введите число: ");
Console.WriteLine();
Console.Write(Recursion(userNumber));