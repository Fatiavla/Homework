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
    string number;
    while (true) 
    {
        Console.Write(message);
        number = Console.ReadLine();

        if (int.TryParse(number, out int number1) && number.Length == 5) 
        {
            userNumber = number1;
            break;
        }    
        else {
            Console.WriteLine("Это не пятизначное число, повторите ввод.");
        }
    } 
    return userNumber;
}

string CheckNumber(string message)
{
    string result = String.Empty;
    int lenght = message.Length;
        if(message[0] == message[4] && message[1] == message[3]) 
    
        {
            result = "да";
            
  
        }
        else
        {
            result = "нет"; 
        }
        
    
    return result;
}

int userNumber = GetNumber ("Введите 5-ти значное число: ");
Console.WriteLine(CheckNumber($"{userNumber}"));
