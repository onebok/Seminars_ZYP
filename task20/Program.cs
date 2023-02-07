// Задача 20.
// Напишите программу, которая
// 1. принимает на вход координаты двух точек и
// 2. находит расстояние между ними в 3D
// пространстве.
// A(3, 6, 8); B(2, 1, -7); -> 15,84
// A(7, -5, 0); B(1, -1, 9) -> 11,53

Console.WriteLine("Введите координаты первой точки ");
Console.Write("X1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
Console.Write("X2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int argx1, int argy1, int argz1, int argx2, int argy2, int argz2)
{  
    double res = Math.Sqrt(Math.Pow((argx2 - argx1),2) + Math.Pow((argy2 - argy1),2) + Math.Pow((argz2 - argz1),2));
    return res;
}

double distance =  Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));
