//  Задача 11.
// Напишите программу, которая
// 1. выводит случайное трехзначное число и
// 2. удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из диапазона 100 - 999 -> {number} ");

// int firstDigit = number / 100;

// int treeDigit = number % 10;  

// int rezult = firstDigit * 10 + treeDigit;
// Console.WriteLine(rezult);

int rand = new Random().Next(100, 1000);

int DelDigit(int number)
{
    int rezult = ((number / 100)*10 + number % 10);
    return rezult;
}
int newDigit = DelDigit(rand);
Console.WriteLine($"{rand} -> {newDigit}");
