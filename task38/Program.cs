// Задача 38.
// Задайте массив вещественных чисел. 
// Найдите разницу между 
// максимальным и минимальным элементов массива.

int[] newArr = RandomArray(5);
PrintArray(newArr);
System.Console.WriteLine(GetMaxNum(newArr) - GetMinNum(newArr));


int GetMaxNum(int[] arr)
{
    int numMax = arr[1];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > numMax)
        {
            numMax = arr[i];
        }
    }
    return numMax;
}

int GetMinNum(int[] arr)
{
    int numMin = arr[1];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < numMin)
        {
            numMin = arr[i];
        }
    }
    return numMin;
}


int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(0,100);
     }
     return arr;
}

void PrintArray(int[] arr)
{    
    foreach(int item in arr)
    {
        Console.Write($"{item}, ");
    } 
    Console.WriteLine();
}
