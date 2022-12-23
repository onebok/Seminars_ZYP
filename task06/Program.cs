// Задача 06
// Напишите программу, которая 
// 1. принимает на вход числа
// и выдает, является ли число четным
// (делится ли оно на 2 без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//int num = number;
//Console.ReadLine (number %2);
if (number % 2 == 0)
//    Console.WriteLine($"Число {num} ");
{
    Console.WriteLine("Число четное ");
}
 if (number % 2 == 1)
 {
    Console.WriteLine("Число нечетное ");
 }
