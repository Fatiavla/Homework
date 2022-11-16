/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());
int[] array = GetNumber(length, min, max);
Console.WriteLine($"[{string.Join(", ", array)}]");
FindDifference(array, max, min);

int[] GetNumber(int size, int minValue, int maxValue)
{
    Random rnd= new Random(); 
    int[] result= new int[size];
    for (int i= 0; i< result.Length; i++)
{
    result[i] = rnd.Next(minValue, maxValue+ 1);
}
    return result;
    }
    void FindDifference (int[] MyArray, int minVal, int maxVal)
    {
        for(int i= 0; i< MyArray.Length; i++)
        {
            if(MyArray[i] < minVal)
            {
                minVal = MyArray[i];
            }
            if(MyArray[i] > maxVal)
            {
                maxVal = MyArray[i];
            }
            }
            Console.WriteLine($"Разница {maxVal-minVal}");
    }