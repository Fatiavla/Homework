/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write("Введи число: ");
string Newnumber = Console.ReadLine();
int number = int.Parse(Newnumber);
if (Newnumber.Length > 2)
{
  Console.WriteLine(Newnumber[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}