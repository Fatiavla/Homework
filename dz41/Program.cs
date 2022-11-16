/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

       
 int countNumbers;
 int numbers;      


        string Replace(string text, char oldValue, char newValue)
        {
            string result = String.Empty;

            countNumbers = 1;

            int lenght = text.Length;
            for (int i =0; i < lenght; i++)
            {
                if (text[i] == oldValue)
                {
                    countNumbers++;
                    result = result + $"{newValue}" ;
                }
                else result = result + $"{text[i]}";
            }
            return result;
        }

       int CountPositive(string text, char oldValue)
        {
            string result = String.Empty;

            int res;
            int negativeCount=0;

            int lenght = text.Length;
            for (int i =0; i < lenght; i++)
            {
                if (text[i] == oldValue)
                {
                    negativeCount++;
                }
            }

            res = countNumbers - negativeCount;
            return res;
        }


 Console.WriteLine("Введите числа через пробел: ");
 string text = Console.ReadLine();
 string newText = Replace(text, ' ', ',');
 Console.WriteLine (newText);
 Console.WriteLine($"Кол-во положительных чисел = {CountPositive(newText,'-')}");