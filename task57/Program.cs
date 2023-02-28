// Задача 57: Составить частотный словарь элементов двумерного
// массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

var arr = Generate2DArray(5, 6);
Print2DArray(arr);
Console.WriteLine();
var LionerArr = GetRowArray(arr);
PrintArray(LionerArr);
Array.Sort(LionerArr);
Console.WriteLine();
PrintArray(LionerArr);
Console.WriteLine();
Console.WriteLine();
GetCountOfEachElement(LionerArr);

void GetCountOfEachElement(int[] array)
{
    int el = array[0];
    int count = 1;
    for(int i = 1; i < array.Length; i++)
    {
        if(el != array[i])
        {
            Console.WriteLine($"Element {el} count =>{count}");
            count = 1;
            el = array[i];
        }
        else
        {
            count++;   
        }
    }
}


int[] GetRowArray(int[,] arr)
{
    int[] result = new int[arr.GetLength(0) * arr.GetLength(1)];
    int index = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            result[index] = arr[i, j];
            index++;
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

void PrintArray(int[] arr)
{
    
    foreach(int item in arr)
    {
        Console.Write($"{item}, ");
    } 
    Console.WriteLine();
}
