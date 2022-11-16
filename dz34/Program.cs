/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int [] GetNumber (int n)
{
Random rnd = new Random();
int [] result = new int [n];

    for (int i = 0; i < n; i++)
    {
        result[i]=rnd.Next(100, 1000);
    }
    return result;
}

void PrintNumber(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}



int CheckNumber(int [] array)
{
int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]% 2 == 0)
    {
        result ++;
    }
}
return result;
}

int[] array = GetNumber(4);
PrintNumber(array);
int a = CheckNumber(array);
Console.WriteLine(a);