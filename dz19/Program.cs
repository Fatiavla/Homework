/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
int GetNumber (string message) 
{
    int userNumber;
    while (true) 
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int number)) 
        {
            userNumber = number;
            break;
        }    
        else {
            Console.WriteLine("Это не число, повторите ввод.");
        }
    } 
    return userNumber;
}

string CheckNumber(string message)
{
    string result = String.Empty;
    int lenght = message.Length;
    for ( int i = 0; i < message.Length; i++)
    {
       
        if(message[0] == message[4] && message[1] == message[3]) 
        {
            Console.WriteLine("да");
            break;
        }
        else
        {
            Console.WriteLine("Нет");
            break;
        }
    }
    
    return result;
}

int userNumber = GetNumber ("Введите 5-ти значное число: ");
string result = CheckNumber($"{userNumber}");
Console.WriteLine(result);
