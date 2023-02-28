// Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

var arr = Generate2DArray(3, 4);
Print2DArray(arr);
System.Console.WriteLine();
ChangeLine(arr);
Print2DArray(arr);


void ChangeLine(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(1); i++)
        {
            int firstArr = arr[0, i];
            arr[0, i] = arr[arr.GetLength(0) - 1, i];
            arr[arr.GetLength(0) - 1, i] = firstArr;
        }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    {
        for(int i = 0; i < result.GetLength(0); i++)
        {
            for(int j = 0; j < result.GetLength(1); j++)
            {
                    result[i, j] = new Random().Next(1, 10);
            }
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
        {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

