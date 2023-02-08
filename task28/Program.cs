﻿// Задача 28: 
// Напишите программу, которая 
// принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = DigitMultiplication(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {result} ");

int DigitMultiplication(int num)
{
    int multiplic = 1;
   for (int i = 1; i <= num; i++)
   {
        multiplic = multiplic * i;
   }
    return multiplic;
}

