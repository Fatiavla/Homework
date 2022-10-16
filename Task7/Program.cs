/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Напишите цифру от 1 до 7: ");
string number = Console.ReadLine();
int dayNumber = int.Parse(number);

void Checkday (int daynumber) // Checkday не забыть вывести в итог
{
    if(daynumber == 6 || daynumber == 7)
    {
        Console.Write("да");
    }
    else if (daynumber < 1 || daynumber > 7)
    {
        Console.Write("такого дня нет");
    }
    else Console.Write("нет");

}

Checkday(dayNumber); // вот сюда, иначе работать не будет