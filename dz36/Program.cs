/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int [] GetNumber (int n)
{
Random rnd = new Random ();
int [] result = new int[n];
    for (int i = 0; i < n; i++)
    {
        result[i] = rnd.Next(1, 999);
    }
    return result;
}

void PrtintNumber (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void CheckNumber(int [] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i+2)
    {
        result = result + array[i];

    }
    Console.WriteLine ($" -> {result}");

}

int[] array = GetNumber(4);
PrtintNumber (array);
CheckNumber(array);