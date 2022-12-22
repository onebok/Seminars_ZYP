// Напишите программу, которая 
// выводит
// 1. случайное число из отрезка [10, 99]
// и 
// 2. показывает наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 -> {number} ");

int firstdigit =  number / 10;
int seconddigit =  number % 10;
if (firstdigit > seconddigit) Console.WriteLine($"Наибольшая цифра числа {firstdigit} ");
else Console.WriteLine($"Наибольшая цифра числа {seconddigit} ");
