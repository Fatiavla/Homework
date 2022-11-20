/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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


Console.WriteLine("Введите столбец для 1 матрицы : ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите строку для 1 матрицы : ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец для 2 матрицы : ");
int j = int.Parse(Console.ReadLine());
Console.WriteLine("Введите строку для 2 матрицы : ");
int x = int.Parse(Console.ReadLine());
int [,] firstMatrix = GetInt(n, m);
int [,] secondMatrsix = GetInt(j, x);
PrintArray(firstMatrix);
PrintArray(secondMatrsix);

// c(1,1) = a(1,1)·b(1,1) + a(1,2)·b(2,1) = 4·3 + 2·(-3) = 12 - 6 = 6

int [,] IndexOf(int [,] firstArray, int [,] secondArray)
{
    int [,] resoult = new int [firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < resoult.GetLength(0); i++)      // 1 2  | 2 3 //
    {
        for (int j = 0; j < resoult.GetLength(1); j++)
        {
          for (int k = 0; k < firstArray.GetLength(1); k++)
          {
            resoult [i,j] += firstArray[i,k] * secondArray[k, j];
          }
        }
    }
    return resoult;
}

int [,] resoult = IndexOf(firstMatrix, secondMatrsix);
PrintArray(resoult);
