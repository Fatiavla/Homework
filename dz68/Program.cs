/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 
m = 3, n = 2 -> A(m,n) = 29

3+1
А(2 - 1,1)
А(2 -1,А(2,3-1))

*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}


int Function(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Function(m - 1, 1);
    else if (m > 0 && n > 0) return Function(m - 1, Function(m, n - 1));
    return Function(m, n);
}



int userNumberM = GetNumber("Введите число M:");
int userNumberN = GetNumber("Введите число N:");
int result = Function(userNumberM, userNumberN);
Console.WriteLine(result);