// Задача 08
// Напишите программу, которая 
// 1. принимает на вход принимает число (N)
// а на выходе показывает все четные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6,8

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = number;
counter = 2;
while (counter <= number)
{
    Console.Write(counter + " ");
    counter = counter + 2;
}
