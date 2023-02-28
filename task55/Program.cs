// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

var home = Generate2DArray(4, 4);
Print2DArray(home);
Console.WriteLine();

Print2DArray(ChangeOrder(home));

int[,] ChangeOrder(int[,] arr)
{
    int[,] matr = new int[arr.GetLength(0), arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
       for(int j = 0; j < arr.GetLength(1); j++)
       {
        matr[i, j] = arr[j, i];
       }
    }
    return matr;
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
