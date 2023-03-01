// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.

var array1 = Generate2DArray(2, 3);
var array2 = Generate2DArray(3, 2);
Print2DArray(array1);
Console.WriteLine();
Print2DArray(array2);
Console.WriteLine();
var multiplyMatrix = GetMultiplyMatrix(array1, array2);
Print2DArray(multiplyMatrix);

int[,] GetMultiplyMatrix(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr1.GetLength(1)];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(0); j++)
        {
            for(int n = 0; n < arr1.GetLength(0); n++)
            {
            result[i, j] = result[i, j] + arr1[i, n] * arr2[n, j];
            }
        }
    }
    return result;
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    {
        for(int i = 0; i < result.GetLength(0); i++)
        {
            for(int j = 0; j < result.GetLength(1); j++)
            {
                    result[i, j] = new Random().Next(1, 5);
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

