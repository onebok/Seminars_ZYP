// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей
// суммой элементов.

var array = Generate2DArray(4, 5);
Print2DArray(array);
Console.WriteLine();
Console.WriteLine(GetSumLineElement(array));

int GetSumLineElement(int[,] arr)
{
    int sum = int.MaxValue;
    int index = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        int result = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            result = result + arr[i, j];
        }
        if(result < sum)
        {
            sum = result;
            index = i;
        }
    }
    return index;
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
