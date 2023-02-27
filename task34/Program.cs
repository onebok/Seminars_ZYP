// Задача 34.
// Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int[] newArr = RandomArray(10);
PrintArray(newArr);
Console.WriteLine(GetMeEven(newArr));

int GetMeEven(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(100,1000);
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
