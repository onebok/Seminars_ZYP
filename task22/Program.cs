﻿// Задача №22. 
// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25
// 2 -> 1,4

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = number;
counter = 1;
while (counter <= number)
{
    Console.WriteLine($"{counter} {counter*counter} ");
    counter = counter + 1;
}



