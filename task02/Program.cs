// Задача 02
// Напишите программу, которая на вход
// 1. принимает два числа и выдает
// 2. какое большее, а какое меньшее.
// a = 5; b = 7 max -> 7
// a = 2; b = 10 max -> 10
// a = -9; b = -3 max -> -3




Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} max");
}
else
{
    Console.WriteLine($"Число {number2} max");
}
