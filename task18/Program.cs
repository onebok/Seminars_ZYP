// Задача 18.
// Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (X и Y).


Console.WriteLine("Введите номер четверти");

int number = Convert.ToInt32(Console.ReadLine());

string range = Quarter(number);

Console.WriteLine(range);

string Quarter(int num)	
	{			
		if (num == 1) return "X > 0, Y > 0"; 
		if (num == 2) return "X < 0, Y > 0";
		if (num == 3) return "X < 0, Y < 0";
		if (num == 4) return "X > 0, Y < 0";
		return "Нет такой четверти";

	}
