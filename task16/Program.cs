﻿//  Задача 16.
// Напишите программу, которая
// 1. принимает на вход два числа и
// 2. прооверяет, является ли одно
// квадратом второго
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquare(number1, number2) ? "да" : "нет");

bool IsSquare(int n1, int n2)
{
    return n1 % n2 == 0 || n2 % n1 == 0;
}
