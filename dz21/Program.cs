/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetDistance (int x1, int y1, int c1, int x2, int y2, int c2) 
{
    double distance = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2)  + Math.Pow(c2 - c1, 2));
    return distance;
}

int GetNumber (string message) 
{
    int userNumber;
    while (true) 
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int number)) {
            userNumber = number;
            break;
        }    
        else {
            Console.WriteLine($"{number} не является числом, повторите ввод.");
        }
    } 
    return userNumber;
}

int x1Number = GetNumber("Введите координату X1 - ");
int y1Number = GetNumber("Введите координату Y1 - ");
int c1Number = GetNumber("Введите координату C1 - ");
int x2Number = GetNumber("Введите координату X2 - ");
int y2Number = GetNumber("Введите координату Y2 - ");
int c2Number = GetNumber("Введите координату C2 - ");

double myDistance = GetDistance(x1Number, y1Number, c1Number, x2Number, y2Number, c2Number);

Console.WriteLine($"Расстояние между точками ({x1Number}, {y1Number}, {c1Number}) и ({x2Number}, {y2Number}, {c2Number}) составляет {Math.Round(myDistance, 2)}.");

