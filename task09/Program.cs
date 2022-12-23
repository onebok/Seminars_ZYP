// Задача 09
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

// int firstDigit =  number / 10;
// int secondDigit =  number % 10;
// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {firstDigit} ");
// else Console.WriteLine($"Наибольшая цифра числа {secondDigit} ");

// Console.Write("Наибольшая цифра числа = ");
// // интерполяция не нужна $ нет как в 15 строке
// // Тернарный оператор
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

// int rezult = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.Write("Наибольшая цифра числа = ");
// Console.WriteLine(rezult);


// создаем методы  (функции)

int maxDigit = MaxDigit(number);    // глобальная переменная
Console.Write($"Наибольшая цифра числа = {maxDigit}");

int MaxDigit(int num)   // это уже параметр, а не глобальная переменная
{
    int firstDigit = num / 10;
    int secondDigit = num % 10; // меняем number на num
    // int rezult = firstDigit > secondDigit ? firstDigit : secondDigit;
    // return rezult;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

// int maxDigit = MaxDigit(number); может располагаться внизу
// Console.Write($"Наибольшая цифра числа = {maxDigit}");

