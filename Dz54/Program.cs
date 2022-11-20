/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
int[,] SortRows(int[,] numbers, int row)
{
   int rowArr = 0; 
  
  int[] TempArr = new int[numbers.GetLength(0)];
  
  for (int i = 0; i < TempArr.Length; ++i) TempArr[i] = numbers[row, i];
  Array.Sort(TempArr);
  Array.Reverse(TempArr); 
  
  for (int i = 0; i < TempArr.Length; ++i) numbers[row, i] = TempArr[i];
  return numbers;
}

for (int i = 0; i < numbers.GetLength(1); i++)
{
   numbers = SortRows(numbers, i);
}
Console.WriteLine("----------");
PrintArray(numbers);
