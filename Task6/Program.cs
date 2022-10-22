/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write("Введи число: ");
string newnumber = Console.ReadLine();
if (newnumber.Length > 2)
{
  Console.WriteLine(newnumber[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}