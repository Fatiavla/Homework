/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}




void PrintSumm(int m, int n, int summ)
{
  summ = summ + n; 
  if (n <= m)   
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ); новое условие 1 1 0
}




int userNumberM = GetNumber("Введите число M:"); 
int userNumberN = GetNumber("Введите число N:"); 
int temp = 0;
PrintSumm(userNumberM, userNumberN, temp);
