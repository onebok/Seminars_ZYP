﻿// Задача 19: 
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и проверяет, 
// 2. является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int a1 = number % 10;
int a2 = number / 10 % 10;
int a3 = number / 100 % 10;
int a4 = number / 1000 % 10;
int a5 = number / 10000 % 10;

if ((a1 == a5) && (a2 == a4))
    Console.WriteLine("Число является палиндромом ");
else
{
    Console.WriteLine("Число не является палиндромом ");
}