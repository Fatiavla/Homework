/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


int Answer(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA; //3
    }
    
    return result;
}

Console.WriteLine ("Напишите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine ("Напишите второе число: ");
int numberB = int.Parse(Console.ReadLine());

int answer1 = Answer(numberA, numberB);
Console.Write(answer1);