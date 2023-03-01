// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1" 

System.Console.WriteLine(SeriesNumbers(4, 15));

string SeriesNumbers(int start, int end)
{
    if(start == end)
    {
        return start.ToString();
    }
    return start + " " + (SeriesNumbers(start + 1, end));
}