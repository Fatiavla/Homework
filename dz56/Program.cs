/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] GetInt(int n, int m)
{
    Random rnd = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();

    }
}


Console.WriteLine("Введите номер строки: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m = int.Parse(Console.ReadLine());
int[,] numbers = GetInt(n, m);
PrintArray(numbers);

int SummLineElements(int[,] numbers, int n)
{
    int sumLine = numbers[n, 0];
    for (int j = 1; j < numbers.GetLength(1); j++)
    {
        sumLine += numbers[n, j];
    }
    return sumLine;
}

int minSumLine = 0;
int sumLine = SummLineElements(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
    int tempSumLine = SummLineElements(numbers, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}


Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");