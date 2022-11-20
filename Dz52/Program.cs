/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
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
int[,] numbers = GetInt(n, m); // 4 4
PrintArray(numbers);


double GetResult(int[,] numbers)
{
    double result = 0;
    for (int i = 0; i < m; i++)
    {
        result = 0;
        for (int j = 0; j < n; j++)
        {
            result += (numbers[j, i]);
        }
        result = result / m;
        result = Math.Round(result, 2);


        // Console.Write(Convert.ToDouble(result))
        Console.Write(result + "; ");

    }
    Console.WriteLine();
    return result;
}

double r = GetResult(numbers);
Console.WriteLine(r);