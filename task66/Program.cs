// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120

System.Console.WriteLine(SumInterval(1, 15));

int SumInterval(int start, int end)
{
    if(start == end)
    {
        return start;
    }
    return start + (SumInterval(start + 1, end));
}
