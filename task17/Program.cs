// Задача 17.
// Напишите программу, которая
// 1. принимает на вход координаты точки (X и Y), 
// 2. причем X не равен 0 и Y не равен 0 и
// 3. выдает номер четверти плоскости, в которой
// находится эта точка.

Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);

string rezult = quarter >0 
? $"Указанные координаты соответствуют четверти -> {quarter}" 
: "Введены некорректные координаты";

Console.WriteLine(rezult);

int Quarter(int xc, int yc)	
	{			
		if (xc > 0 && yc > 0) return 1; // функция объявлена, 
						//но не используется
		if (xc < 0 && yc > 0) return 2;
		if (xc < 0 && yc < 0) return 3;
		if (xc > 0 && yc < 0) return 4;
		return 0;
	}

