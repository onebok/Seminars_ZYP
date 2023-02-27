// Задача 35: 
// 1. Задайте одномерный массив из 123 случайных чисел. 
// 2. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] newArr = RandomArray(123);
PrintArray(newArr);
Console.WriteLine(FindNumInInterval(newArr, 10, 99));


int FindNumInInterval(int[] array, int num1, int num2)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= num1 && array[i] <= num2)
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
         arr[i] = new Random().Next(1,1000);
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
