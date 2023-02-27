// Задача 43: Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int b1 = new Random().Next(0, 10);
int b2 = new Random().Next(0, 10);
int k1 = new Random().Next(0, 10);
int k2 = new Random().Next(0, 10);

void Intersection(int b1, int b2, int k1, int k2)
{
int y = 0;
int x = 0;
x = (b2 - b1) / (k2 - k1);
y = k1 * x + b1;
Console.WriteLine($"({x},{y})");
}

Intersection(b1, b2, k1, k2);
