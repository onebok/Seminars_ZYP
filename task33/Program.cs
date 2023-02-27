// Задача 33: 
// 1. Задайте массив. Напишите программу, которая 
// 2. определяет, присутствует ли заданное число в массиве.
// 4 -> массив [6, 7, 19, 345, 3] -> нет
// -3 -> массив [6, 7, 19, 345, 3] -> да

int[] newArr = RandomArray(10);
PrintArray(newArr);
System.Console.WriteLine(GetFindNum(-2, newArr));

bool GetFindNum(int num, int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
        {
            return true;
        }
    }
    return false;
}


int[] RandomArray(int length)
{
     int[]arr = new int[length];
     for(int i = 0; i < length; i++)
     {
         arr[i] = new Random().Next(-9,10);
     }
     return arr;
}

void PrintArray(int[] arr)
{
    
    foreach(int item in arr)
    {
        System.Console.Write($"{item}, ");
    } 
    System.Console.WriteLine();
}
