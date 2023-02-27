// Задача 45.
// Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

int[] arr = RandomArray(10);
PrintArray(arr);
int[] arr2 = CopyArray(arr);
PrintArray(arr2);

int[] CopyArray(int[] arr)
{
    int[] newArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}


int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(1,100);
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
