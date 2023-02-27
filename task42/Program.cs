﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int binNum = ConvertNumberToBinary(number);
Console.WriteLine($"{number} -> {binNum}");
int ConvertNumberToBinary (int num)
{
	int binaryNum = default;
	int count = 1;
	while (num > 0)
	{
		binaryNum = binaryNum + num % 2 * count;
		count = count*10;
		num = num / 2;
	}
	return binaryNum;
}
