// Задача 54: Задайте двумерный массив. 
// Напишите программу, 
// которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

var array = Generate2DArray(4, 4);
Print2DArray(array);
System.Console.WriteLine();
GetSorteMore(array);
Print2DArray(array);

void GetSorteMore(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for(int n = 0; n < arr.GetLength(1) - 1; n++) 
        {
            if (arr[i, n] < arr[i, n + 1])
            {
            int more = arr[i, n + 1];
            arr[i, n + 1] = arr[i, n];
            arr[i, n] = more;
            }
        }
    }
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
