/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
пример из 5 элементов:
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]


*/


int [] array = new int [8];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
  array [i] = rnd.Next(0,8);
}

Console.Write(string.Join(",", array));