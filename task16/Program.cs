//  Задача 16.
// Напишите программу, которая
// 1. принимает на вход два числа и
// 2. прооверяет, является ли одно
// квадратом второго
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

// int square1 = number1 * number1;
// // Console.WriteLine($"{square1}");
// int square2 = number2 * number2;
// // Console.WriteLine($"{square2}");

// if (square1 % square2 ==0 || square2 % square1 ==0)
// {
//     Console.WriteLine("да");
// }
// else 
// {
//     Console.WriteLine("нет");
// } 
Console.WriteLine(IsSquare(number1, number2) ? "да" : "нет");

bool IsSquare(int n1, int n2)
{
   return (n1 / n2 == n2) || (n2 / n1 == n1);
}
