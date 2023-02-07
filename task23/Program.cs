// Задача 23: 
// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27 

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int counter = number;
counter = 1;
while (counter <= number)
{
    Console.WriteLine($"{counter} {Math.Pow((counter),3)} ");
    counter = counter + 1;
}
