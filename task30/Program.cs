﻿// Задача 30: 
// Напишите программу, которая 
// выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]




int[] array = new int[8];
GetArray(array);
PrintArray(array);

void GetArray(int[] arr)
{
 int length = arr.Length;
for (int i = 0; i < length; i++)
{
    arr [i] = new Random().Next(0,2);
}
   
}
void PrintArray(int[] array)
{
    int count  = array.Length;
    for (int i = 0; i < count; i++)
    {
       Console.Write($"{array[i]} ");
    }
       Console.WriteLine();
}
