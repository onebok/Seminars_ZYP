//Задача 40.
// Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

Console.WriteLine(CheckTriangle(2, 3, 4));

bool CheckTriangle(int a, int b, int c)
{
    return(((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}
